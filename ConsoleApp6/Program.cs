//6) Sum of Digits
//Write a c# program to print sum of digits.
//Input: 23
//Output: 5
//Input: 624
//Output: 12

var num = int.Parse(ReadLine());

int sum = 0;
int r;

while (num > 0)
{
    r = num % 10;
    sum = sum + r;
    num = num / 10;
}
WriteLine(sum);