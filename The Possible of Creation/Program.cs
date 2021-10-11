using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace The_Possible_of_Creation
{
    public class Program
    {
        public void Main()
        {
            int Loop2 = 3;
            for(int O = 1; O < Loop2; O++)
            {
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
                O = O - 1;
            }



            Console.ReadLine();

            }

    }
    }

