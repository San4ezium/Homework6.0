// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.Write("Enter the number of hours (or 0 to exit): ");
    double hours = double.Parse(Console.ReadLine());

    if (hours == 0)
        break;

    Console.Write("Enter hourly rate: ");
    double rate = double.Parse(Console.ReadLine());

    double pay = hours * rate;

    Console.WriteLine($"Payment per day: {pay} \n");
}