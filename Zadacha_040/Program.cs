// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();

int EnterSideLength(string str)
{
    System.Console.WriteLine(str);
    int side = int.Parse(Console.ReadLine());
    return side;
}

void Triangle(int a, int b, int c)
{
    if (a + b < c || a + c < b || b + c < a)
    {
        System.Console.WriteLine("Это не треугольник");
    }
    else
    {
        System.Console.WriteLine("Это треугольник");
    }
}

int a = EnterSideLength("Введите длину 1й стороны a: ");
int b = EnterSideLength("Введите длину 2й стороны b: ");
int c = EnterSideLength("Введите длину 3й стороны c: ");

Triangle(a, b, c);

// int numberA = rand.Next(1, 10);
// int numberB = rand.Next(1, 10);
// int numberC = rand.Next(1, 10);
// System.Console.WriteLine($"{numberA}, {numberB}, {numberC}");

// bool Tringl =  false;

// if(numberA > numberB && numberA > numberC && numberA < numberB + numberC)
//     Tringl = true;
// if(numberB > numberA && numberB > numberC && numberB < numberA + numberC)
//     Tringl = true;
// if(numberC > numberB && numberC > numberA && numberC < numberB + numberA)
//     Tringl = true;

// if(Tringl)
//     System.Console.WriteLine($"Треугольник со сторонами {numberA}, {numberB}, {numberC} может быть");
// else
//     System.Console.WriteLine($"Треугольник со сторонами {numberA}, {numberB}, {numberC} не может быть");