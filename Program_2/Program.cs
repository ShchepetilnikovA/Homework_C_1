void ThirdDigit (int n1)
{
   int n2 = 100; //потому что ищем третье число
   if(n2 > n1)
   {
    Console.WriteLine("Number haven't third digit");
   }
   else
   {
    while(n1/n2 > 0)
    {
        n2 = n2*10;
    }
    int n3 = n1/(n2/1000); // потому что ищем третье число
    int n4 = n3 % 10;
    Console.WriteLine("Third digit in number is: " + n4);
   }
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
ThirdDigit (number);
