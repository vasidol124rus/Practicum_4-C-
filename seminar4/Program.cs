// Напишите программу, которая принимает от пользователя 2 числа и возвращает наибольшее из них
int maxNumber(int a, int b){
    if (a > b)
        return a;
    return b; // a<=b
}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Наибольшее значение: {maxNumber(n, m)}");
