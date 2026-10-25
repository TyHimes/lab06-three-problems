/*
* Name: Tyler Himes
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

using System.ComponentModel;
using System.Xml.Serialization;
int choice;
Random rng = new Random(4000);


do
{

Console.WriteLine("\n=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All three");
System.Console.WriteLine("5. Quit");

System.Console.Write("Choose 1 through 5: ");
choice = Convert.ToInt32(Console.ReadLine());

    while (choice < 1 || choice > 5)
    {
        System.Console.WriteLine("Choose a number from 1 to 5.");
        System.Console.Write("Choose 1 through 5: ");
        choice = Convert.ToInt32(Console.ReadLine());

    }




if(choice == 1 || choice == 4)
{


    bool validInput = false;
    char gradeLetter;

    System.Console.WriteLine("\n=== Exercise 1: The Grade Checker ===");
    while (!validInput)
    {
        System.Console.Write("Score: ");
        int gradeNum = Convert.ToInt32(Console.ReadLine());
        if (gradeNum >= 0 && gradeNum <= 100)
        {
            gradeNum = Convert.ToInt32(gradeNum);
            validInput = true;
            if(gradeNum >= 90)
            {
                gradeLetter = 'A';
            }
            else if(gradeNum >= 80)
            {
                gradeLetter = 'B';
            }
            else if(gradeNum >= 70)
            {
                gradeLetter = 'C';
            }
            else if(gradeNum >= 60)
            {
                gradeLetter = 'D';
            }
            else
            {
                gradeLetter = 'F';
            }
            System.Console.WriteLine($"{gradeNum} earns a {gradeLetter}.");
        }
        else
        {
            System.Console.WriteLine("A score must be between 0 and 100.");
        }
        
    }
}



        
    
if(choice == 2 || choice == 4)
{
    char rollAgain = 'y';
    int rollAmount = 0;
    int wonAmount = 0;

    System.Console.WriteLine("\n=== Exercise 2: The Dice Table ===");

    while(rollAgain != 'n')
    {
    rollAmount++;
    int diceRoll = rng.Next(1,7);
    int anotherDiceRoll = rng.Next(1,7);
    int totalDiceAmount = diceRoll + anotherDiceRoll;
    
    string outcome;
    
    if (diceRoll == 1 && anotherDiceRoll == 1)
            {
                outcome = "Snake eyes.";
            }
    else if(diceRoll == anotherDiceRoll)
            {
                outcome = "Doubles!";
            }
    else if(totalDiceAmount == 7 || totalDiceAmount == 11)
            {
                outcome = "A winner.";
                wonAmount++;
            }
            else
            {
                outcome = "";
            }


    System.Console.WriteLine($"Roll {rollAmount}: {diceRoll} and {anotherDiceRoll}, total {totalDiceAmount}. {outcome}");
    System.Console.WriteLine("Roll again? (y/n): ");
    rollAgain = Console.ReadLine()[0];
    }
    System.Console.WriteLine($"You rolled {rollAmount} times and won {wonAmount}.");
}
    
if(choice == 3 || choice == 4)
{
    
    
    int[] scoreValues = new int[5];
    int total = 0;
    int passingAmount = 0;
    const int passingScoreMin = 60;
    
    System.Console.WriteLine("=== Exercise 3: The Score Report ===");

    for(int i = 0; i < scoreValues.Length; i++)
        {
            System.Console.WriteLine($"Score {i + 1}: ");
            scoreValues[i] = Convert.ToInt32(Console.ReadLine());
        }
    int max = scoreValues.Max();
    foreach(int score in scoreValues)
        {
            total += score;
            
            if(score >= passingScoreMin)
            {
                passingAmount++;
            }
        }
        double average = Convert.ToDouble(total)/scoreValues.Length;
        
System.Console.WriteLine($"Scores entered: {scoreValues.Length}");
System.Console.WriteLine($"Total: {total}");
System.Console.WriteLine($"Average: {average}");
System.Console.WriteLine($"Highest: {max}");
System.Console.WriteLine($"Passing: {passingAmount} of {scoreValues.Length}");
}

}
while(choice != 5);
Console.WriteLine("\nGoodbye.");