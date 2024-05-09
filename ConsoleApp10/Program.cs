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

Write("Enter the number to see if it is an armstrong number");

var n = int.Parse(ReadLine());

int r;
int sum = 0;
int temp;
temp = n;

while (n > 0)
{
    r = n % 10;
    sum = sum + (r * r * r);
    n = n / 10;
}
if (temp == sum)
    Write("Armstrong Number.");
else
    Write("Not Armstrong Number.");      
        