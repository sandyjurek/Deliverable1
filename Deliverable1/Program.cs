using System;
using System.Net.Http;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous?");
            string vacationType = Console.ReadLine();

            Console.WriteLine("How many are in your group? Make sure you enter a whole number: ");
            int groupSize = Convert.ToInt32(Console.ReadLine());

            string travelSuggestion = "";
            string destination = "";

            switch (vacationType)
            {
                case "musical":

                    if (groupSize > 0 && groupSize < 3)
                    {
                        travelSuggestion = "first class";
                        destination = "New Orleans";
                    }

                    else if (groupSize > 2 && groupSize < 6) 
                    {
                        travelSuggestion = "helicopter";
                        destination = "New Orleans";
                    }
                    else if (groupSize >=6)
                    {
                        travelSuggestion = "charter flight";
                        destination = "New Orleans";
                    }

                    break;

                case "tropical":

                    if (groupSize > 0 && groupSize < 3)
                    {
                        travelSuggestion = "first class";
                        destination = "Beach vacation in Mexico";
                    }
                    else if (groupSize > 2 && groupSize <=5)
                    {
                        travelSuggestion = "helicopter";
                        destination = "Beach vacation in Mexico";
                    }
                    else if (groupSize >=6)
                    {
                        travelSuggestion = "charter flight";
                        destination = "Beach vacation in Mexico";
                    }

                    break;

                case "adventurous":

                    if (groupSize > 0 && groupSize < 3)
                    {
                        travelSuggestion = "first class";
                        destination = "Whitewater rafting in Grand Canyon";
                    }
                    else if (groupSize > 2 && groupSize <= 5)
                    {
                        travelSuggestion = "helicopter";
                        destination = "Whitewater rafting in Grand Canyon";
                    }
                    else if (groupSize >= 6)
                    {
                        travelSuggestion = "charter flight";
                        destination = "Whitewater rafting in the Grand Canyon";
                    }

                    break;
            }
            {
                Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + travelSuggestion + " to " + destination + ". Have a great time!");

                Console.ReadLine();
            }
        }
    }
}
