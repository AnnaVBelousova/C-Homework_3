// See https://aka.ms/new-console-template for more information
//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int N = Convert.ToInt32(Console.ReadLine());
for (i = 1, i< N+1, i++)
{
  for (a = 1, a< N+1, a++)
 {
   for (b = 1, b< N+1, b++)
 

  {
    Console.WriteLine(i*a*b);    
  } 
 }
}

