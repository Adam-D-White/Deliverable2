using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliverable_two
{
    class deliverable_two
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hey there! You look like you are ready for a great weekend.\n" +
                " How would you like to spend your weekend?\n" +
                "A: Action\n" +
                "B: Chilling\n" +
                "C: Danger\n" +
                "D: Good Food\n" +
                "E: Netflix binge topped with chocolate ice cream\n" +
                " ");



            string userInput1 = Console.ReadLine().ToUpper();

            switch (userInput1)
            {
                case "A":
                    Console.WriteLine(" You should go stock car racing. It's quite a thrill.");
                    break;

                case "B":
                    Console.WriteLine(" You might enjoy hiking. It's very relaxing.\n" +
                        " ");
                    break;

                case "C":
                    Console.WriteLine(" You should try skydiving. There's nothing quite like falling\n" +
                    " out of a perfectly good airplane.\n" +
                    " ");
                    break;

                case "D":
                    Console.WriteLine(" You seem like a Taco Bell kinda person to me.\n" +
                        " ");
                    break;

                case "E":
                    Console.WriteLine(" Don't worry, this is a judgement free zone.\n" +
                        " ");
                    break;

                default:
                    Console.WriteLine(" Let's get with the program. That wasn't one of the choices.\n" +
                        " ");
                    break;

            }
            {
                Console.ReadLine();
            }

            Console.WriteLine(" So, how many people are you planning to bring with you on these adventures?\n" +
                "A: 0\n" +
                "B: 1-4\n" +
                "C: 5-10\n" +
                "D: 11+\n" +
                " ");

            string userInput2 = Console.ReadLine().ToUpper();

            switch (userInput2)
            {
                case "A":
                    Console.WriteLine(" You can get away with just sneakers. Sometimes it's nice to be alone.\n" +
                        " ");
                    break;

                case "B":
                    Console.WriteLine(" A sedan is comfy for this kind of trip.\n" +
                        " ");
                    break;

                case "C":
                    Console.WriteLine(" A Volkswagon bus is the order of the day.\n" +
                        " ");
                    break;

                case "D":
                    Console.WriteLine(" WOW, you're popular! You are gonna need a plane to haul all of those people.\n" +
                        " ");
                    break;

                default:
                    Console.WriteLine(" As we discussed earlier, this is not a choice. Try again when you can follow directions.\n" +
                        " ");
                    break;
            }

            Console.ReadLine();

            Console.Write(" It was so awesome to help you with your weekend plans, and I hope you have lots of fun...\n" +
                " and survive if you are crazy enough to actually choose the Danger option. Happy trails!");

            Console.ReadLine();

        }
    }
}
