//6) Sum of Digits
//Write a c# program to print sum of digits.
//Input: 23
//Output: 5
//Input: 624
//Output: 12

WriteLine("Enter the number to see the sum of its digits");
var n = int.Parse(ReadLine());
SumOfDigits(n);

var m = int.Parse(ReadLine());
int t = SumOfDigits(m);
WriteLine(t);

if (t > 100)
{
    WriteLine("t greater than 100");
}
int SumOfDigits(int num)
{
    int sum = 0;
    int r;

    while (num > 0)
    {
        r = num % 10;
        sum = sum + r;
        num = num / 10;
    }
    return sum;
}