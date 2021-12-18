using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Length;
            
            if (myDelegate != null)
            {
                double D = myDelegate(6);
                Console.WriteLine("Длина окружности= {0}", D);
            }
            
            MyDelegate myDelegate1 = Area;
            if (myDelegate1 != null)
            {
                double S = myDelegate1(6);
                Console.WriteLine("Площадь= {0}", S);
            }
            MyDelegate myDelegate2 = Volume;
            if (myDelegate2 != null)
            {
                double V = myDelegate2(6);
                Console.WriteLine("Объем= {0}", V);
            }

            Console.ReadKey();
        }
        
        public static double Length(double r)
        {
            return  2 * Math.PI * r;
        }
        public static double Area(double r)
        {
            return  Math.PI * Math.Pow(r, 2);
        }
        public static double Volume(double r)
        {
            return  4/3*Math.PI* Math.Pow(r, 3);
        }
    }
}
