// See https://aka.ms/new-console-template for more information
Console.Write("Enter the number of Fibonacci numbers: ");
int n = int.Parse(Console.ReadLine());

int a = 0;
int b = 1;

for (int i = 0; i < n; i++)
{
    Console.Write(a + " ");
    int temp = a + b;
    a = b;
    b = temp;
}
