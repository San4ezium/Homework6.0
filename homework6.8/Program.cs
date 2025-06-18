// See https://aka.ms/new-console-template for more information
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

bool isPrime = true;

if (number <= 1)
    isPrime = false;
else
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}

if (isPrime)
    Console.WriteLine($"{number} — prime number.");
else
    Console.WriteLine($"{number} — not prime number.");
