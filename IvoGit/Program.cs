using System;
using System.Linq;

namespace IvoGit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayofNumbers = new int[5];
            arrayofNumbers[0] = 13;
            arrayofNumbers[1] = 22;
            arrayofNumbers[2] = 3;
            arrayofNumbers[3] = 93;
            arrayofNumbers[4] = 1;

            Console.WriteLine("Check if you picked a lucky number");
            string nr = Console.ReadLine();
            int myNr = Convert.ToInt32(nr);

            /*
            for(int i = 0; i < arrayofNumbers.Length; i++)
            {
                if(myNr == arrayofNumbers[i])
                {
                    Console.WriteLine("Winner winner chicken dinner");
                } else
                {
                    Console.WriteLine("Not this time");
                }
            }
            */
            

            Console.WriteLine(arrayofNumbers.Contains(myNr));

        }
    }
}
