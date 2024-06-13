int howManySunday = 0;
int sunday = 6;
for (int year = 1901; year <= 2000; year++)
{
    if (sunday > 7)
    {
        sunday = 1;
    }
    bool checkForLeapYear = false;
    checkForLeapYear = CheckForLeapYear(year);
    if (checkForLeapYear == false)
    {
        for (int days = 1; days <= 366; days++)
        {
            bool checkIfSunday = false;
            if ((days == 1) || (days == 32) || (days == 60) || (days == 91) || (days == 121) || (days == 152) || (days == 182) || (days == 213) || (days == 244) || (days == 274) || (days == 305) || (days == 335))
            {
                checkIfSunday = CheckIfSunday(sunday, days);
                if (checkIfSunday == true)
                {
                    howManySunday++;
                }
            }
        }
        sunday++;
    }
    if (checkForLeapYear == true)
    {
        for (int days = 1; days <= 366; days++)
        {
            bool checkIfSunday = false;
            if ((days == 1) || (days == 32) || (days == 61) || (days == 92) || (days == 122) || (days == 153) || (days == 183) || (days == 214) || (days == 245) || (days == 275) || (days == 306) || (days == 336))
            {
                checkIfSunday = CheckIfSunday(sunday, days);
                if (checkIfSunday == true)
                {
                    howManySunday++;
                }
            }
        }
        sunday++;
    }
}

WriteLine(howManySunday);
bool CheckForLeapYear(int year)
{
    bool checkForLeapYear = false;
    if (year % 4 == 0)
    {
        checkForLeapYear = true;
    }
    return checkForLeapYear;
}

bool CheckIfSunday(int sunday, int day)
{
    bool checkIfSunday = false;
    {
        day -= sunday;
        if (day % 7 == 0)
        {
            checkIfSunday = true;
        }
    }
    return checkIfSunday;
}