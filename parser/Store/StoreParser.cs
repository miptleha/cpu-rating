using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;

public class StoreParser
{
    public List<StoreData> ParseHtml(string html)
    {
        var doc = new HtmlDocument();
        doc.LoadHtml(html);
        var trAll = doc.DocumentNode.QuerySelectorAll("#fullprice tbody tr");
        var goods = new List<StoreData>();

        int count = 0;
        foreach (var tr in trAll)
        {
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
                value = value.Replace("\n", "");
                values[i] = value;
            }
            /*foreach (var td in values)
                Console.WriteLine(td);
            Console.WriteLine("======");
            return goods;*/
            var item = new StoreData
            {
                Art = values[0],
                Code = values[1],
                Model = values[2],
                Desc = values[3],
                Avail = values[4],
                OptPrice = values[5]?.ToDecimal(),
                RetailPrice = values[6]?.ToDecimal()
            };
            goods.Add(item);
        }

        return goods;
    }
}
