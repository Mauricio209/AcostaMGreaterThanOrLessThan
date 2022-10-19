//Mauricio Acosta
//10-18-22
//Git Challange Greater or less than


string playAgain = "yes";
while (playAgain == "yes")
{
    Console.Clear();
Console.WriteLine("Enter two numbers");
string numberOne = Console.ReadLine();
string numberTwo = Console.ReadLine();

int numOne = Convert.ToInt32(numberOne);
int numTwo = Convert.ToInt32(numberTwo);

if ( numOne > numTwo ){
    Console.WriteLine(numOne + " is greater then " + numTwo);
}else if( numOne < numTwo ){
    Console.WriteLine(numOne + " is less than " + numTwo);
}else{
 Console.WriteLine(numOne + " is equal to " + numTwo);


}
Console.WriteLine("Type yes to play again");

playAgain = Console.ReadLine();
}