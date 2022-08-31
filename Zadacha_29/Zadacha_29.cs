// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintArray(int[] arr2) 
{
    int length2 = arr2.Length;
    int index2 = 0;
    while (index2 < length2)
    {
        Console.Write($"{arr2[index2]} ");
        index2++;
    }
}
int [] arr = new int[8];

for (int i = 0; i < 8; i++)
{
    int a = Convert.ToInt32(Console.ReadLine());
    arr[i] = a;
} 
PrintArray(arr);





// int [] arr = new int[8];

// for (int i = 0; i < 8; i++)
// {
//     arr[i] = new Random ().Next(1,100);
//     Console.Write($"{arr[i]} ");
// } 