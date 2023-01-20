// Задача 16
/* Напишите программу, которая принимает на вход два числа и проверяет, 
   является ли одно число квадратом другого*/


Console.WriteLine("Введите первое число (используйте запятую при введении дробного числа)");
Console.ForegroundColor = ConsoleColor.Blue;/*Вывод в консоль синим цветом*/
double a = Convert.ToDouble(Console.ReadLine());/*Возможность вывода дробного числа*/
Console.ForegroundColor = ConsoleColor.White;/*Вывод в консоль синим цветом*/
Console.WriteLine("Введите второе число (используйте запятую при введении дробного числа)");
Console.ForegroundColor = ConsoleColor.Green;/*Вывод в консоль зелёным цветом*/
double b = Convert.ToDouble(Console.ReadLine());/*Возможность вывода дробного числа*/

if (a == b * b || b == a * a)/* если (а) является квадратом(b) или 
                                (b) является квадратом (а), то ...*/
{
    Console.WriteLine("Одно число является квадратом другого числа");
}

else // иначе...
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
}
