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
int m = GetNumber("enter the number of lines:");
int n =GetNumber("enter the number of columns:");
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
Console.Write("middle = ");
for (int j = 0; j < n; j++)
{
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum += matrix[i, j];
        
    }
    double sred = (double)sum / m;
    Console.Write("{0: 0.0 }", sred);