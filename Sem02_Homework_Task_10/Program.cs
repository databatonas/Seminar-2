﻿// Задача 10
/* Напишите программу, которая на вход принимает трёхзначное число
   и на выходе показывает вторую цифру этого числа*/

Console.WriteLine("Введите трёхзначное число.");

double c = Convert.ToDouble(Console.ReadLine());/* Вывод в консоль вводимого числа. Возможно дробного.*/

//Первый блок
if (c == 0)/*Если число(с) равно нулю, то...*/
{
    Console.WriteLine("Данное число равно нулю и  не может содержать третью цифру.");//Ответ
}

//Второй блок
if (c < 0)//*Если ввели отрицательное число, то...

{
    c = c * -1;/*Умножим это число на минус один, чтобы сделать 
                   его положительным*/
}

// Третий блок

/*Если число больше или равно 1000, то...*/
if (c >= 1000) Console.WriteLine("Вы ввели некорректное число. Оно содержит более трех цифр");

// Четвертый блок
if (c > 0 && c < 0.1)/*Если (с) больше нуля и меньше 0,1, то...*/
{
    double a = c * 1000 % 10;/*В данном промежутке целое число составляет одну цифру. 
                               Для того, чтобы проверить число на наличие четвертой цифры,
                               присвоим переменной (а) значение от деления с остатком
                               на 10 от переменной (с), умноженной на 1000*/

    if (a > 0)//Если (а) больше нуля, то...
    {
        Console.WriteLine("Вы ввели некорректное число. Оно содержит более трех цифр");
    }

    else//Иначе...
    {
        Console.WriteLine("Вторая цифра" + " " + 0);/*так как в данном промежутке
                                                      вторая цифра всегда равна нулю*/
        return;
    }
}

// Пятый блок
if (c >= 0.1 && c < 1)/*Если (с) больше или равно 0,1 и меньше 1, то ...*/
{
    double a = c * 100 % 10;/*В данном промежутке целое число составляет одну цифру. 
                               Для того, чтобы проверить число на наличие третьей цифры,
                               присвоим переменной (a) значение от деления с остатком
                               на 10 от переменной (с), умноженной на 100*/

    if (a == 0)/*Если (а) равно нулю, то...*/
    {
        Console.WriteLine("Вы ввели некорректное число. Оно не трёхзначное");
        return;
    }

    else//Иначе...
    {
        a = c * 1000 % 10;/*В данном промежутке целое число составляет одну цифру. 
                          Для того, чтобы проверить число на наличие четвертой цифры,
                          присвоим переменной (a) значение от деления с остатком
                          на 10 от переменной (c), умноженной на 1000*/
    }

    if (a > 0)//Если (а) больше нуля, то...
    {
        Console.WriteLine("Вы ввели некорректное число. Оно содержит более трех цифр");
        return;/* Возврат значения для того, чтобы не выводились в консоль
                  несколько ответов сразу, если функции где-то пересекаются*/
    }

    /*Если введенное число проверено по всем условиям и не попадает под них, то...*/

    c = c * 10;/*умножаем его на 10 (чтобы целая часть, как минимум, составляла одну цифру)*/
    int b = (int)c;/*Вводим переменную (b) и присваеваем ей только целую часть числа (с)*/

    Console.WriteLine("Вторая цифра" + " " + b % 10);//Ответ-остаток от деления числа(b) на 10*/
    return;/* Возврат значения для того, чтобы не выводились в консоль
              несколько ответов сразу, если функции где-то пересекаются*/
}

//Шестой блок
/*Следующее условие сделано потому, что программа, почему-то не принимает к обработке число 1,1*/
if (c == 1.1)
{
    Console.WriteLine("Вы ввели некорректное число. Оно не трёхзначное");
    return;/* Возврат значения для того, чтобы не выводились в консоль
              несколько ответов сразу, если функции где-то пересекаются*/
}

if (c >= 1 && c < 10)/*Если (с) больше или равно 1 и меньше 10, то...*/
{
    double a = c * 100 % 10;/*В данном промежутке целое число составляет одну цифру. 
                               Для того, чтобы проверить число на наличие третьей цифры,
                               присвоим переменной (a) значение от деления с остатком
                               на 10 от переменной (с), умноженной на 100*/

    if (a == 0)/*Если (а) равно нулю, то...*/
    {
        Console.WriteLine("Вы ввели некорректное число. Оно не трёхзначное");
        return;
    }

    else//Иначе..
    {
        a = c * 1000 % 10;/*В данном промежутке целое число составляет одну цифру. 
                            Для того, чтобы проверить число на наличие четвертой цифры,
                            присвоим переменной (a) значение от деления с остатком
                            на 10 от переменной (c), умноженной на 1000*/
    }

    if (a > 0)//Если (a) больше нуля, то...    
    {
        Console.WriteLine("Вы ввели некорректное число. Оно содержит более трех цифр");
        return;/* Возврат значения для того, чтобы не выводились в консоль
              несколько ответов сразу, если функции где-то пересекаются*/
    }

    /*Если введенное число проверено по всем условиям и не попадает под них, то...*/


    c = c * 10;/*переменную (c) умножаем на 10 (чтобы целая часть, 
             как минимум, составляла две цифры)*/

    int d = (int)c;/*Вводим переменную (d) и присваеваем ей только 
                     целую часть числа (c)*/

    Console.WriteLine("Вторая цифра" + " " + d % 10);/*Ответ-остаток от деления числа(d) на 10*/
    return;/* Возврат значения для того, чтобы не выводились в консоль
              несколько ответов сразу, если функции где-то пересекаются*/
}
//Седьмой блок
if (c >= 10 && c < 100)
{
    double a = c * 10 % 10;/*В данном промежутке целое число составляет две цифры. 
                             Для того, чтобы проверить число на наличие третьей цифры,
                             присвоим переменной (a) значение от деления с остатком
                             на 10 от переменной (с), умноженной на 10*/

    if (a == 0)//Если (a) равно нулю, то...
    {
        Console.WriteLine("Вы ввели некорректное число. Оно не трёхзначное");
        return;
    }

    else//Иначе...
    {
        double b = c * 100 % 10;/*В данном промежутке число составляет, как минимум, две цифры. 
                                  Для того, чтобы проверить число на наличие четвертой цифры,
                                  присвоим переменной (b) значение от деления с остатком
                                  на 10 от переменной (с, умноженной на 100*/

        if (b > 0)//Если (b) больше нуля, то...
        {
            Console.WriteLine("Вы ввели некорректное число. Оно содержит более трех цифр");
            return;/* Возврат значения для того, чтобы не выводились в консоль
                      несколько ответов сразу, если функции где-то пересекаются*/
        }
    }

    /*Если введенное число проверено по всем условиям и не попадает под них, то...*/

    int d = (int)c;/*Вводим переменную (d) и присваеваем ей только 
                     целую часть числа (c)*/

    Console.WriteLine("Вторая цифра" + " " + d % 10);/*Ответ-остаток от деления числа(d) на 10*/
    return;/* Возврат значения для того, чтобы не выводились в консоль
              несколько ответов сразу, если функции где-то пересекаются*/
}

// Восьмой блок
if (c >= 100 && c < 1000)/*Если число (c) больше или равно 100 и меньше 1000, то...*/
{
    double a = c * 10 % 10;/*В данном промежутке число составляет, как минимум, три цифры. 
                          Для того, чтобы проверить число на наличие четвертой цифры,
                          присвоим переменной (а) значение от деления с остатком
                          на 10 от переменной (с), умноженной на 10*/

    if (a > 0)//Если (а) больше нуля, то...
    {
        Console.WriteLine("Вы ввели некорректное число. Оно содержит более трех цифр");
        return;/* Возврат значения для того, чтобы не выводились в консоль
                  несколько ответов сразу, если функции где-то пересекаются*/
    }

    /*Если введенное число проверено по всем условиям и не попадает под них, то...*/

    c = c / 10;//Разделим число на 10, чтобы в целой части осталось только две цифры

    int b = (int)c;/*Переменной (b) присваиваем целую часть числа (c)*/

    Console.WriteLine("Вторая цифра" + " " + b % 10);/*Ответ-остаток от деления числа(b) на 10*/
    return;/* Возврат значения для того, чтобы не выводились в консоль
              несколько ответов сразу, если функции где-то пересекаются*/
}

