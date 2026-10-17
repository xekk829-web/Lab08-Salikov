// string text = "Hello World!";
// PrintHeader(text);

// Console.WriteLine(Max(1, 4));
// Console.WriteLine(Max(-10, -15));
// Console.WriteLine(Max(0, 0));

Console.WriteLine(IsEven(4));
Console.WriteLine(IsEven(7));
Console.WriteLine(IsEven(0));

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