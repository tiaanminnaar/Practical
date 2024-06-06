int sumOfAmicalPair = 0;

for (int i = 2; i <= 10000; i++)
{
    int r;
    int sum = 0;
    int checkAmicalPair;
    for (int j = 1; j < i; j++)
    {        
        if (i % j == 0)
        {
            r = j;
            sum += r;            
        }
    }
    checkAmicalPair = CheckIfAmicablePair(sum);
    if (checkAmicalPair == i && i < sum)
    {
        sumOfAmicalPair += (i + sum);
    }
}

WriteLine(sumOfAmicalPair);

int CheckIfAmicablePair(int x)
{
    int o;
    int amicalSum = 0;
    for (int k = 1; k < x; k++)
    {
        if (x % k == 0)
        {
            o = k;
            amicalSum += o;
        }
    }
    return amicalSum;
}