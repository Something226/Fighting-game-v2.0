using System;

namespace RandomFight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random number generator, Randomizes damage
            Random damage = new Random();
            Random health = new Random();

            //datatypes are decleared here
            int player = 100;
            int playerdodge;
            int playerstrength;
            int fighter = 100;
            int skillpoints = 20;
            string charname = "";
            string answer = "";

            //Initial information about what the user should do
            System.Console.WriteLine("Welcome to this text based fighting game!\nFirst you will need to create a character.");

            void Charcreator() {
                System.Console.WriteLine("What will you name your character?:");        
               
                charname = Console.ReadLine();      
               
                System.Console.WriteLine(charname + "?\nY/N");      
                  while (answer != "y")
                  {
                    answer = Console.ReadLine();
                    answer = answer.ToLower();      
                   
                    if(answer != "y" && answer != "n"){
                        
                        System.Console.WriteLine("Please type Y or N to accept or change your name");
                    }
                    if(answer == "n"){
                        Charcreator();
                    }
                  }     
                System.Console.WriteLine("You will now need to assign your " + skillpoints + " skillpoints!\nWrite either dodge or strength in the console to assign your points:");
                while
            
            }

            //While-loop that runs as long as both fighters have HP left
            void Fightsequence() {
            while (player >= 0 && fighter >= 0)
             {
                 int damage1 = damage.Next(1, 21);
                 int damage2 = damage.Next(1, 21);
 
                 player -= damage2;
                 fighter -= damage1;
 
                 System.Console.WriteLine(charname +" Attacks Enemy for " + damage1 + " Damage! Enemy HP is now: " + fighter);
                 System.Console.WriteLine("Enemy Attacks " + charname + " for " + damage2 + " Damage! " + charname + "HP is now: " + player);
 
                 System.Console.WriteLine("Press ENTER To Continue");
                 Console.ReadLine();
 
             }

            }

            //If-statements that tells the user who won the fight
            void Fightoutcome() {

             if (player <= 0 && fighter <= 0)
             {
                 System.Console.WriteLine("It's A Draw!");
             }

             else if (player <= 0)
             {
                 System.Console.WriteLine("Fighter 1 Lost! Fighter 2 Is The Winner!");
             }

             else if (fighter <= 0)
             {
                 System.Console.WriteLine("Fighter 2 Lost! Fighter 1 Is The Winner!");
             }

            }

            //Writeline that tells the user to exit
            void Endtext() {
             System.Console.WriteLine("Would you like to fight again?");
             System.Console.WriteLine("Press ENTER To Exit");

             Console.ReadLine();

            }

            //Methods placed in corresponding order

            Charcreator();

            Fightsequence();
            Fightoutcome();

            Endtext();
        }
    }
}
