﻿/*Напишите программу, которая принимает на вход цифру, 
  и проверяет, является ли этот день выходным.*/
Console.WriteLine("Введите цифру от 1 до 7, сответствующую дням недели:");
Console.WriteLine("понедельник-1, вторник-2 и т.д.");
Console.WriteLine("Суббота и воскресенье являются выходными днями");

int figure = Convert.ToInt32(Console.ReadLine());/*Присваиваем переменной figure 
                                                   только целочисленные значения 
                                                   и выводим их на экран.*/

if (figure < 1 || figure > 7)/*Если введенная цифра меньше 1 или больше 7, то...*/
{
    Console.WriteLine("Вы ввели некорректную цифру");
    return;/*Возвращаемое значение, так как ответ может 
         пересекаться с диапозоном следующего условия*/
}

if (figure == 6 || figure == 7)/*Если введенная цифра равна 6 или 7, то...*/
{
    Console.WriteLine("Это выходной день");
}

else
{
    Console.WriteLine("Этот день не является выходным");
}
