using System.Text.RegularExpressions;

public class CpuData
{
    public string? Name { get; set; }
    public string? NameProducer { get { return Name?.GetWordsInRange(1, 1); } }
    
    public string? NameShort 
    { 
        get 
        {
            string first = Name.GetWordsInRange(1, 1);
            if (first == "Apple")
            {
                var str = Regex.Replace(Name, @"\((\d+) cores\)", "$1-core");
                return str;
            }

            string second = Name.GetWordsInRange(2, 2);
            if (second == "Snapdragon")
            {
                string[] exclude = ["X", "Elite", "Plus"];
                string[] words = Name.GetWordsInRange(3).Split(' ');
                List<string> result = new List<string>();
                foreach (string word in words)
                {
                    if (exclude.Contains(word))
                        continue;
                    result.Add(word);
                }
                return string.Join(" ", result);
            }
            if (second == "Core" || second == "Processor" || second == "Celeron")
            {
                return Name.GetWordsInRange(3);
            }

            return Name.GetWordsInRange(2).Replace(" PRO ", " Pro "); 
        } 
    }

    public string? Cache { get; set; }
    public decimal? Tdp { get; set; }
    public decimal? TdpTurbo { get; set; }
    public string? Frequency { get; set; }
    public string? Threads { get; set; }
    public decimal? Process { get; set; }
    public decimal? Days { get; set; }
    public string? Gpu { get; set; }
    public decimal? Rating { get; set; }
    public decimal? SinglePerformance { get; set; }
    public decimal? MultiPerformance { get; set; }
}
