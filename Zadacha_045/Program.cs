//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int EnterNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int SIZE = EnterNumber("Укажите размер массива: ");

int LEFT_RANGE = EnterNumber("Укажите левую границу цифр: ");

int RIGHT_RANGE = EnterNumber("Укажите правую границу цифр: ");

int[] array = new int[SIZE];

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1); // [-9; 10)
    }
    return arr;
}


array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');
int[] array2 = new int [SIZE];
for (int i = 0; i < SIZE; i++)
{
    array2[i] = array[i];
}

Console.WriteLine('[' + string.Join(", ", array2) + ']');