long sumOfPrime = 0;
for (int i = 2; i < 2000000; i++)
{
    var prime = true;

    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            prime = false;
            break;
        }
    }
    if (prime)
    {
        sumOfPrime += i;
    }
}

WriteLine(sumOfPrime);