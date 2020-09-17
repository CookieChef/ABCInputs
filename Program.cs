using System;

namespace ABCInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Well hello there...");
            
            var isRunning = true;

            while(isRunning) {
            Console.WriteLine("Please type: A,B or C");
            Console.WriteLine("Type 'Q' if you would like to quit");

            var letter = Console.ReadLine();

            if (letter == "a" || letter == "b" || letter == "c" || letter == "A" || letter == "B" || letter == "C"){
                Console.WriteLine("Good job!");
            }else if (letter == "q" || letter == "Q") {
                isRunning = false;
            }
            }
        }
    }
}
