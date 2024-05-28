int current = 1;
int prevous = 1;
int next;
int max = 4000000;
int febonaciSum = 0;

for (int i = 1; i < max; i++)
{
    while (current < max)
    {
        next = prevous + current;
        if (current % 2 == 0)
        {
            febonaciSum = febonaciSum + current;
        }
        prevous = current;
        current = next;
    }
}
WriteLine(febonaciSum);