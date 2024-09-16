Random o = new Random(); // Створюємо екземпляр класу Random для генерації випадкових чисел
List<int> chisla = new List<int>();

// Додавання до списку 10 випадкових чисел у діапазоні від -5 до 5
for (int i = 0; i < 10; i++)
{
    chisla.Add(o.Next(-5, 6)); 
    Console.Write("{0}", chisla[i]); 
}
Console.WriteLine(); 

int x = 11;

// Проходимо список у зворотному порядку
for (int i = chisla.Count - 1; i >= 0; i--)
{
    if (chisla[i] < 0) // Перевіряємо, чи є число від'ємним
        chisla.Insert(i, x); // Вставляємо число x перед від'ємним числом
}

// Виводимо всі числа після вставки
for (int i = 0; i < chisla.Count; i++)
{
    Console.Write("{0} ", chisla[i]); 
}
Console.WriteLine(); 
