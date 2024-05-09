//13) Number in Characters
//Write a c# program to convert number in characters.
//Input: 357546
//Output: three five seven five four six

var num = int.Parse(ReadLine());

Dictionary<int, string> lookupIntString = new();

lookupIntString.Add(1, "one");
lookupIntString.Add(2, "two");
lookupIntString.Add(3, "three");
lookupIntString.Add(4, "four");
lookupIntString.Add(5, "five");
lookupIntString.Add(6, "six");
lookupIntString.Add(7, "seven");
lookupIntString.Add(8, "eight");
lookupIntString.Add(9, "nine");
lookupIntString.Add(0, "zero");

//int[] num1 = new int [num.Length] {num};
