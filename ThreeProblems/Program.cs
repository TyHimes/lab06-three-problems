/*
* Name: Tyler Himes
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

using System.Runtime.CompilerServices;

Random rng = new Random(4000);

int choice;

const int choiceOne = 1;
const int choiceTwo = 2;
const int choiceThree = 3;
const int choiceAll = 4;
const int leaveValue = 5;


//DO WHILE LOOP FOR ENTIRE FUNCTION, REPEATS IF USER CHOICE IS != 5
do
{

//INTIAL INFORMATION
Console.WriteLine("\n=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All three");
System.Console.WriteLine("5. Quit");

//USER CHOICE FOR PROBLEM
System.Console.Write("Choose 1 through 5: ");
choice = Convert.ToInt32(Console.ReadLine());

//VALUE CHECKER, IF IT IS OUTSIDE THE SCOPE OF CHOICES YOU CHOOSE AGAIN
while (choice < choiceOne || choice > leaveValue)
{
    System.Console.WriteLine("Choose a number from 1 to 5.");
    System.Console.Write("Choose 1 through 5: ");
    choice = Convert.ToInt32(Console.ReadLine());
}

//GRADE CHECKER - CHOICE ONE
if(choice == choiceOne || choice == choiceAll)
{
    //INITIAL VARIABLES
    bool validInput = false;
    char gradeLetter;

    //HEADER GRADE CHECKER
    System.Console.WriteLine("\n=== Exercise 1: The Grade Checker ===");

    //WHILE THE INPUT IS NOT VALID, REPEAT
    while (!validInput)
    {
        //GATHER USER INPUT
        System.Console.Write("Score: ");
        int gradeNum = Convert.ToInt32(Console.ReadLine());
        //CHECKS IF USER INPUT IS VALID
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
            //OUTPUT GRADE CHECKER
            System.Console.WriteLine($"{gradeNum} earns a {gradeLetter}.");
        }
        else
        {
            //IF LESS THAN ZERO OR GREATER THAN 100
            System.Console.WriteLine("A score must be between 0 and 100.");
        }
        
    }
}



//DICE TABLE - CHOICE TWO
if(choice == choiceTwo || choice == choiceAll)
{
    //INITIAL VARIABLES
    char rollAgain = 'y';
    int rollAmount = 0;
    int wonAmount = 0;

    //HEADER DICE TABLE
    System.Console.WriteLine("\n=== Exercise 2: The Dice Table ===");


    //While the user rolls - roll the dice, get summary, increase roll amount
    while(rollAgain != 'n')
    {
    rollAmount++;

    const int snakeEyeValue = 1;
    const int diceWinSeven = 7;
    const int diceWinEleven = 11;
    int diceRoll = rng.Next(1,7);
    int anotherDiceRoll = rng.Next(1,7);
    int totalDiceAmount = diceRoll + anotherDiceRoll;
    string outcome;
    
    //dice outcomes
    if (diceRoll == snakeEyeValue && anotherDiceRoll == snakeEyeValue)
            {
                outcome = "Snake eyes.";
            }
    else if(diceRoll == anotherDiceRoll)
            {
                outcome = "Doubles!";
            }
    else if(totalDiceAmount == diceWinSeven || totalDiceAmount == diceWinEleven)
            {
                outcome = "A winner.";
                wonAmount++;
            }
            else
            {
                outcome = "";
            }

    //OUTPUT FOR DICE ROLLS
    System.Console.WriteLine($"Roll {rollAmount}: {diceRoll} and {anotherDiceRoll}, total {totalDiceAmount}. {outcome}");
    System.Console.WriteLine("Roll again? (y/n): ");
    rollAgain = Console.ReadLine()[0];
    }
    //SUMMARY
    System.Console.WriteLine($"You rolled {rollAmount} times and won {wonAmount}.");
}
    

//SCORE REPORT - CHOICE THREE
if(choice == choiceThree || choice == choiceAll)
{
    //INITIAL VARIABLES
    int[] scoreValues = new int[5];
    int total = 0;
    int passingAmount = 0;
    const int passingScoreMin = 60;

    //HEADER SCORE REPORT
    System.Console.WriteLine("\n=== Exercise 3: The Score Report ===");

    //GET VALUE FOR EACH SCORE AND PUT IN ARRAY
    for(int i = 0; i < scoreValues.Length; i++)
        {
            System.Console.WriteLine($"Score {i + 1}: ");
            scoreValues[i] = Convert.ToInt32(Console.ReadLine());
        }

    //Get the highest score value
    int max = scoreValues.Max();

    //For each score value, get the total, the average, etc.
    foreach(int score in scoreValues)
        {
            total += score;
            
            if(score >= passingScoreMin)
            {
                passingAmount++;
            }
        }
    //AVERAGING SCORE VALUES
    double average = Convert.ToDouble(total)/scoreValues.Length;

//OUTPUT SCORE REPORT
System.Console.WriteLine($"\nScores entered: {scoreValues.Length}");
System.Console.WriteLine($"Total: {total}");
System.Console.WriteLine($"Average: {average}");
System.Console.WriteLine($"Highest: {max}");
System.Console.WriteLine($"Passing: {passingAmount} of {scoreValues.Length}");
}
}
while(choice != leaveValue);

//END OUTPUT
Console.WriteLine("\nGoodbye.");