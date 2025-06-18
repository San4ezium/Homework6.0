// See https://aka.ms/new-console-template for more information
Console.Write("Enter the number of graph lines: ");
int lines = int.Parse(Console.ReadLine());

for (int i = 1; i <= lines; i++)
{
    for (int j = 1; j <= i; j++)
        Console.Write("*");
    Console.WriteLine();
}
