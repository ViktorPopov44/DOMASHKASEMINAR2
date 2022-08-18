Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Числа в третьей степени от 0 до введенного числа   ");

int[] TableSquares(int s)
{
    int[] array = new int[s];

    for (int i = 1; i <= n; i++)
    {
        array[i - 1] = i * i * i;
    }
    return array;
}
int[] result = TableSquares(n);
for (int i = 0; i < result.Length; i++)
{
    
    Console.WriteLine(result[i]);
}
