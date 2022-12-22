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
int m = GetNumber("enter number of string:");
int n = GetNumber("enter number of colums:");
int[,] matrix = new int[m, n];
Random rnd = new Random();
for(int i = 0; i < m; i++)
{
    for(int j =0; j < n;j++)
    {
        matrix[i, j] = rnd.Next(1, 10);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();

}
int a = GetNumber("enter koordinat of string");
int b = GetNumber("enter koordinat of colum");
if (a >= m || b >= n)
    Console.WriteLine("there isn't number");
else
{
    int number = matrix[a, b];
    Console.WriteLine($"number = {number}");
}