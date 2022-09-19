using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulder.Interface
{
    public class Program
    {
        public enum TypeOfMateriyal { brick=5,wood=6,glass}
        static void Main(string[] args)
        {
            //var data = (int)TypeOfMateriyal.brick;
            //var data_s = TypeOfMateriyal.brick.ToString();

            //TypeOfMateriyal typeofMateriyal = TypeOfMateriyal.brick;
            //EvalEnum(typeofMateriyal);

            House house = new House();
            house.StartConstruction();

        }

        public static void EvalEnum(System.Enum e)
        {
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine(enumData.Length);
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value{0:D}", enumData.GetValue(i));
            }
        }
    }
}
