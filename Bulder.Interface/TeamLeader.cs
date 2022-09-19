using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulder.Interface
{
    internal class TeamLeader : IWorker
    {
        public string WorkerName { get; set; }
        public int WorkerCount { get; set; }
        public string WorkerId { get; set; }
        public WorkerProfession WorkerProfession { get; set; }
        public List<IPart> WorkLists { get; set; }

        public void PrintSeloryInfo()
        {
        }



    }
}
