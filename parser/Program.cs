using System.Text;

var dualWriter = new DualWriter("output.txt");
Console.SetOut(dualWriter);
Console.WriteLine("! Console output duplicated to output.txt file");

ParseCpu();
ParseGpu();

List<StoreData> _storeData = new List<StoreData>();
ParseStoreOwn();
ParseStore();
ParseStore2();

GenerateStoreFull();
GenerateCpuFull();

GenerateMarkDown();

List<CpuData> _cpuData;
Dictionary<string, CpuData> _cpuShortName;
List<GpuData> _gpuData;
Dictionary<string, GpuData> _gpuShortName;
List<StoreFullData> _storeFullData;
List<CpuFullData> _cpuFullData;

void GenerateMarkDown()
{
    decimal maxSingle = 0;
    decimal maxMulti = 0;
    decimal maxGpu = 0;
    foreach (var i in _cpuFullData)
    {
        if (i.CpuRef.Rating == null || i.CpuRef.Rating < 0)
            continue;

        i.Notebooks.Sort((a, b) => a.RetailPrice.Value.CompareTo(b.RetailPrice.Value));
        if (i.CpuRef.SinglePerformance > maxSingle)
            maxSingle = i.CpuRef.SinglePerformance.Value;
        if (i.CpuRef.Threads == "8/16" && i.CpuRef.MultiPerformance > maxMulti)
            maxMulti = i.CpuRef.MultiPerformance.Value;
        if (i.GpuRef != null && i.GpuRef.Performance > maxGpu)
            maxGpu = i.GpuRef.Performance.Value;

        //smallest price
        //i.Price = i.Notebooks[0].RetailPrice.Value;

        //smallest, but not first
        /*if (i.Notebooks.Count > 1)
            i.Price = i.Notebooks[1].RetailPrice.Value;
        else
            i.Price = i.Notebooks[0].RetailPrice.Value;
        */

        //median price
        if (i.Notebooks.Count == 1)
            i.Price = i.Notebooks[0].RetailPrice.Value;
        else if (i.Notebooks.Count % 2 == 0)
            i.Price = i.Notebooks[i.Notebooks.Count / 2].RetailPrice.Value;
        else
            i.Price = (i.Notebooks[(i.Notebooks.Count - 1) / 2].RetailPrice.Value + i.Notebooks[(i.Notebooks.Count + 1) / 2].RetailPrice.Value) / 2;
        
    }

    foreach (var i in _cpuFullData)
    {
        if (i.CpuRef.Rating == null || i.CpuRef.Rating < 0)
            continue;

        i.CpuSingleRating = Convert.ToInt32(i.CpuRef.SinglePerformance.Value / maxSingle * 100);
        i.CpuMultiRating = Convert.ToInt32(i.CpuRef.MultiPerformance.Value / maxMulti * 100);
        i.GpuRating = Convert.ToInt32((i.GpuRef?.Performance ?? 0)/ maxGpu * 100);
        i.TotalRating = i.CpuSingleRating + i.CpuMultiRating + i.GpuRating;
    }
    _cpuFullData.Sort((a, b) => -a.TotalRating.CompareTo(b.TotalRating));

    Console.WriteLine("| # | Processor (GPU) | Tdp | Core/Thr | Freq GHz | SCore | MCore | GPU | Total | Price RUB | Value |");
    Console.WriteLine("|---|-----------------|-----|----------|----------|-------|-------|-----|-------|-----------|-------|");
    for (int i = 0; i < _cpuFullData.Count; i++)
    {
        var c = _cpuFullData[i];
        if (c.CpuRef.Rating == null || c.CpuRef.Rating < 0)
            continue;

        Console.WriteLine($"| {i + 1} | {c.CpuRef.Name} ({c.GpuRef?.NameShort2}) | {Color(c.CpuRef.Tdp ?? 0, 28, 0, true)}-{c.CpuRef.TdpTurbo} | {c.CpuRef.Threads} | {Freq(c.CpuRef.Frequency)} | " +
            $"{Color(c.CpuSingleRating, 40, 60)} | {Color(c.CpuMultiRating, 40, 60)} | {Color(c.GpuRating, 25, 50)} | {c.TotalRating} | {Price(c.Price)} | {Rating((decimal)c.TotalRating / c.Price * 1000)} |");
    }

    Console.WriteLine("const data = [");
    for (int i = 0; i < _cpuFullData.Count; i++)
    {
        var c = _cpuFullData[i];
        if (c.CpuRef.Rating == null || c.CpuRef.Rating < 0)
            continue;

        var valueNum = (decimal)c.TotalRating / c.Price * 1000;
        string valueStr = FormattableString.Invariant($"{valueNum:F1}");

        var freq = Freq(c.CpuRef.Frequency).Replace(",", ".").Split('/');
        string freq1 = freq[0];
        string freq2 = freq.Length > 1 ? freq[1] : freq[0];

        var threads = c.CpuRef.Threads.Split('/');

        Console.WriteLine($$"""
      {
        id: {{i + 1}},
        cpuname: "{{c.CpuRef.Name}}",
        gpuname: "{{c.GpuRef?.NameShort2}}",
        tdp: {{c.CpuRef.Tdp}},
        tdpTurbo: {{c.CpuRef.TdpTurbo ?? c.CpuRef.Tdp}},
        cores: {{threads[0]}},
        threads: {{threads[1]}},
        freq: {{freq1}},
        freqTurbo: {{freq2}},
        score: {{c.CpuSingleRating}},
        mcore: {{c.CpuMultiRating}},
        gpu: {{c.GpuRating}},
        total: {{c.TotalRating}},
        price: {{c.Price:F0}},
        value: {{valueStr}},
      },
""");
    }
    Console.WriteLine("];");
}

string Rating(decimal r)
{
    var rf = $"{r:F1}";
    if (r > 2)
        return "$${\\color{green}" + rf + "}$$";
    return rf;
}

string Price(decimal p)
{
    var pf = $"{p:N0}";
    if (p < 50000)
        return "$${\\color{green}" + pf + "}$$";
    return pf;
}

string Freq(string f)
{
    var data = f.Split('‑');
    string res = string.Join("/", data.Select(d => d.Trim()).Where(d => !string.IsNullOrEmpty(d)).Select(d => $"{decimal.Parse(d) / 1000:F1}"));
    return res;
}

string Color(decimal rating, int min, int max, bool inverse = false)
{
    if (min != 0 && inverse ? rating > min : rating < min)
        return "$${\\color{red}" + rating + "}$$";
    else if (max != 0 && inverse ? rating < max : rating > max)
        return "$${\\color{green}" + rating + "}$$";
    return rating.ToString();
}

void GenerateCpuFull()
{
    _cpuFullData = new List<CpuFullData>();
    Dictionary<string, CpuFullData> htCpu = new Dictionary<string, CpuFullData>();
    foreach (var i in _storeFullData)
    {
        if (i.CpuRef == null)
            continue;

        if (htCpu.ContainsKey(i.CpuRef.Name))
        {
            htCpu[i.CpuRef.Name].Notebooks.Add(i.StoreRef);
        }
        else
        {
            if (i.CpuRef.NameProducer == "Apple")
                continue;

            var full = new CpuFullData()
            {
                CpuRef = i.CpuRef,
                GpuRef = i.GpuRef,
                Notebooks = new List<StoreData>() { i.StoreRef }
            };
            htCpu.Add(i.CpuRef.Name, full);
            _cpuFullData.Add(full);
        }
    }

    foreach (var i in _cpuFullData)
    {
        if (i.CpuRef.Rating == null || i.CpuRef.Rating <= 0)
            EstimateCpu(i.CpuRef);

        if (i.CpuRef.Rating == null || i.CpuRef.Rating <= 0)
            Console.WriteLine($"No rating for cpu: {i.CpuRef.Name}");
        else if (i.CpuRef.SinglePerformance == null || i.CpuRef.SinglePerformance <= 0)
            Console.WriteLine($"No single perf for cpu: {i.CpuRef.Name}");
        else if (i.CpuRef.MultiPerformance == null || i.CpuRef.MultiPerformance <= 0)
            Console.WriteLine($"No multi perf for cpu: {i.CpuRef.Name}");

        if (i.GpuRef == null)
            Console.WriteLine($"No gpu for cpu: {i.CpuRef.Name}");
        else
        {
            if (i.GpuRef.Rating == null || i.GpuRef.Rating <= 0)
                EstimateGpu(i.GpuRef);

            if (i.GpuRef.Rating == null || i.GpuRef.Rating <= 0)
                Console.WriteLine($"No gpu rating for cpu: {i.CpuRef.Name}, gpu: {i.GpuRef.Name}");
            else if (i.GpuRef.Performance == null || i.GpuRef.Performance <= 0)
                Console.WriteLine($"No gpu perf for cpu: {i.CpuRef.Name}, gpu: {i.GpuRef.Name}");
        }

        /*Console.WriteLine($"====== {i.CpuRef.Name} - {i.GpuRef?.Name}");
        foreach (var n in i.Notebooks)
            Console.WriteLine(n.Desc);*/
    }
}

void EstimateGpu(GpuData gpuRef)
{
    GpuData brother = null;
    if (gpuRef.Name == "AMD Radeon 840M")
        brother = _gpuShortName["Radeon 740M"];
    if (gpuRef.Name == "Intel Arc Graphics 130T")
        brother = _gpuShortName["Arc Graphics 140V"];

    if (brother != null)
    {
        gpuRef.Rating = brother.Rating;
        gpuRef.Performance = brother.Performance;
    }
}

void EstimateCpu(CpuData cpuRef)
{
    CpuData brother = null;
    if (cpuRef.Name == "AMD Ryzen 3 7335U")
        brother = _cpuShortName["Ryzen Z2 Go"];
    else if (cpuRef.Name == "AMD Ryzen 3 7320U")
        brother = _cpuShortName["Ryzen 5 7520U"];
    else if (cpuRef.Name == "Intel Core 5 210H")
        brother = _cpuShortName["i5-13420H"];
    else if (cpuRef.Name == "AMD Ryzen AI 5 340")
        brother = _cpuShortName["Ryzen 5 8640U"];
    else if (cpuRef.Name == "Intel Core Ultra 5 225H")
        brother = _cpuShortName["Ultra 5 125H"];
    else if (cpuRef.Name == "AMD Ryzen 3 5425U")
        brother = _cpuShortName["Ryzen 3 5400U"];
    else if (cpuRef.Name == "Intel Core i3-1305U")
        brother = _cpuShortName["U300"];
    else if (cpuRef.Name == "AMD Ryzen 3 7330U")
        brother = _cpuShortName["Ryzen 3 5400U"];
    else if (cpuRef.Name == "Intel Core i5-14500HX")
        brother = _cpuShortName["i7-13650HX"];
    else if (cpuRef.Name == "AMD Ryzen 5 PRO 7540U")
        brother = _cpuShortName["Ryzen 5 7540U"];
    else if (cpuRef.Name == "Intel Core Ultra 7 255HX")
        brother = _cpuShortName["i7-14700HX"];
    else if (cpuRef.Name == "Intel Core i5-12600H")
        brother = _cpuShortName["i5-12500H"];
    else if (cpuRef.Name == "AMD Ryzen 7 7435H")
        brother = _cpuShortName["Ryzen 7 7735H"];
    else if (cpuRef.Name == "AMD Ryzen 9 9955HX3D")
        brother = _cpuShortName["Ryzen 9 7945HX3D"];
    else if (cpuRef.Name == "Intel Core i7-13850HX")
        brother = _cpuShortName["i7-14700HX"];
    else if (cpuRef.Name == "Intel Core i3-1000G1")
        brother = _cpuShortName["i3-1000NG4"];
    else if (cpuRef.Name == "AMD Athlon Silver 7120U")
        brother = _cpuShortName["Athlon Silver 3050U"];

    if (brother != null)
    {
        cpuRef.Rating = brother.Rating;
        cpuRef.SinglePerformance = brother.SinglePerformance;
        cpuRef.MultiPerformance = brother.MultiPerformance;
    }
}

void GenerateStoreFull()
{
    _storeFullData = new List<StoreFullData>();
    foreach (var item in _storeData)
    {
        CpuData cpu = null;
        GpuData gpu = null;
        foreach (var c in _cpuData)
        {
            string cpuName = c.NameShort.Replace("-", " ");
            string cpuName2 = cpuName.Replace("Ryzen ", "");
            string desc = item.Desc.Replace("-", " ");
            var search = new List<(string, string)>()
            {
                ("123", "123"),
                (" HX ", " "),
                (" Ultra7 ", " Ultra 7 "),
                ("Ryzen 5 5675U", "Ryzen 5 Pro 5675U"),
                ("i51240P", "i5 1240P"),
                ("Ryzen3", "Ryzen 3"),
                (" Ultra ", " Core Ultra "),
                ("i914900HX", "i9 14900HX"),
                ("i512600H", "i5 12600H"),
                ("Core Ultra 7 226V", "Core Ultra 5 226V"),
                ("Intel Core i5 7440EQ", "Intel Core i5 7440HQ"),
                ("AMD Ryzen 5 7235HS", "AMD Ryzen 5 7535HS"),
                ("AMD Ryzen 9 7940H", "AMD Ryzen 9 7940HS"),
                (" Pentium ", " Pentium Silver ")
            };
            foreach (var s in search)
            {
                var newDesc = desc.Replace(s.Item1, s.Item2);
                if (newDesc.ToLower().Contains(cpuName.ToLower()) || newDesc.ToLower().Contains(cpuName2.ToLower()))
                {
                    cpu = c;
                    break;
                }
            }
            if (cpu != null)
                break;
        }
        if (cpu == null)
        {
            if (!item.Desc.ToLower().Contains(" apple "))
                Console.WriteLine($"### Cpu not found: {item.Desc}");
        }
        else
        {
            string gpuName = cpu.Gpu;
            if (cpu.NameShort.Contains("3500U"))
                gpuName = gpuName + " (Ryzen 2000/3000)";
            if (gpuName == "UHD Graphics 32EUs")
                gpuName = "UHD Graphics Xe 750 32EUs";
            if (gpuName == "Arc 8-Core")
                gpuName = "Arc 8-Core iGPU";
            if (gpuName == "Graphics 4-Core")
                gpuName = "Graphics 4-Core iGPU (Arc)";
            if (gpuName == "Arc 7-Core")
                gpuName = "Arc 7-Core iGPU";
            if (gpuName == "Arc 140V")
                gpuName = "Arc Graphics 140V";
            if (gpuName == "Arc 130V")
                gpuName = "Arc Graphics 130V";
            if (gpuName == "Arc 140T")
                gpuName = "Arc Graphics 140T";
            if (gpuName == "Arc 130T")
                gpuName = "Arc Graphics 130T";
            if (gpuName == "Adreno X1-45 1.7 TFLOPS")
                gpuName = "SD X Adreno X1-45 1.7 TFLOPS";
            if (gpuName == "Adreno X1-85 3.8 TFLOPS")
                gpuName = "SD X Adreno X1-85 3.8 TFLOPS";
            if (gpuName.EndsWith("Ryzen 4000 5000"))
                gpuName = gpuName.Replace("Ryzen 4000 5000", "(Ryzen 4000/5000)");
            if (gpuName.EndsWith("Ryzen 4000"))
                gpuName = gpuName.Replace("Ryzen 4000", "(Ryzen 4000/5000)");
            if (!_gpuShortName.ContainsKey(gpuName))
            {
                if (gpuName != "")
                    Console.WriteLine($"!!! Gpu not found for cpu: {cpu.Name}, shortName: {cpu.NameShort}, gpu: {gpuName}");
            }
            else
            {
                gpu = _gpuShortName[gpuName];
            }
        }

        var fullData = new StoreFullData();
        fullData.StoreRef = item;
        fullData.CpuRef = cpu;
        fullData.GpuRef = gpu;
        _storeFullData.Add(fullData);
    }
}

void ParseCpu()
{
    // Пример использования
    var html = File.ReadAllText("cpu.html");
    var parser = new CpuParser();
    var results = parser.ParseHtml(html);

    _cpuData = new List<CpuData>();
    _cpuShortName = new Dictionary<string, CpuData>();
    foreach (var cpu in results)
    {
        /*Console.WriteLine($"Name: {cpu.Name}, Producer: {cpu.NameProducer}, Short name: {cpu.NameShort}, " +
            $"Cache: {cpu.Cache}, Tdp: {cpu.Tdp}, TdpTurbo: {cpu.TdpTurbo}, " +
            $"Frequency: {cpu.Frequency}, Threads: {cpu.Threads}, Process: {cpu.Process}, Days: {cpu.Days}, " +
            $"Gpu: {cpu.Gpu}, Rating: {cpu.Rating}, Single: {cpu.SinglePerformance}, Multi: {cpu.MultiPerformance}");*/
        if (cpu.Name == "unknown")
            continue;

        if (string.IsNullOrEmpty(cpu.NameProducer))
        {
            Console.WriteLine($"!!!Empty cpu producer: {cpu.Name}");
            continue;
        }
        if (string.IsNullOrEmpty(cpu.NameShort))
        {
            Console.WriteLine($"!!!Empty cpu short name: {cpu.Name}");
            continue;
        }
        
        _cpuData.Add(cpu);
        _cpuShortName[cpu.NameShort!] = cpu;
    }
}

void ParseGpu()
{
    // Пример использования
    var html = File.ReadAllText("gpu.html");
    var parser = new GpuParser();
    var results = parser.ParseHtml(html);

    _gpuData = new List<GpuData>();
    _gpuShortName = new Dictionary<string, GpuData>();
    foreach (var gpu in results)
    {
        /*Console.WriteLine($"Name: {gpu.Name}, Producer: {gpu.NameProducer}, Short name: {gpu.NameShort}, " +
            $"Shaders: {gpu.Shaders}, Core: {gpu.Core}, Turbo: {gpu.Turbo}, " +
            $"DirectX: {gpu.DirectX}, OpenGL: {gpu.OpenGL}, Process: {gpu.Process}, Days: {gpu.Days}, " +
            $"Rating: {gpu.Rating}, Perf: {gpu.Performance}");*/

        if (gpu.Name == "unknown")
            continue;

        if (string.IsNullOrEmpty(gpu.NameProducer))
        {
            Console.WriteLine($"!!!Empty gpu producer: {gpu.Name}");
            continue;
        }
        if (string.IsNullOrEmpty(gpu.NameShort))
        {
            Console.WriteLine($"!!!Empty gpu short name: {gpu.Name}");
            continue;
        }

        _gpuData.Add(gpu);
        _gpuShortName[gpu.NameShort!] = gpu;
    }
}

void ParseStore()
{
    // Пример использования
    var html = File.ReadAllText("store.html");
    var parser = new StoreParser();
    var results = parser.ParseHtml(html);
    _storeData.AddRange(results);

    foreach (var item in results)
    {
        /*Console.WriteLine($"Art: {item.Art}, Code: {item.Code}, Model: {item.Model}, " +
            $"Desc: {item.Desc}, " +
            $"Avail: {item.Avail}, OptPrice: {item.OptPrice}, RetailPrice: {item.RetailPrice}");*/
    }
}

void ParseStore2()
{
    // Пример использования
    var html = File.ReadAllText("store2.html");
    var parser = new StoreParser2();
    var results = parser.ParseHtml(html);
    _storeData.AddRange(results);

    foreach (var item in results)
    {
        /*Console.WriteLine($"Art: {item.Art}, Code: {item.Code}, Model: {item.Model}, " +
            $"Desc: {item.Desc}, " +
            $"Avail: {item.Avail}, OptPrice: {item.OptPrice}, RetailPrice: {item.RetailPrice}");*/
    }
}

void ParseStoreOwn()
{
    _storeData.Add(new StoreData
    {
        Desc = "My notebook: Intel Core i5-8265U Acer Swift 3 2018",
        RetailPrice = 30000
    });
}