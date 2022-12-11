/* Напишите программу,которая принимает на вход пятизначное число
 и проверяет,является ли оно палиндромом.
 */

 Console.WriteLine ("Введите пятизначное число: ");

  string number = (Console.ReadLine() ??"");
  int num = number.Length;
  
  if (number[0] == number[4]) 
  if (number[1] == number[3]) 
    {
    Console.WriteLine("Это палиндром");
    }
  else
  {
    Console.WriteLine("Это не палиндром");
  }
  
    
  

