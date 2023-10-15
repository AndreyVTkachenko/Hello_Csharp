int Fibonacci(int N)
{
    if (N == 1 || N == 2) return 1;
    else return Fibonacci(N - 1) + Fibonacci(N - 2);
}


for (int i = 1; i < 10; i++)
{
    System.Console.WriteLine(Fibonacci(i));
}
