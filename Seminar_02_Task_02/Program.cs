/*Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого 
  числа в степень, равную третьей цифре.
Примеры
487 => 8^7 = 2 097 152
254 => 5^4 = 625
617 => 1*/

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());/* number- число целого типа, которое будет 
                                                    вводиться пользователем.*/
if(number > 99 && number < 1000)
{
int first = number / 100;
int second = (number /10) % 10;
int third = number % 10;
int powered = (int)Math.Pow(second,third);
Console.WriteLine($"Вторая цифра числа- {second} в степени третьей цифры числа- {third} равна: {powered}");
}
else Console.WriteLine("Вы ввели не трёхзначное число. Введите число заново");                                                    