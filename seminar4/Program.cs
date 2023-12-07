// Напишите программу, которая принимает от пользователя 2 числа и возвращает наибольшее из них
// int maxNumber(int a, int b){
//     if (a > b)
//         return a;
//     return b; // a<=b
// }

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Наибольшее значение: {maxNumber(n, m)}");

// void inputArray(int[] arr){
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] = new Random().Next(-100, 100);

// }
// Console.Clear();
// Console.Write("Введите кол. элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// Console.Write($"Начальный массив: [{string.Join(", ", array)}] ");
// inputArray(array);
// Console.Write($"Конечный массив: [{string.Join(", ", array)}] ");


// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n > 0){
//     int x = n % 10;
//     Console.Write($"{x}, ");
//     n /= 10;

// }
// 567 : 10 = 56( ост 7)
// 567 : 10 = 56

// 56 : 10 = 5(ост. 6)
// 56 : 10 = 5


// Задача найти простые числа в массиве
// void inputArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] = new Random().Next(0, 101); //[0. 100]
// }
// bool isPrime(int n)
// {
//     for (int i = 2; i <= n / 2; i++ )
//     {
//         if (n % i == 0)
//             return false;
//     }
//     return true;
// }

// Console.Clear();
// Console.Write("Введите кол. элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// inputArray(array);
// Console.Write($"Начальный массив: [{string.Join(", ", array)}]");
// Console.Write("Простые числа: ");
// for (int i = 0; i < array.Length; i++)
// {
//      if (isPrime(array[i]) == true)
//         Console.Write($"{array[i]} ");
// } 


// задача 2 Задайте массив из случайных чисел,Найдите числа, которые оканчиваются на 1 и делятся нацело на 7
void inputArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(-1000, 1001); //[-1000. 1000]
}



Console.Clear();
Console.Write("Введите кол. элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
inputArray(array);
Console.Write($"Начальный массив: [{string.Join(", ", array)}]");



// Задача 3. Заполните массив на N случайных чисел от 0 до 9( вводим с консоли не более 8)
// Сформируйте целое число , которое будет состоять из цифр из массива. Старший разряд числа находится на 0-м
// индексе, младший на последнем.

void inputArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(-1000, 1001); //[-1000. 1000]
}

int isCheck(int[] array){
    int count = 0;
    foreach (int element in array){
        if(element % 10 ==1 && element % 7 == 0)
        count++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите кол. элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
inputArray(array);
Console.Write($"Начальный массив: [{string.Join(", ", array)}]");