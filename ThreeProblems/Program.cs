/*
* Name: Tyler Himes
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

using System.Xml.Serialization;
int choice;
Random rng = new Random(4000);

Console.WriteLine("\n=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All three");
System.Console.WriteLine("5. Quit");

do
{
    
System.Console.Write("Choose 1 through 5: ");
choice = Convert.ToInt32(Console.ReadLine());



if(choice == 1 || choice == 4)
{


    bool validInput = false;
    char gradeLetter;

    System.Console.WriteLine("\n=== Exercise 1: The Grade Checker ===");

}



        
    
if(choice == 2 || choice == 4)
{
    char rollAgain = 'y';
    int rollAmount = 0;
    int wonAmount = 0;

    System.Console.WriteLine("\n=== Exercise 2: The Dice Table ===");

}
    
if(choice == 3 || choice == 4)
{
    
    
    int[] scoreValues = new int[5];
    int total = 0;
    int passingAmount = 0;
    
    System.Console.WriteLine("\n=== Exercise 3: The Score Report ===");

    
}

if(choice < 1 || choice > 5)
    {
        System.Console.WriteLine("Choose a number from 1 to 5.");
    }

}
while(choice != 5);
Console.WriteLine("\nGoodbye.");

