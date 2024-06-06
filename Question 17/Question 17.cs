string totalNumStr = string.Empty;
string combinedNumStr = string.Empty;
int sum = 0;
for (int i = 1; i <= 1000; i++)
{
    string prevCombinedNumStr = totalNumStr;
    combinedNumStr = string.Empty;
    string numStr = string.Empty;
    int num;
    int num1 = 0;
    string prevNumStr = string.Empty;
    string s = $"{i}";
    for (int j = 0; j <= s.Length - 1; j++)
    {
        prevNumStr = combinedNumStr;
        combinedNumStr = string.Empty;
        num = int.Parse(s[j].ToString());
        num = num1 + num;
        if (j == (s.Length - 1))
        {
            switch (num)
            {
                case 0:
                    numStr = string.Empty;
                    break;
                case 1:
                    numStr = "One";
                    break;
                case 2:
                    numStr = "Two";
                    break;
                case 3:
                    numStr = "Three";
                    break;
                case 4:
                    numStr = "Four";
                    break;
                case 5:
                    numStr = "Five";
                    break;
                case 6:
                    numStr = "Six";
                    break;
                case 7:
                    numStr = "Seven";
                    break;
                case 8:
                    numStr = "Eight";
                    break;
                case 9:
                    numStr = "Nine";
                    break;
                case 10:
                    numStr = "Ten";
                    break;
                case 11:
                    numStr = "Eleven";
                    break;
                case 12:
                    numStr = "Twelve";
                    break;
                case 13:
                    numStr = "Thirteen";
                    break;
                case 14:
                    numStr = "Fourteen";
                    break;
                case 15:
                    numStr = "Fifteen";
                    break;
                case 16:
                    numStr = "Sixteen";
                    break;
                case 17:
                    numStr = "Seventeen";
                    break;
                case 18:
                    numStr = "Eighteen";
                    break;
                case 19:
                    numStr = "Nineteen";
                    break;
            }
        }
        if (j == (s.Length - 2))
        {
            switch (num)
            {
                case 0:
                    numStr = string.Empty;
                    break;
                case 1:
                    num1 = num * 10;
                    numStr = string.Empty;
                    break;
                case 2:
                    numStr = "Twenty";
                    break;
                case 3:
                    numStr = "Thirty";
                    break;
                case 4:
                    numStr = "Forty";
                    break;
                case 5:
                    numStr = "Fifty";
                    break;
                case 6:
                    numStr = "Sixty";
                    break;
                case 7:
                    numStr = "Seventy";
                    break;
                case 8:
                    numStr = "Eighty";
                    break;
                case 9:
                    numStr = "Ninety";
                    break;
            }

        }
        if (j == (s.Length - 3))
        {
            switch (num)
            {
                case 0:
                    numStr = string.Empty;
                    break;
                case 1:
                    numStr = "Onehundredand";
                    break;
                case 2:
                    numStr = "Twohundredand";
                    break;
                case 3:
                    numStr = "Threehundredand";
                    break;
                case 4:
                    numStr = "Fourhundredand";
                    break;
                case 5:
                    numStr = "Fivehundredand";
                    break;
                case 6:
                    numStr = "Sixhundredand";
                    break;
                case 7:
                    numStr = "Sevenhundredand";
                    break;
                case 8:
                    numStr = "Eighthundredand";
                    break;
                case 9:
                    numStr = "Ninehundredand";
                    break;
            }
        }
        if (j == (s.Length - 4))
        {
            switch (num)
            {
                case 1:
                    numStr = "Onethousand";
                    break;
            }
        }
        combinedNumStr = $"{prevNumStr}{numStr}";
    }
    sum += combinedNumStr.Length;
    totalNumStr = $"{prevCombinedNumStr}{combinedNumStr}";
    WriteLine($"{combinedNumStr} {sum}");
}

int totalLetters = totalNumStr.Length - (3 * 9);

WriteLine(totalLetters);