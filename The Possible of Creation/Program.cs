using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Possible_of_Creation
{
    class Program
    {
        static void Main(string[] args)
        {

            void LoJJa(ConsoleKeyInfo Tecla)
            {
                ConsoleKeyInfo IntButton;
                bool activated = false;
                // aperta um botão para abrir a loja                
                Tecla = Console.ReadKey(true);
                int dinero = 2300;
                if (Tecla.Key == ConsoleKey.E)
                {
                    Console.WriteLine("Loja abilitada");

                    Console.WriteLine("Comprar produtos C and V para vende");

                    // Comprar Produtos
                    
                    switch (IntButton = Console.ReadKey(true))
                    {
                        case ConsoleKey.D1:




                    }


                }
                if (Tecla.Key == ConsoleKey.V)
                {

                }
            }
        }
    }
}