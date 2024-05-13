//5) Armstrong number
//Write a c# program to check armstrong number.
//Input: 371
//Output: armstrong
//Input: 342
//Output: not armstrong

//var num = ReadLine();

//double power = num.Length;
//var num1 = int.Parse(num);
//int[] num2 = new int [num.Length] {num1};

//for (int i = 0; i <= power; i++)
//{
//    double number = num2[i];

//    var res = (long)Math.Pow(number, power);
//    WriteLine(res);
//}

Write("Enter the number to see if it is an armstrong number ");

var num = ReadLine();

int last;
int sum = 0;
int length = num.Length;
int num1 = int.Parse(num);
int num2 = int.Parse(num);
int r;
double b;


while (num1 > 0)
{
    last = num1 % 10;
    b = Math.Pow(last, length);
    r = (int) b;
    sum = sum + r;
    num1 = num1 / 10;
}
if (num2 == sum)
    Write("Armstrong Number.");
else
    Write("Not Armstrong Number.");      
        