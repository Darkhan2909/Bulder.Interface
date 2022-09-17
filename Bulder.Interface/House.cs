using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulder.Interface
{
    public class House
    {
        private List<IPart> Parts = new List<IPart>();
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
                        basement.ConstructionTime = new TimeSpan(0, 0, 0);
                        basement.Count = 1;
                        basement.MateryalPrrice = 8000;
                        
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        Walls walls = new Walls();
                        walls.Color = null;
                        walls.ConstructionTime = new TimeSpan(0, 0, 0);
                        walls.Count = 8;
                        walls.MateryalPrrice = 600;
                    }
                    for (int i = 0; i < 5; i++)
                    {

                        Door doors = new Door();
                        doors.Color = null;
                        doors.ConstructionTime = new TimeSpan(0, 0, 0);
                        doors.Count = 8;
                        doors.MateryalPrrice = 600;
                    }
                    break;
            }
        }
    }
}
