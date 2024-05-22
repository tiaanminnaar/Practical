//5) Armstrong number
//Write a c# program to check armstrong number.
//Input: 371
//Output: armstrong
//Input: 342
//Output: not armstrong

string armstrong = ReadLine();
CheckArmstrongNumber(armstrong);
void CheckArmstrongNumber(string n)
{
    string numstr = n;
    numstr.ToString().ToArray();
    double length = numstr.Length;
    int num = int.Parse(numstr);
    int res = 0;
    int sum = 0;

    for (int i = 0; i <= length - 1; i++)
    {
        double number = int.Parse(numstr[i].ToString());
        res = (int)Math.Pow(number, length);
        sum = sum + res;
    }
    if (sum == num)
        Write("Armstrong Number.");
    else
        Write("Not Armstrong Number.");
}


//WriteLine("Enter the number to see if it is an armstrong number ");
//var n = int.Parse(ReadLine());
//CheckArmstrongNumber(n);

//var m = int.Parse(ReadLine());
//CheckArmstrongNumber(m);

//void CheckArmstrongNumber(int num)
//{
//    string numstr = $"{num}";
//    int last;
//    int sum = 0;
//    int length = numstr.Length;
//    int num1 = num;
//    int num2 = num;
//    int r;
//    double b;

//    while (num1 > 0)
//    {
//        last = num1 % 10;
//        b = Math.Pow(last, length);
//        r = (int)b;
//        sum = sum + r;
//        num1 = num1 / 10;
//    }
//    if (num2 == sum)
//        Write("Armstrong Number.");
//    else
//        Write("Not Armstrong Number.");
//}