//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Console.WriteLine("Введите первое число");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число");
//int b = Convert.ToInt32(Console.ReadLine());
//int result = a;
//for (int i = 0; i < a; i++)
//{
//    result = result * a;
//}
//Console.WriteLine("Число А в степени B" + result);


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452-> 11
//82-> 10
//9012-> 12

//Console.WriteLine("Введите число");
//int a = Convert.ToInt32(Console.ReadLine());
//int result = 0;
//while (a > 0) 
//{
//    int b = a % 10;
//    a = a / 10;
//    result = result + b;
//}
//Console.WriteLine("Summa + " + result);


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
int[] GetArray(int length)
{
    int[] GetArray (int length)
    {
        int[]array = new int[length];

        Random r = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = r.Next(0, 9);
        }
        return array;
    }
    
    string GetArrayAsString(int[] array)
    {
        string result = string.Empty;

        for (int i = 0; i < array.Length; i++)
        {
            result + = $"{array[i]}, ";
        }
        return result;
    }
}

Console.WriteLine(GetArrayAsString(GetArray(int.Parse(Console.ReadLine()))));

