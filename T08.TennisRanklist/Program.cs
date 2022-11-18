using System;

namespace T08.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTournaments = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());
            string stageReached = Console.ReadLine();
            
            for (int i = 1; i < numberTournaments; i++)
            {
                if (stageReached == "F")
                {
                    stageReached = (initialPoints + 1200);
                }
                else if (stageReached == "SF")
                {

                }
            }
            
        }
    }
}
