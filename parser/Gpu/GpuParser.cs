using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;

public class GpuParser
{
    public List<GpuData> ParseHtml(string html)
    {
        var doc = new HtmlDocument();
        doc.LoadHtml(html);
        var trAll = doc.DocumentNode.QuerySelectorAll("tr");
        var gpuList = new List<GpuData>();

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
                values[i] = value;
            }
            //if (values[1].Contains("UHD Graphics 770"))
            //    count = count;
            /*foreach (var td in values)
                Console.WriteLine(td);
            Console.WriteLine("======");
            return gpuList;*/
            var gpu = new GpuData
            {
                Name = values[1],
                Shaders = values[2]?.ToDecimal(),
                Core = values[3]?.ToDecimal(),
                Turbo = values[4]?.ToDecimal(),
                DirectX = values[5],
                OpenGL = values[6],
                Process = values[values.Length > 11 ? 8 : 7]?.ToDecimal(),
                Days = values[values.Length > 11 ? 9 : 8]?.ToDecimal(),
                Rating = values[values.Length > 11 ? 10 : 9]?.ToDecimal(),
                Performance = values[values.Length > 11 ? 11 : 10]?.ToDecimal()
            };
            gpuList.Add(gpu);
        }

        return gpuList;
    }
}
