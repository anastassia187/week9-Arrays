using System;

namespace MatterOfTaste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite color:");
            string userColor = Console.ReadLine();

            string[] colors = { "red", "green", "blue" };


            for (int i = 1; i < colors.Length; i--)
            {
                if (userColor == "red")
                {
                    Console.WriteLine("We are perfect together!");

                    break;

                }
                if (userColor == "green")
                {
                    Console.WriteLine("We are perfect together!");
                    break;
                }
                if (userColor == "blue")
                {
                    Console.WriteLine("We are perfect together!");
                    break;
                }


                else
                {
                    Console.WriteLine("Every man to his taste.");
                }

                break;


                    




                }
            }

        }
    }

    

