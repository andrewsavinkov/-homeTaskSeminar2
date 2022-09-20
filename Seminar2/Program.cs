/* https://learn.microsoft.com/ru-ru/dotnet/csharp/
ссылка на доп. материалы по С# */ 
/* Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/

/* int GetRandomNumber (int leftRange, int rightRange)
{
    Random rnd = new Random();
    int result = rnd.Next(leftRange, rightRange);
    return result;
}

int GetMaxDigitOfNumber (int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    
    if (firstDigit > secondDigit)
        return firstDigit;
    else
        return secondDigit; 
}

int number = GetRandomNumber(10, 100);
Console.WriteLine($"Рандомное число: {number}");
int GetMaxDigitOfNumber(number);
Console.WriteLine($"Наибольшая цифра: {number}");
*/

/*int GetRandomNumber(int leftRange, int rightRange)
{
    Random rnd = new Random();
    int result = rnd.Next(leftRange, rightRange);// [leftRange, rightRange)
    return result;
}

int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if(firstDigit > secondDigit)
        return firstDigit;
    else
        return secondDigit;
}

int number = GetRandomNumber(10,100);
Console.WriteLine($"Рандомное число: {number}");

int maxDigit = GetMaxDigitOfNumber(number);
Console.WriteLine($"Максимальная цифра: {maxDigit}");
*/

/*Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
/*
int GenerateRandomNum (int leftRange, int rightRange)
{
    Random rnd = new Random();
    int result = rnd.Next(leftRange, rightRange);
    return result;
}

int DeleteSecondDigit(int number)
{
 int result = int.Parse((number.ToString)[1] + (number.ToString)[3]);
 return result;   
}

int numberOfDigits = GenerateRandomNum(100, 1000);
Console.WriteLine(numberOfDigits);
int final = DeleteSecondDigit(numberOfDigits);
Console.WriteLine(final);
*/
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
/* right one
int GetRandomNumber(int leftRange, int rightRange) // [100-1000)
{
    Random rnd = new Random();
    int result = rnd.Next(leftRange, rightRange); // [leftRange,rightRange)
    return result;
}

int DeleteSecondDigit(int number)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;

    return firstDigit*10 + thirdDigit;
}

int number = GetRandomNumber(100,1000);
Console.WriteLine(number);

int twoDigits = DeleteSecondDigit(number);
Console.WriteLine(twoDigits);
*/
/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/



/*Console.WriteLine("Напишите первое число: ");
int numOne = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число: ");
int numTwo = int.Parse(Console.ReadLine());
if (numTwo%numTwo == 0)
    Console.WriteLine("кратно");
else
    Console.WriteLine("не кратно");
*/
/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/
/*Console.WriteLine("Напишите число: ");
int numOne = int.Parse(Console.ReadLine());
if ((numOne % 7 ==0) & (numOne % 23 == 0))
Console.WriteLine("кратно");
else
Console.WriteLine("некратно");
*/
/* генератор случайного числа с заданным кол-вом цифр 
int GenerateNumber (int digits)
{
Random rnd = new Random();
int result = rnd.Next(Convert.ToInt32(Math.Pow(10, digits-1)), Convert.ToInt32(Math.Pow(10, digits)));
return result;
}
int number = GenerateNumber(4);
Console.WriteLine(number);
*/

/* генератор числа
int GetNumber()   // создали функцию
{
    Console.WriteLine("Введите число");
    string numberStr = Console.ReadLine();
    int number = int.Parse(numberStr);
    return number;
}
*/

/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/
/*
int GetNumbers()   // создали функцию
{
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}
int numberOne = GetNumbers();
int numberTwo = GetNumbers();
if (numberTwo/numberOne == numberOne)
Console.WriteLine($"{numberTwo} является квадратом {numberOne}");
else
Console.WriteLine($"{numberTwo} не является квадратом {numberOne}");
*/

/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int GenerateNumber (int digits)
{
Random rnd = new Random();
int result = rnd.Next(Convert.ToInt32(Math.Pow(10, digits-1)), Convert.ToInt32(Math.Pow(10, digits)));
return result;
}

int GetSecondDigit (int value)
{
 int result = ((value % 100)-(value % 10))/10;
 return result; 
}

int number = GenerateNumber(3);
Console.WriteLine(number);
int secondDigit = GetSecondDigit(number);
Console.WriteLine(secondDigit);