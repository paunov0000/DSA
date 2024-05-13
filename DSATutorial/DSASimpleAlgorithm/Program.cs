
// Fibonacci For Loop:
//FibonacciForLoop();






// FibonacciRecursion:
Console.WriteLine(0);
Console.WriteLine(1);
int count = 0;
FibonacciRecursion(0, 1);


static void FibonacciForLoop()
{
    int num1 = 0;
    int num2 = 1;
    int sum = 0;

    Console.WriteLine(num1);
    Console.WriteLine(num2);
    for (int i = 0; i < 18; i++)
    {
        sum = num1 + num2;
        num1 = num2;
        num2 = sum;
        Console.WriteLine(sum);
    }
}

void FibonacciRecursion(int num1, int num2)
{
    if (count < 18)
    {
        int fibNum = num1 + num2;
        num1 = num2;
        num2 = fibNum;
        Console.WriteLine(fibNum);
        count += 1;
        FibonacciRecursion(num1, num2);
    }
}
