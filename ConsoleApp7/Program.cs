//7) Reverse Number
//Write a c# program to reverse given number.
//Input: 234
//Output: 432

WriteLine("Enter the number to see its revesed number");
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

var num1 = ReverseInt(num);

WriteLine(num1);