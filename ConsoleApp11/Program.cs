string num = string.Empty;

for (int i = 1; i <= 100; i++)
{
    num = $"{i}";
    if (i % 3 == 0)
    {
        num = "Fizz";
    }
    if (i % 5 == 0)
    {
        num = "Buzz";
    }
    if ((i % 3== 0) && (i % 5== 0))
    {
        num = "FizzBuzz";
    }
    WriteLine(num);
}