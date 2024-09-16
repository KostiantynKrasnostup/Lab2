Random o = new Random(); // Створюємо екземпляр класу Random для генерації випадкових чисел
List<int> chisla = new List<int>();

// Додаємо до списку 10 випадкових чисел у діапазоні від -10 до 10
for (int i = 0; i < 10; i++)
{
    chisla.Add(o.Next(-10, 11)); 
    Console.Write("{0} ", chisla[i]); 
}
Console.WriteLine(); 

// Створюємо два нових списки для зберігання позитивних і негативних чисел
List<int> positivnichisla = new List<int>();
List<int> negativnichisla = new List<int>();

// Проходимо список і сортуємо числа на позитивні та негативні
for (int i = 0; i < chisla.Count; i++)
{
    if (chisla[i] > 0)
        positivnichisla.Add(chisla[i]); 
    else if (chisla[i] < 0)
        negativnichisla.Add(chisla[i]); 
}

// Виводимо всі позитивні числа
Console.WriteLine("Позитивні числа:");
for (int i = 0; i < positivnichisla.Count; i++)
{
    Console.Write("{0} ", positivnichisla[i]); 
}
Console.WriteLine(); 

// Виводимо всі негативні числа
Console.WriteLine("Негативні числа:");
for (int i = 0; i < negativnichisla.Count; i++)
{
    Console.Write("{0} ", negativnichisla[i]); 
}
Console.WriteLine(); 
