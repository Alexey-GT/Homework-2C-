//Напишите программу, которая принимает на вход трехзначное
//число и на выходе показывает вторую цифру этого числа.
/* Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
//if()//Проверка на трехзначность
    int number2 = (number%100)/10;
Console.WriteLine(number2);   */


//Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.
/* Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if(number > 99)
{
    while(number >= 1000)
    {
    number = number / 10;
    }
    int x = number / 10;
    x = x * 10;
    number = number - x;
    Console.WriteLine(number);
}
else Console.WriteLine("Третьей цифры нет"); */


//Напишите программу, которая принимает на вход цифру, обозначающую
//день недели, и проверяет, является ли этот день выходным.
/* Console.Clear();
Console.WriteLine("Введите цифру: ");
int day = int.Parse(Console.ReadLine());
 if(day == 6 ^ day == 7)
 {
    Console.WriteLine("Выходной день");
 } 
else
{
    Console.WriteLine("Не выходной день");
}    */




