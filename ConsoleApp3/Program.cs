//11) Number Triangle
//Write a c# program to print number triangle.
//Input: 5
//Output:
//enter the range = 6
//      1
//     121
//    12321
//   1234321
//  123454321
// 12345654321

WriteLine($"Enter the range of te triangle you would like to see");
var Range = int.Parse(ReadLine());

WriteLine($"enter the range = {Range + 1}");
int current;
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

for (int i = 1; i <= Range + 1; i++)
{
    current = i;
    
    for (int j = i; j <= Range; j++)
    {
        Write($" ");
    }

    WriteLine($"{prevousstr}{current}{ReversePrevousstr}");

    prevousstr = $"{prevousstr}{current}";

    int Reverseprevous = ReverseInt(int.Parse(prevousstr));

    ReversePrevousstr = $"{Reverseprevous}";
}