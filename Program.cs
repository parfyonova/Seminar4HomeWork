// ВСЕ РЕШАЕМ ЧЕРЕЗ МЕТОДЫ

/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B.
3, 5 -> 243 (3⁵), 2, 4 -> 16 */

// Console.Write("Введите число А: ");
// int numA = int.Parse(Console.ReadLine()!);
// Console.Write("Введите степень B: ");
// int numB = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Число А в степени В будет равно: {Exponentiation(numA, numB)}");

// int Exponentiation (int numA, int numB){
//      int result = 1;
//      for (int count = 1; count <= numB; count++){
//         result = result * numA;
//      }
//      return result;
// }

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11, 82 -> 10, 9012 -> 12 */

// Console.Write("Введите число: ");
// string num = Console.ReadLine()!;
// Console.WriteLine($"Сумма цифр в числе {num} равна: {SumNumber(num)}");

// int SumNumber (string num){
//     int sum = 0;
//     for (int i = 0; i < num.Length; i++) sum += Convert.ToInt32(num[i].ToString());
//     return sum;
// }

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19], 6, 1, 33 -> [6, 1, 33] */

// int[] array = GetBinaryArray(8);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// int[] GetBinaryArray(int size){
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++){
//         result[i] = new Random().Next (0, 99);
//     }
//     return result;
// }