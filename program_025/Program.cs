//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int i = 0;
while (i<10)
{
    System.Console.WriteLine("Введите первое число: ");
    int n1 = int.Parse(System.Console.ReadLine()!); 
    System.Console.WriteLine("Введите второе число: ");
    int n2= int.Parse(System.Console.ReadLine()!);

    System.Console.WriteLine(Math.Pow(Math.Abs(n1), Math.Abs(n2)));
    i++;
}
