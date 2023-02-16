//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

internal class Program
{
  private static void Main(string[] args)
  {
    Console.Write("Является ли день недели выходным ");
    while(true)
    {
      Console.Write("Введите номер дня недели ");
      int num = int.Parse(Console.ReadLine());
      if(num >= 1 && num <= 5)
      {
        Console.WriteLine("Это рабочий день");
      }
      else
      if(num >= 6 && num <= 7)
      {
        Console.WriteLine("Ура! Выходной день");
      }
    }
  }
}