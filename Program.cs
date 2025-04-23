using System;
using System.Media;
using System.Threading;

namespace CyberAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            PlayGreetingAudio();

            ShowAsciiArt();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════╗");
            Console.WriteLine("║      Welcome to the Cybersecurity Awareness Bot    ║");
            Console.WriteLine("╚════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.Write("\nPlease enter your name: ");
            string userName = Console.ReadLine()?.Trim();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Name cannot be empty. Please enter your name: ");
                Console.ResetColor();
                userName = Console.ReadLine()?.Trim();
            }

            ChatUser currentUser = new ChatUser { Name = userName };

            PrintWithDelay($"\nHi {currentUser.Name}, how can I assist you today?");
            PrintOptions();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                // Getting user input for the selected option
                string input = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: I didn't quite understand that. Could you rephrase?");
                    continue;
                }

                // Try to parse the input as a number
                bool isNumber = int.TryParse(input, out int option);

                // If input is a number, process the option
                if (isNumber)
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Bot: I'm functioning securely, thanks for asking!");
                            break;
                        case 2:
                            Console.WriteLine("Bot: I help users learn how to stay safe online.");
                            break;
                        case 3:
                            Console.WriteLine("Bot: You can ask me about password safety, phishing, or safe browsing.");
                            break;
                        case 4:
                            Console.WriteLine("Bot: Use strong, unique passwords for each site. Avoid using your name or birthdate.");
                            break;
                        case 5:
                            Console.WriteLine("Bot: Phishing is a scam where attackers trick you into sharing sensitive info. Never click suspicious links.");
                            break;
                        case 6:
                            Console.WriteLine("Bot: Use HTTPS websites, avoid downloading files from unknown sources, and update your browser regularly.");
                            break;
                        case 7:
                            Console.WriteLine("Bot: Stay safe online, goodbye!");
                            return; // Exit the bot
                        default:
                            Console.WriteLine("Bot: I didn't quite understand that. Please select a valid option.");
                            break;
                    }
                }
                else
                {
                    // If input is not a number, inform the user
                    Console.WriteLine("Bot: Please enter a valid number option.");
                }

                PrintOptions(); // Show the options again after each response
            }
        }

        static void PlayGreetingAudio()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("Assets/welcome.wav");
                player.PlaySync();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error playing audio: " + e.Message);
            }
        }

        static void ShowAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
   ____      _            ____        _   
  / ___|__ _| | ___ _   _| __ )  ___ | |_ 
 | |   / _` | |/ __| | | |  _ \ / _ \| __|
 | |__| (_| | | (__| |_| | |_) | (_) | |_ 
  \____\__,_|_|\___|\__, |____/ \___/ \__|
                    |___/                
");
            Console.ResetColor();
        }

        static void PrintWithDelay(string message, int delay = 30)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        static void PrintOptions()
        {
            Console.WriteLine("\nSelect an option by typing the corresponding number:");
            Console.WriteLine("1 - How are you?");
            Console.WriteLine("2 - What's your purpose?");
            Console.WriteLine("3 - What can I ask you about?");
            Console.WriteLine("4 - Password safety");
            Console.WriteLine("5 - Phishing");
            Console.WriteLine("6 - Safe browsing");
            Console.WriteLine("7 - Exit");
        }

    }

    
}
