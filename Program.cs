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

// Задание 3
int[] marks = { 120, 45, 300, 80, 15, 210 };
Console.WriteLine(Average(marks));
Console.WriteLine(CountGreater(marks, 100));


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