// See https://aka.ms/new-console-template for more information

/* swap values
Console.WriteLine("Input the first number: ");
int num1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input the second number: ");
int num2 = Int32.Parse(Console.ReadLine());

int num3 = num1;
num1 = num2;
num2 = num3;

Console.WriteLine("First number: " + num1.ToString());
Console.WriteLine("Second number: " + num2.ToString());
*/

int[] arr = {1, 2, 3, 4, 5};

foreach(int x in arr)
{
    
    Console.WriteLine($"{x}");

}