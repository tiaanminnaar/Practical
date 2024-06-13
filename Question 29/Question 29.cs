using System.Numerics;
List<string> list2 = new List<string>();
List<string> list = new List<string>();
string num = string.Empty;
for (int i = 2; i <= 100; i++)
{
    for (int j = 2; j <= 100; j++)
    {

        num = CheckAllPowers(i, j);
        if (list.Contains(num) == true)
        {
            list2.Add(new string(num));
        }
        if (list.Contains(num) == false)
        {
            list.Add(new string(num));
        }
    }
}
int amount = 0;
int amount2 = 0;
foreach (string str in list)
{
    amount++;
}
foreach (string str in list2)
{
    amount2++;
}
WriteLine(amount2);
WriteLine(amount);

string CheckAllPowers(int x, int y)
{
    int powerOf = x;
    int count = 1; 
    BigInteger sum = x;
    while (count <= y)
    {
        sum *= powerOf;
        count++;
    }
    string sumStr = sum.ToString();
    return sumStr;
}