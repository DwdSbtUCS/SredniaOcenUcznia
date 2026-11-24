// Dawid Sobota 78618
// Prosty program obliczający średnią ocen ucznia w C#

Console.Write("Podaj liczbę ocen: ");
int liczbaOcen = Convert.ToInt32(Console.ReadLine());

if (liczbaOcen <= 0)
{
    Console.WriteLine("Liczba ocen musi być większa od zera!");
}
else
{
    double suma = 0;

    // Pętla for pobiera kolejne oceny i sumuje je
    for (int i = 0; i < liczbaOcen; i++)
    {
        Console.Write($"Podaj ocenę nr {i + 1} (1-6): ");
        double ocena = Convert.ToDouble(Console.ReadLine());
        suma += ocena;
    }

    double srednia = suma / liczbaOcen;
    Console.WriteLine($"Średnia: {srednia:F2}");

    // Instrukcja warunkowa sprawdza, czy uczeń zdał
    if (srednia >= 3.0)
    {
        Console.WriteLine("Uczeń zdał.");
    }
    else
    {
        Console.WriteLine("Uczeń nie zdał.");
    }
}
