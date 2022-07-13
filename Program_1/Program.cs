void SecondDigit (int n1)
{
    int twoDigit = n1%100;
    int SeconDig = twoDigit/10;
    Console.WriteLine("Second Digit is: " + SeconDig);
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
SecondDigit(number);