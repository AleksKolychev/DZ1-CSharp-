Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ое число: ");
int k = Convert.ToInt32(Console.ReadLine());
if (n > m && n > k)
    Console.WriteLine(n);
else if (m > n && m > k)
    Console.WriteLine(m);
else if (k > n && k > m)
    Console.WriteLine(k);
else
    Console.WriteLine("Числа равны");