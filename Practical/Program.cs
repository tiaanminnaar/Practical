//1) Fibonacci Series
//Write a c# program to print fibonacci series without using recursion and using recursion.
//Input: 15
//Output: 0 1 1 2 3 5 8 13 21 34 55 89 144 233 377

WriteLine($"Enter the the range of the fibonacci series you would like to see");
var a = int.Parse(ReadLine());

int current = 0;
int prevous = 1;
int next;

for (int i = 0; i < a; i++)
{
    next = prevous + current;

    Write($"{current} ");

    prevous = current;
    current = next;
}