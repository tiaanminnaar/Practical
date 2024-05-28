int largestPalindrome = 1;

for (int i = 1000; i > 100; i--)
{
    int sum;
    bool ifPalindrome = false;
    int newPalindrome;
    
    for (int j = 1000; j > 100; j--)
    {
        sum = i * j;
        ifPalindrome = CheckIfPalindrome(sum);

        if (ifPalindrome == true)
        {
            newPalindrome = CheckPalindrome(sum);

            if (newPalindrome > largestPalindrome)
            {
                largestPalindrome = newPalindrome;
            }
        }        
    }    
}
WriteLine(largestPalindrome);

bool CheckIfPalindrome(int n)
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
int CheckPalindrome(int m)
{
    int ReverseInt(int m)
    {
        return Convert.ToInt32(new string(m.ToString().Reverse().ToArray()));
    }

    int m1 = ReverseInt(m);

    if (m == m1)
    {
        return m;
    }
    return m1;
}