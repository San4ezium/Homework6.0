// See https://aka.ms/new-console-template for more information
Console.Write("Enter password: ");
string password = Console.ReadLine();

bool hasDigit = false;
bool hasSpecial = false;

for (int i = 0; i < password.Length; i++)
{
    char c = password[i];

    if (char.IsDigit(c))
        hasDigit = true;
    else if (!char.IsLetterOrDigit(c))
        hasSpecial = true;
}

if (password.Length >= 8 && hasDigit && hasSpecial)
    Console.WriteLine("Password accept.");
else
    Console.WriteLine("Password not accept.");