using System.Text.RegularExpressions;

public class GpuData
{
    public string? Name { get; set; }
    public string? NameProducer { get { return Name?.GetWordsInRange(1, 1); } }
    
    public string? NameShort 
    { 
        get 
        {
            var ret = Name?.GetWordsInRange(2);
            if (ret.StartsWith("Iris Xe Graphics"))
                ret = ret.GetWordsInRange(1, 2) + " " + ret.GetWordsInRange(4);

            string[] ends = [" (Alder Lake 12th Gen)", " (Rocket Lake)"];
            foreach (var end in ends)
            {
                if (ret.EndsWith(end))
                {
                    ret = ret.Substring(0, ret.Length - end.Length);
                    break;
                }
            }

            return ret; 
        } 
    }

    public string? NameShort2
    {
        get
        {
            var res = Regex.Replace(NameShort, @"(.*?)\(.*\)", "$1");
            if (res.StartsWith("Radeon RX"))
                res = res.Substring("Radeon RX".Length);
            return res.Trim();
        }
    }
    
    public decimal? Shaders { get; set; }
    public decimal? Core { get; set; }
    public decimal? Turbo { get; set; }
    public string? DirectX { get; set; }
    public string? OpenGL { get; set; }
    public decimal? Process { get; set; }
    public decimal? Days { get; set; }
    public decimal? Rating { get; set; }
    public decimal? Performance { get; set; }
}
