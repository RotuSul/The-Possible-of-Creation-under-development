using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace The_Possible_of_Creation
{
    public class Program
    {
        public void Main()
        {
            GraficPixel3D metod1 = new GraficPixel3D();
            metod1.Grafic3D();
        Finish:
                ConsoleColor PenDay = ConsoleColor.Blue;
                Console.BackgroundColor = PenDay;
                Console.Write(PenDay);
                Console.Clear();


                TimeSpan Night = new TimeSpan(0, 2, 24);
                Thread.Sleep(Night);

                ConsoleColor PenNight = ConsoleColor.Black;
                Console.BackgroundColor = PenNight;
                Console.Write(PenNight);
                Console.Clear();


                TimeSpan Day = new TimeSpan(0, 0, 0, 2);
                Thread.Sleep(Day);
                goto Finish;

            Console.ReadLine();

            }

    }
    }

