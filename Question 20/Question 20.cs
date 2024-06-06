using System;
using System.Numerics;

BigInteger factoral100 = Factoral(100);
BigInteger sumOfFacoral100 = SumOfDigits(factoral100);

WriteLine(sumOfFacoral100);

BigInteger SumOfDigits(BigInteger x)
{
    BigInteger sum = 0;
    BigInteger r;
    while (x > 0)
    {
        r = x % 10;
        sum = sum + r;
        x = x / 10;
    }
    return sum;
}

BigInteger Factoral(BigInteger x)
{
    BigInteger factoral = 1;
    for (BigInteger i = x; i >= 2; i--)
    {
        factoral *= i;
    }
    return factoral;
}