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

void inputArray(int[] arr){
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(-100, 100);

}
Console.Clear();
Console.Write("Введите кол. элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
Console.Write($"Начальный массив: [{string.Join(", ", array)}] ");
inputArray(array);
Console.Write($"Конечный массив: [{string.Join(", ", array)}] ");
