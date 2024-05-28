//int prime = 1;
//long primeFactorSum = 600851475143;
//int primeDevide = 1;
//long primeFactor = 1;

//while (primeFactor < primeFactorSum)
//{
//    for (int i = 2; i < primeFactorSum; i++)
//    {
//        for (int j = 2; j <= i; j++)
//        {
//            if (i % j == 0)
//            {
//                prime = i;
//            }
//        }
//        primeFactor = primeFactor * prime;
//        if (primeFactor > primeFactorSum)
//        {
//            for (int k = 2; k < primeFactorSum; k++)
//            {
//                for (int n = 2; n <= k; n++)
//                {
//                    if (k % n == 0)
//                    {
//                        primeDevide = k;
//                    }
//                }
//            }
//            primeFactor = primeFactor / primeDevide;
//        }
//    }
//}

//WriteLine(prime);

Int64 n = 600851475143;

while (n % 2 == 0)
{
    n /= 2;
}

for (int i = 3; i <= Math.Sqrt(n); i += 2)
{
    while (n % i == 0)
    {
        n /= i;
    }
}
if (n > 2)
    Write(n);