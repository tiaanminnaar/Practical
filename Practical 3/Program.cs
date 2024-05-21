//3) Palindrome number
//Write a c# program to check palindrome number.
//Input: 121
//Output: palindrome number
//Input: 113
//Output: not palindrome number

bool ispalandrome = false;

while (ispalandrome == false)
{
    WriteLine("Enter the number witch you would like to see if it is a palindrome number.");
    var n = int.Parse(ReadLine());
    ispalandrome = CheckPalindromeNumber(n);
}

bool CheckPalindromeNumber(int n)
{
    int ReverseInt(int num)
    {
        return Convert.ToInt32(new string(num.ToString().Reverse().ToArray()));
    }

    int n1 = ReverseInt(n);

    if (n == n1)
        return true;
    return false;
}