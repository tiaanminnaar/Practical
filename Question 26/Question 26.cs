double one = 1;
int longestRecursionLenght = 0;
double longestRecursionNumber = 0;
for (double num = 2; num <= 1000; num++)
{ 
    double awnser = one / num;
    string awnserStr = awnser.ToString();
    int checkRecursion = CheckRecursion(awnserStr, num);
    if (CheckRecursion(awnserStr, num) > longestRecursionLenght)
    {
        longestRecursionLenght = CheckRecursion(awnserStr, num);
        longestRecursionNumber = num;
    }
}

WriteLine(longestRecursionNumber);

int CheckRecursion(string awnserStr, double n)
{
    int u = (int)n;
    int firstNum = 0;
    int secondNum = 0;
    string firstSrting = string.Empty;
    string recursion = string.Empty;
    if (awnserStr.Length >= 2)
    {
        firstNum = int.Parse(awnserStr[2].ToString());
    }
    if (awnserStr.Length >= 4)
    {
        secondNum = int.Parse(awnserStr[3].ToString());
    }
    int num = 0;
    int longestRecursion = 0;
    if (n % 3 == 0)
    {
        longestRecursion = CheckDividedBy3(awnserStr, u, longestRecursion);
    }
    if (n % 3 != 0)
    {
        for (int i = 2; i < awnserStr.Length; i++)
        {
            firstSrting += awnserStr[i].ToString();
            int prevNum = num;
            num = int.Parse(awnserStr[i].ToString());
            if ((firstNum == num) && (i >= 4))
            {
                if (firstSrting == Recursion(awnserStr, i, firstSrting))
                {
                    break;
                }
            }
            longestRecursion++;
        }
    }    
    return longestRecursion;
}
string Recursion(string numStr, int x, string firstString)
{
    string recursion = string.Empty;
    int maxLength = (x + x) - 2;
    if (numStr.Length < maxLength)
    {
        recursion = firstString;
    }
    if (numStr.Length > maxLength)
    {
        for (int i = x; i <= maxLength; i++)
        {
            recursion += numStr[i].ToString();
        }
    }
    return recursion;
}

int CheckDividedBy3(string numStr, int num, int checkRecursion)
{
    if (num % 3 == 0)
    {
        if (int.Parse(numStr[2].ToString()) == int.Parse(numStr[2].ToString()))
        {
            checkRecursion++;
        }
        if (int.Parse(numStr[2].ToString()) == int.Parse(numStr[3].ToString()))
        {
            checkRecursion++;
            checkRecursion++;
        }
    }
    return checkRecursion;
}