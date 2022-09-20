/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int GenerateNumber (int digits) // функция-генератор случайного числа с заданным количеством цифр
{
Random rnd = new Random();
int result = rnd.Next(Convert.ToInt32(Math.Pow(10, digits-1)), Convert.ToInt32(Math.Pow(10, digits)));
return result;
}

int GetSecondDigit (int value) // функция, извлекающая вторую цифру трехзначного числа в формате int
{
 int result = ((value % 100)-(value % 10))/10;
 return result; 
}

int number = GenerateNumber(3); // генерируем псевдослучайное трехзначное число
Console.WriteLine(number);
int secondDigit = GetSecondDigit(number); // извлекаем вторую цифру сгенерированного числа в формате int
Console.WriteLine(secondDigit);
