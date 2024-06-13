using System.Numerics;

long first500Divisitors = 0;
long h = 0;
for (int i = 1; i < int.MaxValue; i++)
{
    h += i;
    int chain = 0;
    for (long j = 1; j < Math.Sqrt(h); j++)
    {
        if (h % 2 != 0)
        {
            break;
        }
        if (h % j == 0)
        {
            chain++;
            chain++;
        }
    }
    if (chain >= 500)
    {
        first500Divisitors = h;
        break;
    }
}

WriteLine(first500Divisitors);
//long div = 0;
//long n = 1;
//long S = 0;
//while (true)
//{
//    S = (n * (n + 1)) / 2;
//    for (long i = 1; i <= Math.Sqrt(S); i++)
//    {
//        if (S % i == 0)
//        {
//            div += 2;
//        }
//    }
//    if (div >= 500)
//    {
//        Write(S);
//        break;
//    }
//    n++;
//    div = 0;
//}