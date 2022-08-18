Console.WriteLine("Введите номер дня недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());

bool Numberday(int day)
{
    if ( day == 6  || day == 7 )
    {
        return true;
    }
    else
    return false;
}
bool result = Numberday(dayNumber);

if ( result == true )
{
    Console.WriteLine("Этот день выходной");
}
else
Console.WriteLine("Этот день не выходной");


