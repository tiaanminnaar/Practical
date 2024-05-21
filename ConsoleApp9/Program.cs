//9) Decimal to Binary
//Write a c# program to convert decimal number to binary.
//Input: 10
//Output: 1010

using System.ComponentModel;
using System.Text;

https://learn.microsoft.com/en-us/dotnet/api/system.bitconverter.doubletoint64bits?view=net-8.0

var n =int.Parse(ReadLine());

int ReverseInt(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result * 10 + num % 10;
        num /= 10;
    }
    return result;
}
string b = ($"{n:B64}");
int num1 = int.Parse(b);
var numrev = ReverseInt(num1);
var binary = ReverseInt(numrev);
int r = num1 % 10;
if(r == 0)
{
    binary = binary * 10;
}

WriteLine(binary);