using System;

class Program
{
    static void Main()
    {
        static string getValidInput(string prompt)
        {
            Console.WriteLine(prompt);
            string? input = Console.ReadLine()?.ToLower();
            if (input != "yes" && input != "no")
            {
                Console.WriteLine("Wrong answer!");
                Environment.Exit(0);
            }
            return input;
        }
        string decision = "";

        decision += getValidInput("Is it raining today? (yes/no)") + "_";
        decision += getValidInput("Do you have an umbrella? (yes/no)") + "_";
        decision += getValidInput("Are you going to take your umbrella with you? (yes/no)") + "_";
        decision += getValidInput("Do you feel like going for a walk? (yes/no)") + "_";
        decision += getValidInput("Do you have a raincoat? (yes/no)") + "_";
        decision += getValidInput("Do you have specific plans to go out? (yes/no)") + "_";
        decision += getValidInput("Do you have a car? (yes/no)") + "_";
        decision += getValidInput("Is it windy? (yes/no)") + "_";
        decision += getValidInput("Do you have heavy objects outside? (yes/no)") + "_";
        decision += getValidInput("Are you planning to secure them? (yes/no)") + "_";
        decision += getValidInput("Do you feel like going out? (yes/no)") + "_";
        decision += getValidInput("Is it sunny? (yes/no)") + "_";
        decision += getValidInput("Do you want to go for a swim? (yes/no)") + "_";
        decision += getValidInput("Do you have specific plans? (yes/no)") + "_";
        decision += getValidInput("Do you feel like exercising? (yes/no)");

        switch (decision)
        {
            case "yes_yes_yes_yes_no_no_no_no_no_no_no_no_no_no_no":
                Console.WriteLine("Go for a walk.");
                break;
            case "yes_yes_yes_no_no_no_no_no_no_no_no_no_no_no_no":
                Console.WriteLine("Stay home and read a book.");
                break;
            case "yes_yes_no_no_yes_no_no_no_no_no_no_no_no_no_no":
                Console.WriteLine("Wear your raincoat.");
                break;
            case "yes_no_yes_no_no_no_no_no_no_no_no_no_no_no_no":
                Console.WriteLine("Stay home.");
                break;
            case "yes_no_no_yes_no_no_no_no_no_no_no_no_no_no_no":
                Console.WriteLine("Drive your car.");
                break;
            case "yes_no_no_no_no_yes_no_no_no_no_no_no_no_no_no":
                Console.WriteLine("It's better to cancel your plans.");
                break;
            case "yes_no_no_no_no_no_no_no_no_no_no_no_no_no_no":
                Console.WriteLine("Stay home and drink tea.");
                break;
            case "no_no_no_no_no_no_no_yes_no_yes_no_no_no_no_no":
                Console.WriteLine("Go out and secure them.");
                break;
            case "no_no_no_no_no_no_no_yes_no_no_yes_no_no_no_no":
                Console.WriteLine("Go for a walk.");
                break;
            case "no_no_no_no_no_no_no_yes_no_no_no_no_no_no_no":
                Console.WriteLine("Stay home and relax.");
                break;
            case "no_no_no_no_no_no_no_no_no_no_no_yes_yes_no_no":
                Console.WriteLine("Go to the pool.");
                break;
            case "no_no_no_no_no_no_no_no_no_no_no_yes_no_yes_no":
                Console.WriteLine("Go ahead with your plans.");
                break;
            case "no_no_no_no_no_no_no_no_no_no_no_yes_no_no_yes":
                Console.WriteLine("Watch a movie.");
                break;
            case "no_no_no_no_no_no_no_no_no_no_no_no_no_no_yes":
                Console.WriteLine("Go exercise.");
                break;
            case "no_no_no_no_no_no_no_no_no_no_no_no_no_no_no":
                Console.WriteLine("Stay home and cook a delicious meal.");
                break;
            default:
                Console.WriteLine("Wrong answer!");
                break;
        }
    }


}