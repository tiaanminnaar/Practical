//5) Armstrong number
//Write a c# program to check armstrong number.
//Input: 371
//Output: armstrong
//Input: 342
//Output: not armstrong

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

var number = ReadLine();

var Strongarm = number.Length;

for (int i = 0; i < Strongarm; i++)
{
    var res = Math.Pow(number[i], Strongarm) ;
     
    WriteLine(res);
}
