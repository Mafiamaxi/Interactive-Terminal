using System.ComponentModel.Design;
using System.Transactions;

namespace Yeilding_Jack_ProcessWork1
{
    internal class Program
    {
        private static string firstname;
        private static string lastname;

        static void Main(string[] args)
        {

            String name = "Jack";
            int age = 21;
            int playerID = 1;
            int playerhealth = 100;
            int score = 550;

            playerhealth = 100;
            score = 935;
            name = "Player 1";

            int highscore = 1000;

            bool isPlayerOne = playerID == 1;

            Console.WriteLine("Welcome to a Roleplaying Game where choices determine your fate!");
            Console.WriteLine("Each player starts out with 200 points ");
            Console.WriteLine("What is your full name, PLayer One?");
            String fullname = $"{firstname}  {lastname}";
            string playername = Console.ReadLine();
            Console.WriteLine($"{name}just came back from an adventure and you are stuck with a fork in the road");
            Console.WriteLine("you go left, you will end up at a goblin village where you have to do trade with them");
            Console.WriteLine("If you go right, you will end up in the Misty Mountains where there is reduced visibility");

            String playerinput = Console.ReadLine();

            if (playerinput == "left")
            {
                Console.WriteLine("you went left and gained experience from diplomacy.");
                Console.WriteLine("You went to sleep at an inn");
                Console.WriteLine("You slept 8 hours into morning");
                Console.ReadLine();
            }

            else if (playerinput == "500 gold")
            {

                Console.WriteLine("Enter your desired gold amount."); 
                
                int currentGold = int.Parse(Console.ReadLine());    
            }

            else if (playerinput == "Purchase")
            {
                Console.WriteLine($"{name}You purchased a broadsword.You now have gold.");
            }
            else if (playerinput == "have insufficient gold.")
            {
                Console.WriteLine($"{name}you have insufficient money to buy this weapon or shield.");
                String input = Console.ReadLine();

            if (playerinput == "right")
                {
                    Console.WriteLine("You go right, up to the mountains where the wind builds up reducing visibility.");
                    Console.WriteLine("You see 2 items on the ground, goggles and a warm suit or a alien weather manipulation device to get rid of the wind.");
                }
            else if (playerinput == "Goggles and warm suit")
                {
                    Console.WriteLine("You picked up the warm suit and goggles letting you see through the wind.");
                }
            else if (playerinput == "weather manipulation device")
                {
                    Console.WriteLine("You picked up the alien weather manipulation device");
                    Console.WriteLine("It allows you to get rid of the storm but reveals predators");
                    Console.WriteLine("They pounce on you and you die");
                }
            }
        }
    }
}