int num = 363, newNumber = 0, lastdigit, original;
original = num;

while (num != 0)
{
    lastdigit = num % 10;
    newNumber = newNumber * 10 + lastdigit;
    num /= 10;
}

if (original == newNumber)
    Console.WriteLine("polindromdu");
else
    Console.WriteLine("polindrom deyil");
