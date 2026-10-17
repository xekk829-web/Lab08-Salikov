// // Задание 1
// string text = "Hello World!";
// PrintHeader(text);

// // Задание 2
// Console.WriteLine(Max(1, 4));
// Console.WriteLine(Max(-10, -15));
// Console.WriteLine(Max(0, 0));

// Console.WriteLine(IsEven(4));
// Console.WriteLine(IsEven(7));
// Console.WriteLine(IsEven(0));

// // Задание 3
// int[] marks = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine(Average(marks));
// Console.WriteLine(CountGreater(marks, 100));

// // Задание 4
// Console.WriteLine(ToFahrenheit(32));
// Console.WriteLine(ToFahrenheit(212));
// Console.WriteLine(ToFahrenheit(98.6));

// Задание 5
Console.WriteLine(Factorial(5));

for (int i = 2; i <= 50; i++)
{
    Console.WriteLine($"Число {i} - простое: {IsPrime(i)}");
}

// Задание 6
int num1 = ReadPositive("Введите первое число: ");
int num2 = ReadPositive("Введите второе число: ");

Console.WriteLine("Сумма чисел: " + (num1 + num2));

// Методы
// Задание 1
static void PrintLine()
{
    Console.WriteLine("^_^");
}

static void PrintHeader(string title)
{
    PrintLine();
    Console.WriteLine(title);
    PrintLine();
}

// Задание 2
static int Max(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

static bool IsEven(int n) { return n % 2 == 0; }

// Задание 3
static double Average(int[] arr)
{
    int sum = 0;
    foreach (int el in arr)
    {
        sum += el;
    }
    return Convert.ToDouble(sum) / Convert.ToDouble(arr.Length);
}

static int CountGreater(int[] arr, int limit)
{
    int counter = 0;
    foreach (int el in arr)
    {
        if (el > limit)
        {
            counter += 1;
        }
    }
    return counter;
}

// Задание 4
static double ToFahrenheit(double celsius) { return celsius * 9 / 5 + 32; }

// Задание 5
static long Factorial(int n)
{
    long factorial = 1;
    for (int i = 1; i <= n; i++)
    {
        factorial *= i;
    }
    return factorial;
}

static bool IsPrime(int n)
{
    bool flag = true;
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            flag = false;
        }
    }
    return flag;
}

// Задание 6
static int ReadPositive(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    do
    {
        Console.Write(message);
        num = Convert.ToInt32(Console.ReadLine());
    } while (num < 0);
    return num;
}