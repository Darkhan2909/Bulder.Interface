using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulder.Interface
{
    internal class Window : IPart
    {
        public string Color { get; set; }
        public TimeSpan ConstructionTime { get; set; }
        public TypeOfMateriyal TypeOfMateryal { get; set; }
        public int Count { get; set; }
        public double MateryalPrrice { get; set; }
        public int Sort { get; set; }
        public bool isComplited { get; set; }

        public double GetConstructionCost()
        {
            return ConstructionTime.TotalMilliseconds;
        }

        public TimeSpan GetConstructionTime()
        {
            return ConstructionTime;
        }
    }
}
