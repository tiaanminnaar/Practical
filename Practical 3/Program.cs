//3) Palindrome number
//Write a c# program to check palindrome number.
//Input: 121
//Output: palindrome number
//Input: 113
//Output: not palindrome number

WriteLine("Enter the number witch you would like to see if it is a palindrome number.");
var n = int.Parse(ReadLine());
CheckPalindromeNumber(n);

var m = int.Parse(ReadLine());
CheckPalindromeNumber(m);


void CheckPalindromeNumber(int n)
{
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

    int n1 = ReverseInt(n);

    if (n == n1)
        WriteLine("palimdrome number");
    else
        WriteLine("not palimdrome number");
}
