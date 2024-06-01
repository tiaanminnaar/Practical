int count = 1;
ulong digitsOf2ToPowerOf1000 = 0;
ulong sum = 2;
while (count < 1000)
{
    sum *= 2;
    count++;
    digitsOf2ToPowerOf1000 = sum;
}


//ulong digitsOf2ToPowerOf1000 = (ulong)MathF.Pow(2, 1000);

int sumOfDigitsOf2ToPowerOf1000 = SumOfDigits(digitsOf2ToPowerOf1000);

int SumOfDigits(ulong n)
{
    ulong sum = 0;
    ulong r;

    while (n > 0)
    {
        r = n % 10;
        sum += r;
        n = n / 10;
    }
    return (int)sum;
}