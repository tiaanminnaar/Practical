int prime10001 = 0;
int number = 0;
for (int j = 2; j < int.MaxValue; j++)
{
    bool prime = true;
    for (int i = 2; i < j; i++)
    {
        if (j % i == 0)
        {
            prime = false;
            break;
        }
    }
    if (prime)
    {
        number++;
    }
    if (number == 10001)
    {
        prime10001 = j;
        break;
    }
}

WriteLine(prime10001);

//int number = 1, prime = 1, divide;

//while (number < 10001)
//{
//    prime = prime + 2;
//    divide = 1;
//    while (true)
//    {
//        divide = divide + 2;
//        if (prime == divide)
//        {
//            number++;
//            break;
//        }

//        else if (prime % divide == 0 && prime != divide)
//        {
//            break;
//        }
//    }
//}

//Write(prime);
