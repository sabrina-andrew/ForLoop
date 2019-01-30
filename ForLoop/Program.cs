using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pick a number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            
            for (int i = userInput; i <= 100; i++ )
            {
                
                Console.WriteLine(i);
                
            } 
             Console.ReadKey();
        }
    }
}
