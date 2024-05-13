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