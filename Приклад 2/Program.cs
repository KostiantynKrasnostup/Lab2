List<int> chisla = new List<int> { 3, 14, 17, 6, 12, 18, 2, 2, 17, 10, 18, 1 };
int mx = chisla[0];
int nmx = 0;
for (int i = 1; i < chisla.Count; i++)
{
    if (chisla[i] > mx)
    {
        mx = chisla[i]; 
        nmx = i;       
    }
}
Console.WriteLine("\n{0}, {1}", mx, nmx);