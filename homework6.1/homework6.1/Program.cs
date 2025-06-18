// See https://aka.ms/new-console-template for more information
Console.Write("Enter number workers: ");
int count = int.Parse(Console.ReadLine());
int i = 0;
decimal totalSalary = 0;

while (i < count)
{
    Console.Write($"Enter salary workers #{i + 1}: ");
    decimal salary = decimal.Parse(Console.ReadLine());
    totalSalary += salary;
    i++;
}
decimal average = totalSalary / count;
Console.WriteLine($"\nAverage earnings: {average:F2} ");

