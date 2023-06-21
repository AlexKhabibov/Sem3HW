// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Palindrom (int number)
Console.WriteLine("Введите пятизначное число и узнайте является ли оно палиндромом или нет");
int number1 = number % 10;
int number2 = number % 100 / 10;
int number3 = number % 1000 / 10;
int number4 = number % 10000 / 10;
int number5 = number % 100000 / 10;
int numberResult = number1 * number2 * number3 * number4 * number5;

if (number > 9999 && number < 100000);
    Console.WriteLine("Число является палиндромом");
        if else 
        Console.WriteLine("Число НЕ является палиндромом");
else
    Console.WriteLine("Вы ввели НЕ пятизначное число, повторите ввод верно");

Palindrom (numberResult);