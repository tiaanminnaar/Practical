using System.Numerics;

BigInteger posabilities = GridPosabilities(20,20);

BigInteger GridPosabilities(BigInteger x, BigInteger y)
{
    BigInteger topFactoral = Factoral((x + y));
    BigInteger xBottomFactoral = Factoral(x);
    BigInteger yBottomFactoral = Factoral(y);
    BigInteger bottomFactoral = xBottomFactoral * yBottomFactoral;
    BigInteger gridPosabilities = topFactoral / bottomFactoral;
    return gridPosabilities;
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

WriteLine(posabilities);