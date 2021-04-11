using System;

namespace SO_Lab3_4._12._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            bool askAgain = true;

            while (askAgain)
            {
                
                Console.WriteLine("Please enter an integer between 1 and 100.");
                String userInput = Console.ReadLine();
                
                int userNumber = int.Parse(userInput);

                //Add validation to guarantee that a user enters a positive integer between 1 and 100.

                if (userNumber < 1 || userNumber > 100)
                {
                    Console.WriteLine(userName + ", that is a not a positive integer between 1 and 100. Please try again.");
                }
                else
                {
                    //Use if/else statements to make different actions depending on user input

                    //If the integer is odd, print the number entered and “Odd.”

                    if (userNumber % 2 != 0)
                    {
                        Console.WriteLine(userName + ", your number is " + userNumber + ". Odd.");
                    }

                    //If the integer entered is odd and greater than 60, print the number entered and “Odd.”


                    if (userNumber % 2 != 0 && userNumber > 60)
                    {
                        Console.WriteLine(userName + ", your number is " + userNumber + ". Odd.");
                    }

                    //If the integer entered is even and in the inclusive range of 2 to 25, print “Even and less than 25.”

                    if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 25)
                    {
                        Console.WriteLine("Even and less than 25");
                    }

                    //If the integer entered is even and in the inclusive range of 26 to 60, print “Even.”

                    if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
                    {
                        Console.WriteLine("Even");
                    }

                    //If the integer entered is even and greater than 60, print the number entered and “Even”.

                    if (userNumber % 2 == 0 && userNumber > 60)
                    {
                        Console.WriteLine("Your number is " + userNumber + ". Even");
                    }

                    Console.WriteLine("Do you want to continue? (y/n)");
                    string userContinue = Console.ReadLine();

                    if (userContinue == "y")
                    {
                        askAgain = true;
                    }

                    else
                    {
                        Console.WriteLine("Bye!");
                        askAgain = false;
                    }

                }
            }
        }
    }
}
