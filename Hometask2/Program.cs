/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/ 

int GenerateNumber (int digits) // функция-генератор случайного числа с заданным количеством цифр
{
Random rnd = new Random();
int result = rnd.Next(Convert.ToInt32(Math.Pow(10, digits-1)), Convert.ToInt32(Math.Pow(10, digits)));
return result;
}

int GetThirdDigit (int value) // функция, извлекающая третью цифру числа в формате int
{
string mediatorVariable = value.ToString(); 
int len = mediatorVariable.Count(); // вспомогательная переменная, определяющая количество знаков в числе
if (len<3)
{
    Console.WriteLine("Третья цифра отсутствует!");
    int result = -1;
    return result;
} else 
{
    double thirdDig = (value%(Math.Pow(10, len-2))-value%(Math.Pow(10, len-3)))/Math.Pow(10, len-3); 
    // переменная типа double, поскольку Math.Pow() возвращает double
    int result = Convert.ToInt32(thirdDig);
    Console.WriteLine("Третья цифра: ");
    return result;
}
}

int number = GenerateNumber(3);
Console.WriteLine(number);
int digit = GetThirdDigit(number);
Console.WriteLine(digit);