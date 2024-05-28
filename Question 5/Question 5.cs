int smallestNum = 0;
bool isSmallestNum = false;

for (int m = 2520; m < int.MaxValue; m++)
{
    isSmallestNum = IsEvenlyDivisibleByFactorOf20(m);
    if (isSmallestNum == true)
    {
        smallestNum = m;
        break;
    }
}
WriteLine(smallestNum);

bool IsEvenlyDivisibleByFactorOf20(int k)
{
    bool isEvenlyDivisibleByFactorOf20 = false;

    for (int i = 1; i <= 20; i++)
    {
        if (k % i == 0)
        {
            isEvenlyDivisibleByFactorOf20 = true;
        }
        else
        {
            isEvenlyDivisibleByFactorOf20 = false;
            break;
        }
    }
    if (isEvenlyDivisibleByFactorOf20 == true)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//bool noRemainder = false;
//int counter = 0;

//while (!noRemainder)
//{
//    counter++;

//    for (int i = 1; i <= 20; i++)
//    {
//        if(counter % i == 0) 
//            noRemainder = true;
//        else
//        {
//            noRemainder = false;
//            break;
//        }
//    }
//}

//Write(counter);

