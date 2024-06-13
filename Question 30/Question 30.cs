string numStr = string.Empty;
int fifthSum = 0;
for (int i = 10000; i <= 99999; i++)
{
    int h = i;
    numStr = i.ToString();
    int fifthPowerSum = FifthSum(numStr);

    if (i == fifthPowerSum)
    {
        fifthSum += h;
    }
}

WriteLine(fifthSum);

int FifthSum(string numStr)
{
    int finalNum = 0;
    int num = 0;
    int prevNum = 0;
    for (int i = 0; i < numStr.Length ; i++)
    {
        prevNum = finalNum;
        num = int.Parse(numStr[i].ToString());
        finalNum = prevNum + ToPowerOfFive(num, numStr.Length);
    }
    return finalNum;
}

int ToPowerOfFive(int num,int lenght)
{
    int powerOfFive = (int)Math.Pow(num, lenght);
    return powerOfFive;
}