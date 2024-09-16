Random o = new Random();
List<int> chisla = new List<int>();
for (int i = 0; i < 10; i++)
{
    chisla.Add(o.Next(1, 10));
    Console.Write("{0}", chisla[i]);
}
Console.Write("\nВведіть індекс: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введіть число: ");
int x = Convert.ToInt32(Console.ReadLine());
chisla.Insert(k, x);
for (int i = 0; i < 10; i++)
    Console.Write("{0}", chisla[i]);

