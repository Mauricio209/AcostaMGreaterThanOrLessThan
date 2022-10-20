//Mauricio Acosta
//10-18-22
//Git Challange Greater or less than

string numberOne = "";
string numberTwo = "";
int numOne2;
int numTwo2;
string playAgain = "yes";
while (playAgain == "yes")
{
    Console.Clear();
bool isConverted = false;
bool isConverted2 = false;
    while (isConverted == false)
    {
        Console.WriteLine("Enter your first number");
        numberOne = Console.ReadLine();
        isConverted = Int32.TryParse(numberOne, out numOne2);
        if (isConverted == false)
        {
            Console.WriteLine("Enter a valid Number");
        }
    }
    while (isConverted2 == false)
    {

        Console.WriteLine("Enter your second number");
        numberTwo = Console.ReadLine();
        isConverted2 = Int32.TryParse(numberTwo, out numTwo2);
        if (isConverted2 == false)
        {
            Console.WriteLine("Enter a valid Number");
        }
    }

    int numOne = Convert.ToInt32(numberOne);

    int numTwo = Convert.ToInt32(numberTwo);

    if (numOne > numTwo)
    {
        Console.WriteLine(numOne + " is greater then " + numTwo);
    }
    else if (numOne < numTwo)
    {
        Console.WriteLine(numOne + " is less than " + numTwo);
    }
    else
    {
        Console.WriteLine(numOne + " is equal to " + numTwo);


    }
    Console.WriteLine("Type yes to play again");

    playAgain = Console.ReadLine();
}