
// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int n = Convert.ToInt32(Console.ReadLine());
int a = n/10000;
int b = n%10;
int c = (n/1000)%10;
int d = (n%100)/10;
if  (a == b  &  c == d)
{
 Console.WriteLine("Палиндром");   
}
else
{
Console.WriteLine("Нет");
} 

