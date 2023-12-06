using System.Globalization;
using System.Reflection.Metadata.Ecma335;
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 2, 1 };
void PrintArray(int[] array){

    int count = array.Length;

    for ( int  i = 0; i < count; i++){
        
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int [] array){
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;     
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    
}
Console.Clear();
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
