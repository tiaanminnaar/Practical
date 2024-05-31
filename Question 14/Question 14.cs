long longestChain = 0;
long longestChainStart = 1;

for (int i = 113383;  i <= 1000000; i++)
{
    long r = i;
    long chain = 1;
    while (r != 1)
    {
        if (r % 2 == 0)
        {
            r /= 2;
            chain++;
        }
        else
        {
            r = (r * 3) + 1;
            chain++;
        }

    }
    if (chain > longestChain)
    {
        longestChain = chain;
        longestChainStart = i;
    }
}


WriteLine(longestChainStart);