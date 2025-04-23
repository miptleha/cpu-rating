using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CpuFullData
{
    public CpuData CpuRef { get; set; }
    public int CpuSingleRating { get; set; }
    public int CpuMultiRating { get; set; }

    public GpuData GpuRef { get; set; }
    public int GpuRating { get; set; }

    public int TotalRating { get; set; }

    public List<StoreData> Notebooks { get; set; }
    public decimal Price { get; set; }
}
