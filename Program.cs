using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //console proproties
            object value = Console.Title = "Text Game";

            //call back the method test
            Program myProgram = new Program();

            //story start
            Console.WriteLine("Welcome to the game\nWould you like to start ?");

            var x = Console.ReadLine();

            if (x == "yes")
            {
                Console.WriteLine("Good\nLet's get started :D");

                myProgram.CharacterCreation();
            }


            else if (x == "y")
            {
                Console.WriteLine("Good\nLet's get started :D");

                myProgram.CharacterCreation();
            }

            else if (x == "Yes")
            {
                Console.WriteLine("Good\nLet's get started :D");

                myProgram.CharacterCreation();
            }

            else if (x == "No")
            {
                Console.WriteLine("Good bye");

                Console.ReadLine();
            }

            else if (x == "no")
            {
                Console.WriteLine("Good bye");

                Console.ReadLine();
            }




        }

        void CharacterCreation()
        {
            Console.WriteLine("What is the name of your vessel ?\n(Capitalize the first letter of your name...)");

            var name = Console.ReadLine();

            if (name == "Kurtis")
            {
                Console.WriteLine("Nice\nThat is a great name.");

                Console.WriteLine("Let us give your vessel a gift...\nPower\nMagic\nWisdom\n(Capitalize the start of the word)");

                Console.ReadLine();

                Program myProgram1 = new Program();

                myProgram1.StoryStart();
            } 
            else
            {
                Console.WriteLine("That is a good name");

                Console.WriteLine("Let us give your vessel a gift...\nPower\nMagic\nWisdom\n(Capitalize the start of the word)");

                Console.ReadLine();

                Program myProgram1 = new Program();
                myProgram1.StoryStart();
            }
        }

        void StoryStart()
        {
            Console.WriteLine("You have made some great choises...");

            Console.ReadLine();

            Console.WriteLine("But");
            Console.ReadLine();
            Console.WriteLine(".");
            Console.ReadLine();
            Console.WriteLine(".");
            Console.ReadLine();
            Console.WriteLine(".");
            Console.ReadLine();
            Console.WriteLine("Your answers will now be...");
            Console.ReadLine();
            Console.WriteLine("Discarded...");
            Console.ReadLine();
            Console.WriteLine("No one can choise who they are in this world...");
            Console.ReadLine();
            Console.WriteLine("Welcome to the game...");
            Console.ReadLine();

            Program myProgram2 = new Program();
            myProgram2.AnewBegining();
        }

        //the actual start of the story lol

        void AnewBegining()
        {
            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine("You wake up in a comfy bed\nyou slowly get up leaving the warth of the bed behind.");

            Console.WriteLine("(Commands)\nwalk\nlook\ninteract");

            var answer = Console.ReadLine();

           switch (answer)
            {
                case "walk":
                    {
                        Console.WriteLine("you walk to the door");
                        Console.ReadLine();
                        break;
                    }

                case "look":
                    {
                        Console.WriteLine();
                        Console.ReadLine();
                        break;
                    }

                case "interact":
                    {
                        Console.WriteLine("you fix your  bed");
                        Console.ReadLine();
                        break;
                    }
            }
        }

        void walkpartone()
        {
            Console.WriteLine("(Commands)\nwalk\nlook\ninteract");

            var answer = Console.ReadLine();

            switch (answer)
            {
                case "walk":
                    {
                        Console.WriteLine("you can not walk now");
                        Console.ReadLine();
                        break;
                    }

                case "look":
                    {
                        Console.WriteLine("you look around the room but find nothing of importance");
                        Console.ReadLine();

                        Console.WriteLine("(Commands)\nwalk\nlook\ninteract");

                        var answer2 = Console.ReadLine();

                        switch (answer2)
                        {
                            case "walk":
                                {
                                    Console.WriteLine("you walk to the door");
                                    Console.ReadLine();
                                    break;
                                }

                            case "look":
                                {
                                    Console.WriteLine("You have already looked around");
                                    Console.ReadLine();
                                    break;                                

                                 }

                            case "interact":
                                {
                                    Console.WriteLine("you make the bed");
                                    Console.ReadLine();
                                    break;

                                }
                        }

                        break;
                    }

                case "interact":
                    {
                        Console.WriteLine("you make the bed");
                        Console.ReadLine();
                        break;
                    }
            }
        }
    }
}