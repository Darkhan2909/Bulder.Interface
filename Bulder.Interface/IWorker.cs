using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulder.Interface
{

    public enum WorkerProfession { Plumber, Worker,StoneWorker}
    public interface IWorker
    {
        string WorkerName { get; set; }

        int WorkerCount { get; set; }

        string WorkerId { get; set; }

        WorkerProfession WorkerProfession { get; set; }

        List<IPart> WorkLists { get; set; }
        void PrintSeloryInfo();
    }
}
