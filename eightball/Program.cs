using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Eight_ball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Magic Eight Ball: Ask a question...");
            Console.ReadLine();

            Random random = new Random();
            int randomNumber = random.Next(1, 9);

            string awnser = "";

            switch (randomNumber)
            {
                case 1:
                    awnser = "It is certain.";
                    break;
                case 2:
                    awnser = "reply hazy, try again.";
                    break;
                case 3:
                    awnser = "Don't count on it.";
                    break;
                case 4:
                    awnser = "Yes, definitely.";
                    break;
                case 5:
                    awnser = "You may rely on it.";
                    break;
                case 6:
                    awnser = "As I see it, yes.";
                    break;
                case 7:
                    awnser = "Most likely.";
                    break;
                case 8:
                    awnser = "Outlook not so good";
                    break;

            }

            Console.WriteLine($"Magic Eight Ball says: {awnser}");

            bool keepPlaying = true;

            while (keepPlaying)
            {
                Console.WriteLine("\nMagic Eight Ball: Ask a question (or type 'exit')");
                string question = Console.ReadLine();

                if (question.ToLower() == "exit")
                {
                    keepPlaying = false;
                    break;

                }

                randomNumber = random.Next(1, 9);
                Console.WriteLine($"Mogic Eight Ball says: {awnser}");
            }
        }
    }
}