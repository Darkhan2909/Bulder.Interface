using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulder.Interface
{
    public class Door : IPart
    {
        public string Color { get; set; }
        public TimeSpan ConstructionTime { get; set; }
        public TypeOfMateriyal TypeOfMateryal { get; set; }
        public int Count { get; set; }
        public double MateryalPrrice { get; set; }

        public double GetConstructionCost()
        {
            return MateryalPrrice * Count;
        }

        public TimeSpan GetConstructionTime()
        {
            return TimeSpan.FromTicks(ConstructionTime.Ticks * Count);
        }
    }
}
