﻿// Задача 11
/* Напишите программу, которая выводит случайное трехзначное 
   число и удаляет вторую цифру этого числа*/

int N = new Random().Next(100,1000);   /* я хочу новое случайное целое числов диапозоне от 100 до 999. 
                                       по правилам 100 будет включено в диапазон,а 1000 не будет включено. */

Console.WriteLine(N);                  /* выводим на экран, случайно выбранное компьютером, трёхзначное число.*/


int first = N / 100;                   /* определяем первую цифру трёхзначного числа.*/
int second = N % 10;                   /* определяем последнюю цифру трёхзначного числа.*/

Console.WriteLine(first + "" + second);/*Это строчный вариант ответа. В ответе склеиваем строки и 
                                         ставим между ними пробел*/
Console.WriteLine(first *10 + second); /*Это математический вариант ответа. Первую цифру умножаем на (10)- 
                                         этим получаем десятки и прибавляем последнюю цифру.*/