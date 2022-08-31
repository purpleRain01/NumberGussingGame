using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("This is a Number guessing game you can guess any number between your choice");
            Console.WriteLine("Do you like to play(Y/N)");
            string play;
            play = Console.ReadLine();
            if(play.ToUpper()=="Y")
            {
                game_start();
            }
            else if(play.ToUpper()=="N")
            {
                Console.WriteLine("press any key and enter to exit");
                Console.ReadLine(); 
            }
            else
            {
                Console.WriteLine("wrong input try again");
                Console.WriteLine("enter any key to exit");
            }
            
        }
        public static void game_start()
        {
            bool choice;
            int max, min,number,user_input=-1;
            Random random = new Random();
            try
            {
                do
                {
                    Console.WriteLine("Enter the minimum number");
                    min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the maximum number");
                    max = Convert.ToInt32(Console.ReadLine());
                    number = random.Next(min, max + 1);
                    while (number != user_input)
                    {
                        Console.WriteLine($"guess a number between {min} and {max}");
                        user_input = Convert.ToInt32(Console.ReadLine());
                        if (number > user_input)
                        {
                            Console.WriteLine($"{user_input} is too low");
                        }
                        else if (number < user_input)
                        {
                            Console.WriteLine($"{user_input} is too high");
                        }
                    }
                    Console.WriteLine("******______YOU WIN______******");
                    Console.WriteLine("******______YOU WIN______******");
                    Console.WriteLine("******______YOU WIN______******");
                    Console.WriteLine("Would you like to play again(Y/N)");
                    string play = Console.ReadLine();
                    play = play.ToUpper();
                    if (play == "Y")
                        choice = true;
                    else
                        choice = false;
                } while (choice == true);
            }  
            catch(FormatException e)
            {
                Console.WriteLine("you entered a wrong input try again");
                Console.WriteLine("enter any key to exit");
                Console.ReadLine();
            }
        }
    }
}
