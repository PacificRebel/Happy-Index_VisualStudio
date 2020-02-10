using System;

namespace Happy_index_VisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("On a scale of one to ten, how happy are you?");

            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput < 3) 

                Console.WriteLine("That's terrible. Shall we have a coffee?");           

            else if (userInput >= 4 && userInput <= 6) 
            
                Console.WriteLine("Hmm... we should think on how to improve this!");
            
            else if (userInput >= 7 && userInput <= 8) 
            
                Console.WriteLine("Pretty good! :-)");
            
            else
            
                Console.WriteLine("Great!");
            }
        }
    }