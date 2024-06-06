using System.Numerics;

BigInteger current = 0;
BigInteger prevous = 1;
BigInteger next;
int h = 0;
for (int i = 0; i < int.MaxValue; i++)
{
    h = i;
    next = prevous + current;
    string currentStr = $"{current}";
    BigInteger currentStrLength = currentStr.Length;
    prevous = current;
    current = next;
    if (currentStrLength == 1000)
    {
        break;
    }
}

WriteLine(h);