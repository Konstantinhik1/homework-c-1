// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

 
    //     Console.WriteLine("Введите два значения M и N:");
    //     int m = int.Parse(Console.ReadLine());
    //     int n = int.Parse(Console.ReadLine());
    //     Console.WriteLine("натуральные числа в промежутке от M до N");
    //     PrintNumbers(m, n);

    //     Console.ReadLine();
    

    // static void PrintNumbers(int m, int n)
    // {
        
    //     if (m <= n)
    //     {
    //         Console.WriteLine(m);
    //         PrintNumbers(m + 1, n);
    //     }
    // }
    
   



// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 


    //     Console.WriteLine("Введите два неотрицательных числа m и n:");
    //     int m = int.Parse(Console.ReadLine());
    //     int n = int.Parse(Console.ReadLine());

    //     int result = AckermannFunction(m, n);

    //     Console.WriteLine("Результат функции Аккермана: " + result);

    //     Console.ReadLine();
    

    // static int AckermannFunction(int m, int n)
    // {
    //     if (m == 0)
    //     {
    //         return n + 1;
    //     }
    //     else if (m > 0 && n == 0)
    //     {
    //         return AckermannFunction(m - 1, 1);
    //     }
    //     else
    //     {
    //         return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    //     }
    // }



// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

//  
//         int[] arr = { 1, 2, 3, 4, 5 };
        
//         PrintArrayReverse(arr, arr.Length - 1);
        
//         Console.ReadLine();
//     }

//     static void PrintArrayReverse(int[] arr, int index)
//     {
//         if (index >= 0)
//         {
//             Console.WriteLine(arr[index]);
//             PrintArrayReverse(arr, index - 1);
//         }
//     