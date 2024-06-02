string toPowerOf1000 = PowerOf1000("2");
int sumOfDigitsOfPowerOf1000 = SumOfDigits(toPowerOf1000);

int SumOfDigits(string n)
{
    int sum = 0;
    for (int i = 0; i <= (n.Length - 1); i++)
    {
        int m = int.Parse(n[i].ToString());
        sum += m;
    }
    return sum;
}
string PowerOf1000(string n)
{
    int powerOf = int.Parse(n);
    int count = 1;
    string sumStr = string.Empty;
    while (count <= 999)
    {
        string prevSum = string.Empty;
        int p = 0;
        string m = Convert.ToString(new string(n.ToString().Reverse().ToArray()));
        for (int i = 0; i <= (m.Length - 1); i++)
        {
            int y = int.Parse(m[i].ToString());
            int sum = 0;
            int r;
            int q = p;
            p = 0;
            
            r = y * powerOf;
            if (r >= 10)
            {
                if (i != (m.Length - 1))
                {
                    p = r % 10;
                    r /= 10;
                    int o = r;
                    r = p;
                    p = o;
                }
            }
            sum += r + q;
            sumStr = $"{sum}";
            n = $"{sumStr}{prevSum}";
            prevSum = n;
        }
        count++;
    }
    return n;
}

WriteLine(sumOfDigitsOfPowerOf1000);