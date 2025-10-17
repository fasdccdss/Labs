using System;

int Average(int a, int b) => (a + b) / 2;
int Square(int x) => x * x;
int Cube(int x) => x * x * x;

int[] Calculate()
{
    var a = new int[10];
    for (int x = 0; x < a.Length; x++)
    {
        int square = Square(x);
        int cube = Cube(x);

        a[x] = Average(square, cube);
        
        Console.WriteLine(a[x]);
    }
    return a;
}

Calculate();
