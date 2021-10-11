using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace The_Possible_of_Creation
{
    public class GraficPixel3D
    {
        public void Grafic3D()
        {
            ConsoleColor ColorVH = ConsoleColor.White;

            int Loop4 = 6; 
            for (int u = 1; u < Loop4; u++)
            {
                Console.WriteLine(ColorVH);
                Console.Write(ColorVH);
            }
        }
    }
}
