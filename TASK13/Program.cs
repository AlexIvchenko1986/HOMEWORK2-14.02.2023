// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6


    int ABCDE = 464532134;
    int a = ABCDE % 10;
    int b = ABCDE / 10 % 10;
    int c = ABCDE / 100 % 10;
    int d = ABCDE / 1000 % 10;
    int e = ABCDE / 10000 % 10;
    int f = ABCDE / 100000 % 10;
    int g = ABCDE / 1000000 % 10;

    if (ABCDE < 99)
    {
      Console.WriteLine("Третьей цифры нету ");
    }
    else
    if (ABCDE < 1000)
    {
      Console.WriteLine(a);
    }
    else
       if (ABCDE < 10000)
    {
      Console.WriteLine(b);
    }
    else
          if (ABCDE < 100000)
    {
      Console.WriteLine(c);
    }
    else
             if (ABCDE < 1000000)
    {
      Console.WriteLine(d);
    }
    else
                if (ABCDE < 10000000)
    {
      Console.WriteLine(e);
    }
    else
                   if (ABCDE < 100000000)
    {
      Console.WriteLine(f);
    }
    else
                      if(ABCDE < 1000000000)
                      {
                        Console.WriteLine(g);
                      }
    