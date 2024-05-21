//5) Armstrong number
//Write a c# program to check armstrong number.
//Input: 371
//Output: armstrong
//Input: 342
//Output: not armstrong

//var num = int.Parse(ReadLine());

//string numstr = $"{num}";
//int last;
//double length = numstr.Length;

//for (int i = 1; i <= length; i++)
//{
//    double number = numstr[i];

//    var res = (int)Math.Pow(number, length);
//    WriteLine(res);
//}

WriteLine("Enter the number to see if it is an armstrong number ");
var n = int.Parse(ReadLine());
CheckArmstrongNumber(n);

var m = int.Parse(ReadLine());
CheckArmstrongNumber(m);

void CheckArmstrongNumber(int num)
{
    string numstr = $"{num}";
    int last;
    int sum = 0;
    int length = numstr.Length;
    int num1 = num;
    int num2 = num;
    int r;
    double b;

    while (num1 > 0)
    {
        last = num1 % 10;
        b = Math.Pow(last, length);
        r = (int)b;
        sum = sum + r;
        num1 = num1 / 10;
    }
    if (num2 == sum)
        Write("Armstrong Number.");
    else
        Write("Not Armstrong Number.");
}