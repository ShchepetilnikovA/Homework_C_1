void Holliday (int n1)
{
    if(n1>7) 
    {
        Console.WriteLine("error");
    }
    else
    {
        if(n1 > 5) Console.WriteLine("It's holliday");
        else Console.WriteLine("it's weekday");
    }
}
Console.WriteLine("Input number od day: ");
int number = Convert.ToInt32(Console.ReadLine());
number = number*-1;
Holliday(number);