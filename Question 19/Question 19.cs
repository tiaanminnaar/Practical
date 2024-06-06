int sunday = 0;

for (int year = 1901; year <= 2000; year++)
{
    bool checkForLeapYear = false;
    checkForLeapYear = CheckForLeapYear(year);
    if (checkForLeapYear == true)
    {
        int days = 0;
        for (int month = 1; month <= 12; month++)
        {
            if (month == (1 | 3 | 5 | 7 | 8 | 10 | 12))
            {
                days = 31;
            }
            if (month == 2)
            {
                days = 29;
            }
            if (month == (4 | 6 | 9 | 11))
            {
                days = 30;
            }
        }
    }
    for (int month = 1; month <= 12; month++)
    {

    }
}

WriteLine(sunday);
bool CheckForLeapYear(int year)
{
    bool checkForLeapYear = false;
    if (year % 4 == 0)
    {
        checkForLeapYear = true;
    }
    return checkForLeapYear;
}

int CheckDaysInMonth(int year, int month)
{

}