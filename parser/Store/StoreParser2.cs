using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;

public class StoreParser2
{
    public List<StoreData> ParseHtml(string html)
    {
        var doc = new HtmlDocument();
        doc.LoadHtml(html);
        var trAll = doc.DocumentNode.QuerySelectorAll("tr.search-result-row");
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
                var span = tag.QuerySelector("span");
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
            Console.WriteLine("======");*/
            var item = new StoreData
            {
                Desc = values[0],
                RetailPrice = values[5]?.ToDecimal() ?? values[6]?.ToDecimal()
            };
            goods.Add(item);
        }

        return goods;
    }
}
