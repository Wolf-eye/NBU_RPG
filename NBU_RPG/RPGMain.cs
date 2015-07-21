using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBU_RPG
{
    class RPGMain : GameEngine
    {

        public static int Main()
        {
            //intro

            Console.Write(GameEngine.StoryLine("Hello stranger. You enter the dangerous world of NBU Text RPG.\nHope you are ready for chalenges, becouse The GAME begins!\n"));

            //player information

            Console.Write("Enter your name: ");
            string playerName = new string(new char[20]);
            playerName = Console.ReadLine();

            Console.Write("Enter your gender <male,female>: ");
            string gender = Console.ReadLine();

            while (gender != "female" && gender != "male")
            {
                GameEngine.Incorrect();
                gender = Console.ReadLine();
            }

            if (gender == "male")
            {
                gender = "You looks like a Strong Man";
            }
            else if (gender == "female")
            {
                gender = "Oh you are so sweet lady!";
            }

            Console.Write("Enter your age: ");
            int playerAge = int.Parse(Console.ReadLine());
            if (playerAge < 18)
            {
                Console.Write("Get out of here stalker, you ugly ass MadaFaka. 18+");
                Console.ReadLine();
                Console.Read();
                return 0;
            }
            else if (playerAge >= 100)
            {
                Console.Write("WTF maan? You're too old, you shouldn't be playing this.");
                Console.ReadLine();
                Console.Read();
                return 0;
            }

            Console.Clear();

            Console.Write("Do you have a hot sister? Oh thats a joke, just a joke. Com'n let's begin...\n");
            //Print player info
            Console.Write("Your name is ");
            Console.Write(playerName);
            Console.Write("(");
            Console.Write(gender);
            Console.Write(")");
            Console.Write(", and you are ");
            Console.Write(playerAge);
            Console.Write(" years old.");
            Console.Write("\n");
            Console.Write("Press [Enter] to continue");
            Console.ReadLine();
            Console.Read();

            Console.Write("You're in your apartment.Its Saturday early morning and you are about to get up from your bed and going to C# exams, when you hear a man screaming ");
            Console.Write("\n");
            Console.Write("outside your window. ");
            Console.Write("You look out your window finding what looks to be an old ");
            Console.Write("\n");
            Console.Write("lady being attack by 2 others. ");
            Console.Write("\n");

            Console.Write("Do you: ");
            Console.Write("\n");
            Console.Write("[1]Go outside and help her");
            Console.Write("\n");
            Console.Write("[2]Go to bed");
            Console.Write("\n");
            Console.Write(":");
            string choice1 = Console.ReadLine();
            while (choice1 != "1" && choice1 != "2")
            {
                GameEngine.Incorrect();
                choice1 = Console.ReadLine();
            }

            if (choice1 == "1")
            {
                Console.Write("\n");
                Console.Write("You should probably take something with you. On your computer desk you see\n");
                Console.Write("a [F]lashlight, a [B]aseball bat, and a [H]unting knife.\n");
                Console.Write("Which one of these items do you want to take with you?\n");
                Console.Write(":");
                string slot1;
                slot1 = Console.ReadLine();
                while (slot1 != "F" && slot1 != "f" && slot1 != "B" && slot1 != "b" && slot1 != "H" && slot1 != "h")
                {
                    GameEngine.Incorrect();
                    slot1 = Console.ReadLine();
                    while (slot1 != "F" && slot1 != "f" && slot1 != "B" && slot1 != "b" && slot1 != "H" && slot1 != "h")
                    {
                        slot1 = Console.ReadLine();
                    }
                }
                if (slot1 == "f" || slot1 == "F")
                {
                    slot1 = "flashlight";
                }
                else if (slot1 == "b" || slot1 == "B")
                {
                    slot1 = "baseball bat";
                }
                else if (slot1 == "h" || slot1 == "H")
                {
                    slot1 = "hunting knife";
                }
                Console.Write("You've acquired a ");
                Console.Write(slot1);
                Console.Write("!\n");
                Console.Write("Press [Enter] to continue");

                Console.ReadLine();
                Console.Read();
                Console.Clear();

                Console.Write("You leave your apartment cautiously holding your ");
                Console.Write(slot1);
                Console.Write(" in your right\n");
                Console.Write("hand when you see a woman approaching you. ");
                Console.Write("The woman makes no attempt at\n");
                Console.Write("communicating with you and continues walking towards you.\n");
                Console.Write("You come to realize that this is no woman at all, but a zombie that wants to\n");
                Console.Write("eat your flesh!\n");
                Console.Write("Press [Enter] to fight");
                Console.ReadLine();
                Console.Read();



                string his_her = Console.ReadLine();


                while (playerHealth != 0 && zombieHealth != 0) // combat starts here
                {
                    if (slot1 == "flashlight")
                    {
                        itemDMG = 1;
                    }
                    else if (slot1 == "baseball bat")
                    {
                        itemDMG = 2;
                    }
                    else if (slot1 == "hunting knife")
                    {
                        itemDMG = 3;
                    }

                    if (gender == "m")
                    {
                        his_her = "his";
                    }
                    else if (gender == "f")
                    {
                        his_her = "her";
                    }

                    zombieAttackChance = randomNum(zombieAttackChance, 4);

                    if (zombieAttackChance == 4)
                    {
                        playerHealth = playerHealth - 3;
                        Console.Write("The zombie swings at ");
                        Console.Write(playerName);
                        Console.Write("\n");
                        Console.Write("The zombie successfully hits ");
                        Console.Write(playerName);
                        Console.Write(" for 3hp");
                        Console.Write("\n");
                        GameEngine.pHealthCheck();
                        Console.Write(playerName);
                        Console.Write(" has ");
                        Console.Write(playerHealth);
                        Console.Write("/15hp left");
                        Console.Write("\n");
                        if (playerHealth == 0)
                        {
                            Console.Clear();
                            Console.Write("You have died. Your journey ends here.");
                            Console.Write("\n");
                            Console.Write("Press [Enter] to quit");
                            Console.ReadLine();
                            Console.Read();
                            return 0;
                        }
                        Console.Write("Press [Enter] to attack");
                        Console.Write("\n");
                        Console.ReadLine();
                        Console.Read();
                    }
                    else
                    {
                        Console.Write("The zombie swings at ");
                        Console.Write(playerName);
                        Console.Write("\n");
                        Console.Write("The zombie failed to hit ");
                        Console.Write(playerName);
                        Console.Write("\n");
                        Console.Write(playerName);
                        Console.Write(" has ");
                        Console.Write(playerHealth);
                        Console.Write("/15hp left");
                        Console.Write("\n");
                        Console.Write("Press [Enter] to attack");
                        Console.Write("\n");
                        Console.ReadLine();
                        Console.Read();
                    }

                    playerAttackChance = randomNum(playerAttackChance, 2);

                    if (playerAttackChance == 2)
                    {
                        zombieHealth = zombieHealth - itemDMG;
                        Console.Write(playerName);
                        Console.Write(" lunges at the zombie with ");
                        Console.Write(his_her);
                        Console.Write(" ");
                        Console.Write(slot1);
                        Console.Write("\n");
                        Console.Write(playerName);
                        Console.Write(" successfully hit the zombie for ");
                        Console.Write(itemDMG);
                        Console.Write("hp");
                        Console.Write("\n");
                        GameEngine.zHealthCheck();
                        Console.Write("The zombie has ");
                        Console.Write(zombieHealth);
                        Console.Write("/6hp left");
                        Console.Write("\n");
                        if (zombieHealth != 0)
                        {
                            Console.Write("Press [Enter] to attempt to dodge");
                            Console.Write("\n");
                        }
                        else if (zombieHealth == 0)
                        {
                            Console.Write("Press [Enter] to continue");
                            Console.Write("\n");
                        }
                        Console.ReadLine();
                        Console.Read();
                    }
                    else
                    {
                        Console.Write(playerName);
                        Console.Write(" lunges at the zombie with ");
                        Console.Write(his_her);
                        Console.Write(" ");
                        Console.Write(slot1);
                        Console.Write("\n");
                        Console.Write(playerName);
                        Console.Write(" failed to hit the zombie");
                        Console.Write("\n");
                        Console.Write("The zombie has ");
                        Console.Write(zombieHealth);
                        Console.Write("/6hp left");
                        Console.Write("\n");
                        Console.Write("Press [Enter] to attempt to dodge");
                        Console.Write("\n");
                        Console.ReadLine();
                        Console.Read();
                    }
                } // End while, combat ends here

                if (zombieHealth == 0)
                {
                    Console.Clear();
                    Console.Write(playerName);
                    Console.Write("(");
                    Console.Write(playerHealth);
                    Console.Write("hp) has killed the zombie.");
                    Console.Write("\n");
                    Console.Write("Press [Enter] to continue");
                    Console.ReadLine();
                    Console.Read();
                }
                Console.Clear();
                Console.Write("Something horrible has happened. You take out your cellphone to call your\n");
                Console.Write("parents. Unforunately your phone has bad reception in the apartment complex\n");
                Console.Write("and the call won't go through.\n");
                Console.Write("As you sit there thinking of what to do next, you remember why you left your\n");
                Console.Write("apartment in the first place.\n");
                Console.Write("Do you:\n");
                Console.Write("[1]Help the lady outside\n");
                Console.Write("[2]Go back in your apartment\n");
                Console.Write(":");

            choice2:

                string choice2;
                choice2 = Console.ReadLine();

                if (choice2 == "1")
                {
                    Console.Clear();
                    Console.Write("You reach the spot where you last saw the old lade. She's sitting there, holding\n");
                    Console.Write("the side of her neck with her right hand, with 2 dead bodies near her.");
                    Console.Write(" As soon\n");
                    Console.Write("as she sees you, she points a pistol at your head. You raise up your hands and\n");
                    Console.Write("drop your ");
                    Console.Write(slot1);
                    Console.Write(".");
                    Console.Write("\n");
                    Console.Write("Press [Enter] to continue");
                    Console.Write("\n");
                    Console.ReadLine();
                    Console.Read();
                    Console.Write("She puts down the pistol and apologizes to you, she thought you were a zombie! SHe explains that she has no idea what's going on and that you should get out of\n");
                    Console.Write("town as soon as possible\n");
                    Console.Write("Press [Enter] to continue");
                    Console.Write("\n");
                    Console.ReadLine();
                    Console.Read();
                    Console.Write("Before the old woman can say anymore, you decide to take off and head to your\n");
                    Console.Write("car. Once in your car you decide to head to NBU to see if\n");
                    Console.Write("they're lections today and if anybody knows what happens.\n");
                    Console.Write("Press [Enter] to continue");
                    Console.ReadLine();
                    Console.Read();
                    Console.Clear();
                    Console.Write("You arrive in time for C# class, exactly in 8:00AM \n");
                    Console.Write("You have won!");
                    Console.Write("\n");
                    Console.Write("Press [Enter] to quit");
                    Console.ReadLine();
                    Console.Read();
                    return 0;

                }
                else if (choice2 == "2")
                {
                    //goto choice3;
                    Console.Clear();
                    Console.Write("You figure it's best you not get involved with what's going on out there. You\n");
                    Console.Write("get in your bed and slowly fall to sleep...\n");
                    Console.Write("Press [Enter] to continue");
                    Console.Write("\n");
                    Console.ReadLine();
                    Console.Read();
                    Console.Write("You wake up to an old woman staring at you. Before you have time to react she\n");
                    Console.Write("jumps on you and eats your face.\n");
                    Console.Write("Press [Enter] to continue");
                    Console.Write("\n");
                    Console.ReadLine();
                    Console.Read();
                    Console.Clear();
                    Console.Write("You have died. Your journey ends here and you miss C# exams :((( .\n");
                    Console.Write("Press [Enter] to quit");
                    Console.ReadLine();
                    Console.Read();
                    return 0;


                }          
                else
                {

                    GameEngine.Incorrect();
                    goto choice2;
                }
            }
            // End if choice1=1
           else if (choice1 == "2")
           {
               Console.Clear();
               Console.Write("You figure it's best you not get involved with what's going on out there. You\n");
               Console.Write("get in your bed and slowly fall to sleep...\n");
               Console.Write("Press [Enter] to continue");
               Console.Write("\n");
               Console.ReadLine();
               Console.Read();
               Console.Write("In less a minute you wake up to an old woman staring at you. Before you have time to react she\n");
               Console.Write("jumps on you and eats your face.\n");
               Console.Write("Press [Enter] to continue");
               Console.Write("\n");
               Console.ReadLine();
               Console.Read();
               Console.Clear();
       //        Console.ReadLine();
       //        Console.Read();
       //        return 0;
               //
               Console.Write("Do you:\n");
               Console.Write("[1]Huh, this is nightmare, continue sleeping, its so early to get up\n");
               Console.Write("[2]Get up and see what the hell is wrong\n");
               Console.Write(":");

               string choice3 = Console.ReadLine();;
              choice3 = Console.ReadLine();
               if (choice3 == "1")
               {
                   Console.Clear();
                   Console.Write("You are awake and nightmare was true.\n");
                   Console.Write("You have died. Your journey ends here and you miss C# exams :(((\n");
               }
               else if (choice3 == "2")
               {
                   Console.Write("You get up and see that your dog is licking your face. Good boy he dont let you miss C# exams. Y go to school and have won the game!...\n");
                   Console.ReadLine();
                   Console.Read();
                   return 0;
               }
           }

           // End if choice3

            Console.ReadLine();
            Console.Read();
            return 0;
        } // end main

    }

}

