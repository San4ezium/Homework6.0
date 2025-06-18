// See https://aka.ms/new-console-template for more information
Console.Write("Enter number ");
int max = int.Parse(Console.ReadLine());

for (int num = 2; num <= max; num++)
{
    bool isPrime = true;

    for (int i = 2; i * i <= num; i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
        Console.WriteLine(num);
}

