int f100Square;
int f100SumSquare;
int awnser;
f100SumSquare = SquareOfSumOfNaturalNumbers(100);
f100Square = SquareOfNaturalNumbers(100);
awnser = f100SumSquare - f100Square;
WriteLine(awnser);

int SquareOfNaturalNumbers(int n)
{
    int squareOfNatNum = 0;
    for (int i = 1; i <= n; i++)
    {
        double iD = (double)i;
        squareOfNatNum += (int)Math.Pow(iD, 2);

    }
    return squareOfNatNum;
}

int SquareOfSumOfNaturalNumbers(int n)
{
    int sumSquareOfNatNum = 0;
    double sumSquareOfNatNumD = 1;
    for (int i = 1; i <= n; i++)
    {
        sumSquareOfNatNum += i;
        sumSquareOfNatNumD = sumSquareOfNatNum;
    }
    sumSquareOfNatNum = (int)Math.Pow(sumSquareOfNatNumD, 2);

    return sumSquareOfNatNum;
}