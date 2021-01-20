using System;

namespace RandomFight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random number generator, Randomizes damage
            Random generator = new Random();

            //datatypes are decleared here
            int player = 100;
            int fighter = 100;
            int skillpoints = 20;
            int dodge = 5;
            int strength = 5;
            int assign = 0;

            string charname = "";
            string answer = "";

            //Initial information about what the user should do
            void Starttext() {

                System.Console.WriteLine("Welcome to this text based fighting game!\nFirst you will need to create a character.");
            }
            //Character creation method
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
            }   

            //Stat assignement method
            void Statassignment() {

                //While-loop that runs as long as the user has points available
                while(skillpoints != 0)
                {
                   System.Console.WriteLine("You will now need to assign your " + skillpoints + " skillpoints!\nWrite either DODGE or STRENGTH in the console to assign your points:");

                    //While-loop checking if the user has typed "strength" or "dodge"
                       while(answer != "dodge" && answer != "strength")
                       {
                            answer = Console.ReadLine();
                            answer = answer.ToLower();

                            if (answer != "dodge" && answer != "strength")
                            {
                                System.Console.WriteLine("Please type DODGE or STRENGTH to assign your points");
                            }
                       }
                        
                        //If-statements checking if the user choose either dodge or strength
                           if(answer == "dodge")
                           {
                               System.Console.WriteLine("You currently have " + dodge + " dodge points. How many do you want to add?\n(You can add a maximum of " + skillpoints + " points, add atleast 1 point)");

                               while(assign <= 0 || assign > skillpoints)
                               { 
                                int.TryParse(Console.ReadLine(), out assign);

                                    if (assign <= 0)
                                    {
                                        System.Console.WriteLine("Please add atleast 1 point");
                                    }
                                    if (assign > skillpoints)
                                    {
                                        System.Console.WriteLine("You can't add more points than you have >:(");
                                    }
                                }

                                skillpoints = skillpoints - assign;
                                dodge = dodge + assign;

                                System.Console.WriteLine(assign + " points added to dodge. You now have " + dodge + " dodge.");

                                assign = 0;

                                answer = "";

                                
                           }
                           if (answer == "strength")
                           {
                               System.Console.WriteLine("You currently have " + strength + " strength points. How many do you want to add?\n(You can add a maximum of " + skillpoints + " points, add atleast 1 point)");
                                
                                while(assign <= 0 || assign > skillpoints)
                               { 
                                int.TryParse(Console.ReadLine(), out assign);

                                    if (assign <= 0)
                                    {
                                        System.Console.WriteLine("Please add atleast 1 point");
                                    }
                                    if (assign > skillpoints)
                                    {
                                        System.Console.WriteLine("You can't add more points than you have >:(");
                                    }
                                }
                                
                                skillpoints = skillpoints - assign;
                                strength = strength + assign;

                                System.Console.WriteLine(assign + " points added to strength. You now have " + strength + " strength.");

                                assign = 0;

                                answer = "";
                       }
                } 
            //Text telling the user that all points are assigned
            System.Console.WriteLine("All points are assigned!\nYour character now has " + dodge + " dodge and " + strength + " strength!\nPress ENTER to proceed");

            Console.ReadLine();
            
            }

            

            //While-loop that runs as long as both fighters have HP left
            void Fightsequence() {

            while (player >= 0 && fighter >= 0)
             {
                 int damage1 = generator.Next(1, 21);
                 int damage2 = generator.Next(1, 21);
 
                 player -= damage2;
                 fighter -= damage1;
 
                 System.Console.WriteLine(charname +" Attacks Enemy for " + damage1 + " Damage! Enemy HP is now: " + fighter);
                 System.Console.WriteLine("Enemy Attacks " + charname + " for " + damage2 + " Damage! " + charname + " HP is now: " + player);
 
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
                 System.Console.WriteLine(charname + " Lost! Enemy Is The Winner!");
             }

             else if (fighter <= 0)
             {
                 System.Console.WriteLine("Enemy Lost! " + charname + " Is The Winner!");
             }

            }

            //Writeline that tells the user to exit
            void Endtext() {

                System.Console.WriteLine("Would you like to fight again?");
                System.Console.WriteLine("Press ENTER To Exit");

                Console.ReadLine();

            }

            //Methods placed in corresponding order
            Starttext();

            Charcreator();
            Statassignment();

            Fightsequence();
            Fightoutcome();

            Endtext();
        }
    }
}
