using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;

public class CpuParser
{
    public List<CpuData> ParseHtml(string html)
    {
        var doc = new HtmlDocument();
        doc.LoadHtml(html);
        var trAll = doc.DocumentNode.QuerySelectorAll("tr");
        var cpuList = new List<CpuData>();

        int count = 0;
        foreach (var tr in trAll)
        {
            if (tr.HasClass("header"))
                continue;
            count++;
            var tdAll = tr.QuerySelectorAll("td").ToArray();
            var values = new string?[tdAll.Length];
            for (int i = 0; i < tdAll.Length; i++)
            {
                var tag = tdAll[i];
                var span = tag.QuerySelector("span span");
                if (span != null)
                    tag = span;
                var a = tag.QuerySelector("a");
                if (a != null)
                    tag = a;
                var value = tag.InnerHtml;
                value = HtmlEntity.DeEntitize(value)!;
                if (value.StartsWith("Vega") && a != null)
                {
                    var href = a.Attributes["href"].Value;
                    var words = href.Split('/')[^1].Split(['-', '.']);
                    var last = -1;
                    if (last == -1)
                        last = Array.IndexOf(words, "Graphics");
                    if (last == -1)
                        last = Array.IndexOf(words, "GPU");
                    if (words[0] == "AMD")
                        words = words[1..];
                    value = string.Join(" ", words[..(last-1)]);
                }
                values[i] = value;
            }
            /*foreach (var td in values)
            {
                Console.WriteLine(td);
            }
            Console.WriteLine("=========");*/
            var cpu = new CpuData
            {
                Name = values[1],
                CodeName = values[2],
                Cache = values[3],
                Tdp = values[4]?.ToDecimal(),
                TdpTurbo = values[5]?.ToDecimal(),
                Frequency = values[6],
                Threads = values[7],
                Process = values[8]?.ToDecimal(),
                Days = values[9]?.ToDecimal(),
                Gpu = values[10],
                Rating = values[11]?.ToDecimal(),
                SinglePerformance = values[12]?.ToDecimal(),
                MultiPerformance = values[13]?.ToDecimal()
            };
            cpuList.Add(cpu);
        }

        return cpuList;
    }
}
