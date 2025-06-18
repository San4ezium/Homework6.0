// See https://aka.ms/new-console-template for more information
Console.Write("Enter a number for the multiplication table: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"\nMultiplication table for a number {number}:\n");

for (int i = 1; i <= 10; i++)
{
    int result = number * i;
    Console.WriteLine($"{number} * {i} = {result}");
}
