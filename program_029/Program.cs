// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] ArrayGenerator (){
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,1001);
    }
    return array;
}


int[] array1 = ArrayGenerator();
System.Console.WriteLine('['+String.Join(',', array1)+']');