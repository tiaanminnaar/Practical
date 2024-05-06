//2) Prime number
//Write a c# program to check prime number.
//Input: 17
//Output: prime number
//Input: 57
//Output: not prime number

var n = int.Parse(ReadLine());
var prime = true;

for(int i = 2; i < n; i++)
{
    if(n % i == 0)
    {
        prime = false;
        break;
    } 
}
if (prime)
{
    WriteLine("Prime");
}
else
{
    WriteLine("Not prime");
}