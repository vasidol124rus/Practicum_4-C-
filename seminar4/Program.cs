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

void inputArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(0, 101); //[0. 100]
}
bool isPrime(int n)
{
    for (int i = 2; i <= n / 2; i++ )
    {
        if (n % i == 0)
            return false;
    }
    return true;
}

Console.Clear();
Console.Write("Введите кол. элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
inputArray(array);
Console.Write($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Простые числа: ");
for (int i = 0; i < array.Length; i++)
{
     if (isPrime(array[i]) == true)
        Console.Write($"{array[i]} ");
} 
