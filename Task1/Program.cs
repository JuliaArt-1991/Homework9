// 66
int f(int m, int n)
{
  if (m == n)
    return m;
  return (m+f(m+1, n));
}

Console.Clear();
Console.Write("Введите 1 число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m,n));