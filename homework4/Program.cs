// {
//         while (true){
//             Console.WriteLine("Введите целое число: ");
//             string input = Console.ReadLine();

//             if (input.ToLower() == "q"){
//                 Console.WriteLine("Программа завершена вы вели букву q.");
//                 break;
//             }
//             else{
//                 int number;
//                 if (int.TryParse(input, out number)){
//                     if (GetSumOfDigits(number) % 2 == 0){
//                         Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
//                         break;
//                     }
//                 }
//                 else{
//                     Console.WriteLine("Пожалуйста, введите корректное целое число или 'q' для выхода.");
//                 }
//             }
//         }
//     }
      
// static int GetSumOfDigits(int n){
//         int sum = 0;
//         n = Math.Abs(n);
//         while (n > 0)
//         {
//             sum += n % 10;
//             n /= 10;
//         }
//         return sum;
//     }

// Задача2
// {
//         Random random = new Random();
//         int[] array = new int[10]; // массив из 10 элементов

//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = random.Next(100, 1000); // случайное трёхзначное число
//             Console.WriteLine($"Элемент {i+1}: {array[i]}");
//         }

//         int countEven = 0;

//         foreach (int number in array)
//         {
//             if (number % 2 == 0)
//             {
//                 countEven++;
//             }
//         }

//         Console.WriteLine($"Количество чётных чисел в массиве: {countEven}");
//     }

//Задача 3 Напишите программу, 
//которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.
// Console.Clear();
// {
//         int[] originalArray = { 1, 2, 3, 4, 5 };
//         int[] reversedArray = ReverseArray(originalArray);

//         Console.WriteLine("Исходный массив:");
//         PrintArray(originalArray);

//         Console.WriteLine("\nПеревернутый массив:");
//         PrintArray(reversedArray);
//     }

//     static int[] ReverseArray(int[] arr)
//     {
//         int length = arr.Length;
//         int[] reversed = new int[length];

//         for (int i = 0; i < length; i++)
//         {
//             reversed[i] = arr[length - 1 - i];
//         }

//         return reversed;
//     }

//     static void PrintArray(int[] arr)
//     {
//         foreach (int num in arr)
//         {
//             Console.Write(num + " ");
//         }
//         Console.WriteLine();
//     }
