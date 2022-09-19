using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bulder.Interface;
namespace Bulder.Interface
{
    public enum TypeOfMateriyal { brick=5, wood, glass }
    public interface IPart
    {
        string Color { get; set; }
        TimeSpan ConstructionTime { get; set; }
        TypeOfMateriyal TypeOfMateryal { get; set; }
        int Count { get; set; }
        double MateryalPrrice { get; set; }
        int Sort { get; set; }

        bool isComplited { get; set; }
        TimeSpan GetConstructionTime();
        double GetConstructionCost();
    }
}
