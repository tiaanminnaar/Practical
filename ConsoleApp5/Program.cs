//13) Number in Characters
//Write a c# program to convert number in characters.
//Input: 357546
//Output: three five seven five four six

var num = int.Parse(ReadLine());

int ReverseInt(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result * 10 + num % 10;
        num /= 10;
    }
    return result;
}

int num1 = ReverseInt(num);
int sum = 0;
int last;
string prevous = null;
string laststr  = null;
string value = null;

while (num1 > 0)
{
    prevous = value;
    last = num1 % 10;
    num1 = num1 / 10;
    switch (last)
    {
        case 1:
            laststr = $"{last}";
            laststr = $"one ";
            break;
        case 2:
            laststr = $"{last}";
            laststr = $"two ";
            break;
        case 3:
            laststr = $"{last}";
            laststr = $"three ";
            break;
        case 4:
            laststr = $"{last}";
            laststr = $"four ";
            break;
        case 5:
            laststr = $"{last}";
            laststr = $"five ";
            break;
        case 6:
            laststr = $"{last}";
            laststr = $"six ";
            break;
        case 7:
            laststr = $"{last}";
            laststr = $"seven ";
            break;
        case 8:
            laststr = $"{last}";
            laststr = $"eight ";
            break;
        case 9:
            laststr = $"{last}";
            laststr = $"nine ";
            break;
        case 0:
            laststr = $"{last}";
            laststr = $"zero ";
            break;

    }
    value = $"{prevous}{laststr}";
}
WriteLine($"{value}");