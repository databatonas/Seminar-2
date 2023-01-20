﻿// Задача 13
/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
   что третьей цифры нет. Счет цифр ведется слева направо*/

Console.WriteLine("Введите число . При введении дробного числа используйте запятую");

double a = Convert.ToDouble(Console.ReadLine());/*double- дает возможность
                                                   вводить дробные числа*/

 //Первый блок
 if (a == 0)/*Если число(а) равно нулю, то...*/
 {
     Console.WriteLine("Данное число равно нулю и  не может содержать третью цифру.");//Ответ
 }

 //Второй блок
 if (a < 0)//*Если ввели отрицательное число, то...

 {
     a = a * -1;/*Умножим это число на минус один, чтобы сделать 
                   его положительным*/
 }

// Третий блок
if (a > 0 && a < 0.01)/*Если (а) больше нуля и меньше 0,01, то...*/
{
    Console.WriteLine("Третья цифра" + " " + 0);
}

// Четвёртый блок
if (a >= 0.01 && a < 10)/*Если (а) больше 0,01 и меньше 10, то ...*/
{
    a = a * 100;/*умножаем его на 100 (чтобы целая часть, как минимум, составляла три цифры)*/
    int b = (int)a;/*Вводим переменную (в) и присваеваем ей только целую часть числа (а)*/

    if (b % 10 == 0)/*Ели остаток от деления числа(в) на 10 равен нулю, то...*/
    {
        Console.WriteLine("Данное число не содержит третьей цифры.");
        return;/* Возврат значения для того, чтобы не выводились в консоль
                  несколько ответов сразу, если функции где-то пересекаются*/
    }

    b = b % 10;/*Присваиваем переменной (в) остаток от деления числа(в) на 10*/
    Console.WriteLine("Третья цифра" + " " + b);//Ответ
    return;/* Возврат значения для того, чтобы не выводились в консоль
              несколько ответов сразу, если функции где-то пересекаются*/
}

// Пятый блок
if (a >= 10 && a < 100)/*Если (а) больше или равно 10 и меньше ста, то...*/
{
    a = a * 10;/*переменную (а) кмножаем на 10 (чтобы целая часть, 
                 как минимум, составляла три цифры)*/
    int c = (int)a;/*Вводим переменную (с) и присваеваем ей только 
                     целую часть числа (а)*/

    if (c % 10 == 0)/*Ели остаток от деления числа(с) на 10 равен нулю, то...*/
    {
        Console.WriteLine("Данное число не содержит третьей цифры.");
        return;/* Возврат значения для того, чтобы не выводились в консоль
                  несколько ответов сразу, если функции где-то пересекаются*/
    }
    c = c % 10;/*Присваиваем переменной (с) остаток от деления числа(с) на 10*/
    Console.WriteLine("Третья цифра" + " " + c);//Ответ
}

// Шестой блок
while (a >= 1000)/*До тех пор, пока число (а) больше или равно тысячи...*/
{
    a = a / 10;//число (а) делим на 10
}

if (a >= 100 && a < 1000)/*Если число (а) больше 110 и меньше 1000, то...*/
{
    int d = (int)a;/*Переменной (d) присваиваем целую часть числа (а)*/
    d = d % 10;/*Переменной (d) присваиваем значение остатка 
                     от деления числа на 10 */

    /* В ответ пойдет текст (в кавычках). + -это для склейки строки. 
       Кавычки с пробелом внутри-это пробел между текстом 
       и значением переменной (b)*/
    Console.WriteLine("Третья цифра" + " " + d);
}




/*Вариант решения строковый*/
// Console.WriteLine("Введите число . При введении дробного числа используйте запятую");
// string? text = Console.ReadLine();/*string?-строчный обнуляемый тип данных*/

// #nullable disable //Все проверки на обнуляемость и предупреждения отключены.
// //Если символ не введен, то ошибки не будет

// text = text.Replace("-", "");//Удаляем из текста все знаки (-)
// text = text.Replace(",", "");//Удаляем из текста все знаки (,)

// if (text.Length < 3)/*Если длина массива (количество цифр) меньше трех, то...*/
// {
//     Console.WriteLine("Данное число не содержит третью цифру.");
//     return;/*Возврат ответа, чтобы данные не распространялись на следующее действие.
//              Иначе кроме этого ответа будет,еще, и оибка*/
// }
// Console.WriteLine(text[2]);//Ответ