// Задача 039. Развернуть масив

Console.Clear();

System.Console.WriteLine("Укажите размер массива: ");
int SIZE = int.Parse(Console.ReadLine());
int[] array = new int[SIZE];

System.Console.WriteLine("Укажите левую границу цифр: ");
int LEFT_RANGE = int.Parse(Console.ReadLine());

System.Console.WriteLine("Укажите правую границу цифр: ");
int RIGHT_RANGE = int.Parse(Console.ReadLine());

array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
// System.Console.WriteLine("Случайный массив: ");
System.Console.WriteLine($"Наш случайный массив: [{string.Join(", ", array)}]");
ReverseArray(array);
System.Console.WriteLine($"Перевёрнутый массив:  [{string.Join(", ", array)}]");

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{

    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}