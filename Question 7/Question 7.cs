string primeStr = string.Empty;
string primeArray = string.Empty;
string prime10001 = string.Empty;

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
        primeStr = Convert.ToString(j);
    }
}
prime10001 = Convert.ToString(primeArray[10001]);


WriteLine(prime10001);