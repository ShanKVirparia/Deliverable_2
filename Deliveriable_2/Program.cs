using System;

namespace Deliverible_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Shan's All You Can Eat! \n It will $9.99 for the buffet and $2 for Coke and water is free. \n We only accept parties of 6 or less. \n How people are in your party?");
            var partySize = Convert.ToInt32(Console.ReadLine());

            //Determines if the party is greater than 6 people

            if (partySize <= 6)
            {
                int coke = 0;
                int water = 0;
                
                //Loop through party and get drink orders
                for(int i = 0; i < partySize; i++)
                {
                    //Ask for a drink order
                    Console.WriteLine("Can I get you anything to drink, customer {0}? \n Coke or Water", i);
                    var drinkChoice = Convert.ToString(Console.ReadLine());

                    if (drinkChoice == "Coke")
                    {
                        Console.WriteLine("Coke is a good choice.\n");
                        coke++;
                    }
                    else if (drinkChoice == "Water")
                    {
                        Console.WriteLine("Okay, Water.\n");
                        water++;
                    }
                    else if (drinkChoice != "Water" || drinkChoice != "Coke")
                    {
                        Console.WriteLine("We don't serve that.\n");
                    }
                }
                
                //How many waters and coke have been ordered.
                Console.WriteLine("\nYou ordered {0} Cokes and {1} waters. \nFeel free to grab your food, while I grab your drinks.",coke,water);

                //Total bill. Water is free and Coke is $2
                double totalBill = (partySize * 9.99) + (coke * 2);
                Console.WriteLine("\nHere is your bill. $" + totalBill);
                
            }

            //Party larger than 6
            if (partySize >= 7)
            {
                Console.WriteLine("Your party is to large. Have a nice day!");
                Environment.Exit(0);
            }

        }
    }
}
