// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

System.Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
GetBinaryView(N);

void GetBinaryView(int number)
{
    if(number <= 0)
    {
        return;
    }
    GetBinaryView(number/2);
    System.Console.Write(number%2);
}