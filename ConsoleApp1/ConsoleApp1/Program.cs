using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program is developed in C# to provide future prediction based on the zodiac sign.

            //Caling Variables
            string input;

            //Program
            Write("Enter your zodiac sign: ");
            input = ReadLine();

            while(input != "Q")
            {
                switch (input)
                {
                    case "aries":
                        WriteLine("You are enthusiastic, full of energy, and always ready to try something new.");
                        break;
                    case "leo":
                        WriteLine("You are most likely generous and willing to give of your time " +
                            "and money, especially if it makes you look good in the eyes of others.");
                        break;
                    case "gemini":
                        WriteLine("You usually think and act swiftly, and are always on your toes.");
                        break;
                    case "sagittarius":
                        WriteLine("You are spontaneous, outgoing, adventurous, and adaptable to any " +
                            "circumstance.");
                        break;
                    case "aquarius":
                        WriteLine("Aquarius is the sign of brotherhood and freedom, and honesty and " +
                            "sincerity are important to those born under it.");
                        break;
                    case "scorpio":
                        WriteLine("You like to be in control and can be very serious a lot of the time.");
                        break;
                    case "cancer":
                        WriteLine("You are most likely doggedly determined when it comes to getting " +
                            "what you want if it will promote your sense of safety.");
                        break;
                    case "libra":
                        WriteLine("Life is a continual balancing act for Librans.");
                        break;
                    case "taurus":
                        WriteLine("You are very sensible when it comes to your job and money, " +
                            "but your overriding motivation in all things is a need for security.");
                        break;
                    case "capricorn":
                        WriteLine("People see you as patient, realistic and responsible, but they " +
                            "worry that you take life far too seriously sometimes.");
                        break;
                    case "pisces":
                        WriteLine("Your peers are likely to see you as shy, idealistic, dreamy, " +
                            "and kind, but at the same time impractical, irresponsible and sometimes " +
                            "self-destructive.");
                        break;
                    case "virgo":
                        WriteLine("You are most likely bright, intelligent, and pick up on everything " +
                            "going on around you.");
                        break;
                    default:
                        WriteLine("Unknown zodiac sign.");
                        break;
                }
                Write("Enter your zodiac sign to continue or 'Q' to quit: ");
                input = ReadLine();
            }

            //End
            WriteLine("Thank you using my program!");
        }
    }
}
