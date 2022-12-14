using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulder.Interface
{
    public class Worker : IWorker
    {
        internal bool isBusy;
        private double pricePerHour;

        public string WorkerName { get; set; }
        public int WorkerCount { get; set; }
        public string WorkerId { get; set; }
        public WorkerProfession WorkerProfession { get; set; }
        public List<IPart> WorkLists { get; set; }

        public void PrintSeloryInfo()
        {
            double selory = 0;
            foreach (IPart part in WorkLists)
            {
                selory += part.ConstructionTime.TotalHours * pricePerHour;
            }
            Console.WriteLine("Zarplata: {0} {1:#,0.00}",WorkerName, selory);
        }
    }
}
