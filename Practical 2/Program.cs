//2) Prime number
//Write a c# program to check prime number.
//Input: 17
//Output: prime number
//Input: 57
//Output: not prime number

WriteLine("Enter the number you would like to see is a prime number.");
var num = int.Parse(ReadLine());
CheckPrimeNumber(num);

var n = int.Parse(ReadLine());
CheckPrimeNumber(n);

void CheckPrimeNumber(int n) 
{
    var prime = true;

    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            prime = false;
            break;
        }
    }
    if (prime)
    {
        WriteLine("Prime number");
    }
    else
    {
        WriteLine("Not prime number");
    }
}