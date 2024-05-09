//10) Alphabet Triangle
//Write a c# program to print alphabet triangle.
//Output:
//     A
//    ABA
//   ABCBA
//  ABCDCBA
// ABCDEDCBA

int current;
int prevous = 0;
int Reverseprevous = 0;
string prevousstr = null;
string ReversePrevousstr = null;

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

for (int i = 1; i <= 26; i++)
{
    current = i;

    for (int j = i; j <= 26; j++)
    {
        Write($" ");
    }

    WriteLine($"{prevousstr}{current}{ReversePrevousstr}");

    prevousstr = $"{prevousstr}{current}";

    prevous = current;
    Reverseprevous = ReverseInt(int.Parse(prevousstr));

    ReversePrevousstr = $"{Reverseprevous}";
}