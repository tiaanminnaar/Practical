ulong posabilities = GridPosabilities(20,20);

ulong GridPosabilities(ulong x, ulong y)
{
    ulong topFactoral = Factoral((x + y));
    ulong xBottomFactoral = Factoral(x);
    ulong yBottomFactoral = Factoral(y);
    ulong bottomFactoral = xBottomFactoral * yBottomFactoral;
    ulong gridPosabilities = topFactoral / bottomFactoral;
    return gridPosabilities;
}

ulong Factoral(ulong x)
{
    ulong factoral = 1;
    for (ulong i = x; i >= 2; i--)
    {
        factoral *= i;
    }
    return factoral;
}

WriteLine(posabilities);