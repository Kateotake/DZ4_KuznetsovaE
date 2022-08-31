// необязательная задача
// Написать программу, которая сортирует массив от большего к меньшему и находит медианное значение.
//  Массив заполняется случайными целыми числами от 1 до 100, а его размерность вводится с клавиатуры

void FillArray(int[] arr) 
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random ().Next(1,100); 
        index++;
    }
}

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

void Selection(int[] arr3) 
{
    for (int i = 0; i < arr3.Length - 1; i++) 
    {
        int maxPos = i; 

        for (int j = i + 1; j < arr3.Length; j++) 
        {
            if (arr3[j] > arr3[maxPos]) 
            {
                maxPos = j; 
            }
        }
        int temp = arr3[i];
        arr3[i] = arr3[maxPos];
        arr3[maxPos] = temp;
    }
}

Console.WriteLine("Введите целое число - кол-во элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [] array = new int[N];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
Selection(array);
PrintArray(array);
Console.WriteLine();

double med = 0;
if (N % 2 == 1) med = array[(N - 1)/2];

else 
{
    int med1 = array[N / 2] ; 
    int med2 = array[(N - 2)/2] ;
    med = Convert.ToDouble(med1 + med2) /2;
} 

Console.WriteLine ($"Медианное значение данного массива - {med}");