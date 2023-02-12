// Функция ФАКТОРИАЛ
// double Factorial(int n)
// {
//     // 1!= 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n* Factorial(n-1);
// }

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! {Factorial(i)}");

// }

// Рекурсия на числах Фибоначчи f(1)= 1, f(2) = 1,f(n) = f(n-1) + f(n-2)
//  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711
// double Fibonachi(int n)
// {
//     if (n == 0) return 0;
//     if (n == 1 || n == 2) return 1;
//     else return Fibonachi(n - 1) + Fibonachi(n - 2);
// }

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonachi(i)}");

// }

double Fibonachi(int n, double p1 = 0, double p2 = 1)
{
    if (n <= 1) return p1;
    double p;
    for (int j = 2; j < n; j++)
    {
        p = p1;
        p1 = p2;
        p2 = p2 + p;
    }
    return p2;
}

Console.WriteLine(Fibonachi(50));


// int[] memF = new int[100];
// {
//     Console.WriteLine(Fib(10));
// }

// int Fib(int n)
// {
//     if (n <= 1) return n;

//     if (memF[n] != 0) return memF[n];

//     memF[n] = Fib(n - 2) + Fib(n - 1);
//     return memF[n];
// }