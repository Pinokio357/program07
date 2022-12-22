using System;
bool control = true;
int GetNumber(string message)
{
    int result = 0;
    while (control)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
            control = false;
        else
            Console.WriteLine("enter correct number");
    }

    return result;
}
int m = GetNumber("enter m:");
int n = GetNumber("enter n:");
double[,] matrix = new double[m, n];
Random rnd = new Random();
for (int i =0; i < m; i++)
{
    for (int j=0; j < n; j++)
    {
        matrix[i, j] = Math.Round(rnd.NextDouble() *10, 2);
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($" {matrix[i, j]} ");
    }
    Console.WriteLine();

}


