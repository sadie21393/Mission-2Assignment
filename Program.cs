using Mission_2Assignment;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        //Write the introduction script for the game
        Console.WriteLine("Welcome to the dice throwing simulator! ");
        Console.WriteLine("How many dice rolls would you like to simulate? (ex: 1-1000)");

        // Get the number of Rolls from user 
        int rolls = int.Parse(Console.ReadLine());

        //pass rolls to second class
        List <int> printlist = Class2.ThrowDice(rolls);

        //Print the results and explanation of results
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS ");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + Convert.ToString(rolls) + ".");

        //Define the number of rows the histogram will have 1-12
        List <int> histlist = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        float per = 0;
        int sum = 0;

        // do this for each possible result 2-12
        foreach (int i in histlist)
        {
            sum = 0;
            // do this for each dice result in the list
            foreach (int item in printlist) 
            {
                //counting to see how many of each result there was of each number 2-12
                if (i == item)
                {
                    sum++; // add to a sum 
                }
            }
            // calculate the total percentage
            per = ((float)sum / rolls) * 100;

            List <string> liststr = new List<string>();

            // for each value of 1 (out of a total of 100 for all groups) therefore counting 1%, add an * to the list 
            for (int j = 0; j < per; j++)
            {
                liststr.Add("*");
            }

            // for the given number we are solving for (2-12) print the number and the number of * based on percentage 
            Console.WriteLine(Convert.ToString(i) + ": " + string.Join("",liststr));
        }

        Console.WriteLine("Thank you for using the dice throwing simulator.  Goodbye!");
    }
}