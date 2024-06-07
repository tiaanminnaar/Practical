int count = 0;
long prevSum = 0;
long sum = 0;

for (int a = 0; a <= 9; a++)
{
    prevSum = a * 10;
    for (int b = 0; b <= 9; b++)
    {
        if (b != a)
        {
            prevSum = (prevSum + b) * 10;
            for (int c = 0; c <= 9; c++)
            {
                if ((c != b) & (c != a))
                {
                    prevSum = (prevSum + c) * 10;
                    for (int d = 0; d <= 9; d++)
                    {
                        if ((d != a) & (d != b) & (d != c))
                        {
                            prevSum = (prevSum + d) * 10;
                            for (int e = 0; e <= 9; e++)
                            {
                                if ((e != a) & (e != b) & (e != c) & (e != d))
                                {
                                    prevSum = (prevSum + e) * 10;
                                    for (int f = 0; f <= 9; f++)
                                    {
                                        if ((f != a) & (f != b) & (f != c) & (f != d) & (f != e))
                                        {
                                            prevSum = (prevSum + f) * 10;
                                            for (int g = 0; g <= 9; g++)
                                            {
                                                if ((g != a) & (g != b) & (g != c) & (g != d) & (g != e) & (g != f))
                                                {
                                                    prevSum = (prevSum + g) * 10;
                                                    for (int h = 0; h <= 9; h++)
                                                    {
                                                        if ((h != a) & (h != b) & (h != c) & (h != d) & (h != e) & (h != f) & (h != g))
                                                        {
                                                            prevSum = (prevSum + h) * 10;
                                                            for (int i = 0; i <= 9; i++)
                                                            {
                                                                if ((i != a) & (i != b) & (i != c) & (i != d) & (i != e) & (i != f) & (i != g) & (i != h))
                                                                {
                                                                    prevSum = (prevSum + i) * 10;
                                                                    for (int j = 0; j <= 9; j++)
                                                                    {
                                                                        if ((j != a) & (j != b) & (j != c) & (j != d) & (j != e) & (j != f) & (j != g) & (j != h) & (j != i))
                                                                        {
                                                                            prevSum += j;
                                                                            sum = prevSum;
                                                                            count++;
                                                                            if (count == 1000000)
                                                                            {
                                                                                WriteLine(sum);
                                                                                break;
                                                                            }                                                                            
                                                                        }
                                                                    }
                                                                    prevSum = (prevSum / 100) * 10;
                                                                }                                                                
                                                            }
                                                            prevSum = (prevSum / 100) * 10;
                                                        }
                                                    }
                                                    prevSum = (prevSum / 100) * 10;
                                                }
                                            }
                                            prevSum = (prevSum / 100) * 10;
                                        }
                                    }
                                    prevSum = (prevSum / 100) * 10;
                                }
                            }
                            prevSum = (prevSum / 100) * 10;
                        }
                    }
                    prevSum = (prevSum / 100) * 10;
                }
            }
            prevSum = ( prevSum / 100) * 10;
        }
    }
    prevSum = 0;
}

