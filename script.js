let num = 363, newNumber = 0, lastdigit, original;
original = num;

while (num != 0)
{
    lastdigit = num % 10;
    newNumber = newNumber * 10 + lastdigit;
    num = (num - lastdigit ) / 10;
}

if (original == newNumber)
    console.log('polindromdu');
else
    console.log('polindrom deyil');