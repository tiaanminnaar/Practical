//12) Fibonacci Triangle
//Write a c# program to generate fibonacci triangle.
//Input: 9
//Output:
//1
//1   1
//1   1   2
//1   1   2   3
//1   1   2   3   5
//1   1   2   3   5   8
//1   1   2   3   5   8   13
//1   1   2   3   5   8   13  21
//1   1   2   3   5   8   13  21  34

WriteLine($"Enter the the range of the fibonacci series triangle you would like to see");
var a = int.Parse(ReadLine());

int current = 1;
int prevous = 0;
int next;
string prevousstr = null;

for (int i = 0; i < a; i++)
{
    next = prevous + current;

    WriteLine($"{prevousstr}{current}");

    prevousstr = $"{prevousstr}{current} ";

    prevous = current;
    current = next;
}