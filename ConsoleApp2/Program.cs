//10) Alphabet Triangle
//Write a c# program to print alphabet triangle.
//Output:
//     A
//    ABA
//   ABCBA
//  ABCDCBA
// ABCDEDCBA

string prevousstr = null;
string ReversePrevousstr = null;

string Reverse(string text)
{
    char[] cArray = text.ToCharArray();
    string reverse = String.Empty;
    for (int i = cArray.Length - 1; i > -1; i--)
    {
        reverse += cArray[i];
    }
    return reverse;
}

for (int i = 65; i <= (90 - 21); i++)
{
    string strAlpha = "";

    for (int j = i; j <= (90 - 21); j++)
    {
        Write($" ");
    }
    strAlpha += ((char)i).ToString();
    WriteLine($"{prevousstr}{strAlpha}{ReversePrevousstr}");

    prevousstr = $"{prevousstr}{strAlpha}";

    ReversePrevousstr = Reverse(prevousstr);
}

//public void GetAlphabets()
//{
//    //Declare string for alphabet
//    string strAlpha = "";

//    //Loop through the ASCII characters 65 to 90
//    for (int i = ; i <= ; i++)
//    {
//        // Convert the int to a char to get the actual character behind the ASCII code
//        strAlpha += ((char)i).ToString() + " ";
//    }

//    //Displaying alphabets
//    Response.Write(strAlpha);
//}