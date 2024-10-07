using System;
using System.ComponentModel.Design;

namespace ConsoleApp4
{
    internal class Program
    {

        static bool isPlaying = true; // Variable para mantener el juego en ejecución


        static void Main(string[] args)
        {
            



            int menu = int.Parse(Console.ReadLine());

            do {

                Console.WriteLine("lorem ipsum");

                Console.WriteLine("1- Lorem");
                Console.WriteLine("2- Lorem");


                switch(menu)
                {
                    case 1: nuevaPartida();
                        break;
                    case 2: Exit();
                        break;
                    default: Console.WriteLine("Oleme el dedo");
                        break;
                }
                

            } while ();
            
            
            
            
            














        }

        
    }
}
