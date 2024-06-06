int count = 0;
int prevSum = 0;

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
                if (c != (a & b))
                {
                    prevSum = (prevSum + c) * 10;
                    for (int d = 0; d <= 9; d++)
                    {
                        if (d != (a & b & c))
                        {
                            prevSum = (prevSum + d) * 10;
                            for (int e = 0; e <= 9; e++)
                            {
                                if (e != (a & b & c & d))
                                {
                                    prevSum = (prevSum + e) * 10;
                                    for (int f = 0; f <= 9; f++)
                                    {
                                        if (f != (a & b & c & d & e))
                                        {
                                            prevSum = (prevSum + f) * 10;
                                            for (int g = 0; g <= 9; g++)
                                            {
                                                if (g != (a & b & c & d & e & f))
                                                {
                                                    prevSum = (prevSum + g) * 10;
                                                    for (int h = 0; h <= 9; h++)
                                                    {
                                                        if (b != (a & b & c & d & e & f & g))
                                                        {
                                                            prevSum = (prevSum + h) * 10;
                                                            for (int i = 0; i <= 9; i++)
                                                            {
                                                                if (b != (a & b & c & d & e & f & g & h))
                                                                {
                                                                    prevSum = (prevSum + i) * 10;
                                                                    for (int j = 0; j <= 9; j++)
                                                                    {
                                                                        if (j != (a & b & c & d & e & f & g & h & i))
                                                                        {
                                                                            prevSum += a;
                                                                            count++;
                                                                        }
                                                                        if (count == 1000000)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}


WriteLine(prevSum);