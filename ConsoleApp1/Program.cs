//4) Factorial
//Write a c# program to print factorial of a number.
//Input: 6
//Output: 720

WriteLine("Enter the number of witch you would like to see the factoral of.");
var Frac = int.Parse(ReadLine());

int Fracres = 1;

for (int i = 1; i <= Frac; i++)
{
    Fracres = Fracres * i;
}

WriteLine($"{Fracres}");
