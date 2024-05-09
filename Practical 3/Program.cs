//3) Palindrome number
//Write a c# program to check palindrome number.
//Input: 121
//Output: palindrome number
//Input: 113
//Output: not palindrome number

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

if (num == num1)
    WriteLine("palimdrome number");
else
    WriteLine("not palimdrome number");