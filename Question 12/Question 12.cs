﻿long first500Divisitors = 0;
long h = 0;
for (int i = 1; i < long.MaxValue; i++)
{
    h += i;
    int chain = 0;
    for (long j = 1; j <= h; j++)
    {
        if (h %  2 != 0)
        {
            break;
        }
        bool trueDivisable = false;
        if (h % j == 0)
        {
            trueDivisable = true;
        }
        if (trueDivisable == true)
        {
            chain++;
        }
    }
    if (chain == 500)
    {
        first500Divisitors = i;
        break;
    }
}

WriteLine(first500Divisitors);