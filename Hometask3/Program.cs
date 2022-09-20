/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
string[] CreateWeekArray()
{
  string[] result = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
  return result;
}

void IsWeekend ()
{
    string[] newWeek=CreateWeekArray();
    Console.WriteLine("Введите номер дня недели (1- пн, 2- вт, 3- ср, 4- чт, 5-пт, 6-сб, 7-вс): ");
    int dayNumber = int.Parse(Console.ReadLine());
    if ((dayNumber>7) || (dayNumber<1))
    Console.WriteLine("Придерживайтесь заданных числовых рамок!");
    else if ((dayNumber==6)||(dayNumber==7))
        Console.WriteLine($"{newWeek[dayNumber-1]} - это Выходной");
        else
        Console.WriteLine($"{newWeek[dayNumber-1]} - это Рабочий день");
}

IsWeekend();

