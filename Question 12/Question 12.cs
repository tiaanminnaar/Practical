int first500Dividors = 0;
int last499Divisidors(int last499Divisidors) 
{
    for (int i = last499Divisidors; i > 1; i--)
    {
        string triangeNumber = string.Empty;
        string prevTriangleNumber = string.Empty;
        for (int j = i; j >= 1; j--)
        {
            bool trueDivisable = false;
            if (i % j == 0)
            {
                trueDivisable = true;
            }
            if (trueDivisable == true)
            {
                triangeNumber = prevTriangleNumber + "1";
                prevTriangleNumber = triangeNumber;
            }
        }
        if (triangeNumber.Length == 499)
        {
            last499Divisidors = i;
            break;
        }
    }
    return last499Divisidors;
}

int lastOf499Divisitors = last499Divisidors(int.MaxValue);
for (int i = lastOf499Divisitors; i < int.MaxValue; i++)
{
    string triangeNumber = string.Empty;
    string prevTriangleNumber = string.Empty;
    for (int j = i; j <= i; j++)
    {
        bool trueDivisable = false;
        if (i % j == 0)
        {
            trueDivisable = true;
        }
        if (trueDivisable == true)
        {
            triangeNumber = prevTriangleNumber + "1";
            prevTriangleNumber = triangeNumber;
        }
    }
    if (triangeNumber.Length == 500)
    {
        first500Dividors = i;
        break;
    }
}
WriteLine(first500Dividors);