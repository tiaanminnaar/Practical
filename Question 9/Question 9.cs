for (int a = 1; a < 1000; a++)
{
    for (int b = 1; b < 1000 - a; b++)
    {
        int c = 1000 - a - b;
        if (a * a + b * b == c * c)
        {
            WriteLine($"{a * b * c}");
            break;
        }
    }
}