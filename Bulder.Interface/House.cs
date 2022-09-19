using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bulder.Interface
{
    public class House
    {
        private List<IPart> parts = new List<IPart>();
        

        public House()
        {

        }
        public void CreateHouse(int num)
        {
            switch (num)
            {
                case 1:
                    for (int i = 0; i < 5; i++)
                    {
                        BaseMent basement = new BaseMent();
                        basement.Color = null;
                        basement.ConstructionTime = new TimeSpan(0, 0, 8);
                        basement.Count = 1;
                        basement.MateryalPrrice = 8000;
                        parts.Add(basement);

                    }
                    for (int i = 0; i < 5; i++)
                    {
                        Walls walls = new Walls();
                        walls.Color = null;
                        walls.ConstructionTime = new TimeSpan(0, 8, 0);
                        walls.Count = 8;
                        walls.MateryalPrrice = 600;
                        parts.Add(walls);
                    }
                    for (int i = 0; i < 5; i++)
                    {

                        Door doors = new Door();
                        doors.Color = null;
                        doors.ConstructionTime = new TimeSpan(0, 8, 0);
                        doors.Count = 8;
                        doors.MateryalPrrice = 600;
                        parts[i] = doors;
                        parts.Add(doors);
                    }
                    break;
            }
        }




        public List<Worker> CreateTeam()
        {

            List<Worker> workers = new List<Worker>();

            Random random = new Random();

            for (int i = 0; i < random.Next(5, 30); i++)
            {
                Worker worker = new Worker();
                worker.WorkerName = "Workers: " + i;
                worker.WorkerProfession = (WorkerProfession)random.Next(0, 2);
                worker.WorkerCount = random.Next(100, 5000);

                worker.WorkLists = new List<IPart>();
                workers.Add(worker);

            }

            return workers;

        }

        public void StartConstruction()
        {
            CreateHouse(1);
            var working = CreateTeam();
            int k = working.Count();
            Random random = new Random();
            foreach (IPart item in parts)
            {
                //working.FirstOrDefault(f => !f.isBusy);
                working[random.Next(0, k-1)].WorkLists.Add(item);
                for (int i = 0; i < item.ConstructionTime.Hours; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(100);
                }
                Console.WriteLine();
                Console.WriteLine("----------completed------------");
                item.isComplited = true;
            }

            foreach (Worker item in working.Where(w=>w.WorkLists.Count>0))
            {
                item.PrintSeloryInfo();
                Console.WriteLine("");
            }
            foreach (Worker item in working.Where(w => w.WorkLists.Count < 0))
            {
                item.PrintSeloryInfo();
            }
        }
    }
}
