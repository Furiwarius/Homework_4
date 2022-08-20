//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int n1){
    int rt = 0;

    while (n1>=1)
    {
        rt+=n1%10;
        n1/=10;    
    }
    return rt;
}

System.Console.WriteLine("Введите число - ");
int n1 = Math.Abs(int.Parse(System.Console.ReadLine()!));

System.Console.WriteLine(Sum(n1));

