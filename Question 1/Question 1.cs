int M3OR5 = int.Parse(CheckSumOfMultiplesOf3Or5(1));
WriteLine(M3OR5);

string CheckSumOfMultiplesOf3Or5(int min)
{
    int max = 1000;
    int multiOf3;
    int sumOf3 = 0;
    int multiOf5;
    int sumOf5 = 0;
    string sumOfMultiOf3Or5 = null;

    for (int i = min; i < max; i++)
    {
        if (i % 3 == 0)
        {
            if (i % 5 == 0)
            {
                int dump = i;
            }
            else
            {
                multiOf3 = i;
                sumOf3 = sumOf3 + multiOf3;
            }

        }
        if (i % 5 == 0)
        {
            multiOf5 = i;
            sumOf5 = sumOf5 + multiOf5;
        }
        sumOfMultiOf3Or5 = $"{sumOf3 + sumOf5}";
    }
    return sumOfMultiOf3Or5;
}