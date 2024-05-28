int a2 = 0;
int b2 = 0;
int c2 = 0;
int abc2 = 0;
int product;

for (int a1 = 1; a1 <= 100; a1++)
{
    a2 = (int)Math.Pow(a1, 2);
    for (int b1 = 1; b1 <= 100; b1++)
    {
        b2 = (int)Math.Pow(b1, 2);
        for (int c1 = 1; c1 <= 100; c1++)
        {
            c2 = (int)Math.Pow(c1, 2);
            abc2 = a2 + b2 + c2;
            if (abc2 == 1000)
            {
                c2 = c2;
                break;
            }
        }
        if (abc2 == 1000)
        {
            b2 = b2;
            break;
        }
    }
    if (abc2 == 1000)
    {
        a2 = a2;
        break;
    }
}
int a = (int)Math.Sqrt(a2);
int b = (int)Math.Sqrt(b2);
int c = (int)Math.Sqrt(c2);
product = a + b + c;
WriteLine(product);