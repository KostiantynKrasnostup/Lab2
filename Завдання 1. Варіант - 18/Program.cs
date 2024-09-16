Random o = new Random(); // Створюємо екземпляр класу Random для генерації випадкових чисел
List<int> chisla = new List<int>();
// Додавання до списку 10 випадкових чисел у діапазоні від 5 до 15
for (int i = 0; i < 10; i++)
{
    chisla.Add(o.Next(5, 16)); 
    Console.Write("{0} ", chisla[i]); 
}
Console.WriteLine();

// Видалення тільки першого парного числа з списку
for (int i = 0; i < chisla.Count; i++)
{
    if (chisla[i] % 2 == 0) // Перевірка, чи число парне
    {
        chisla.RemoveAt(i); // Видаляємо перше знайдене парне число
        break; // Виходимо з циклу
    }
}

// Виведення списку після видалення першого парного числа
for (int i = 0; i < chisla.Count; i++)
    Console.Write("{0} ", chisla[i]);