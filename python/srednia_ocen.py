# Dawid Sobota 78618
# Prosty program obliczający średnią ocen ucznia w Pythonie

liczba_ocen = int(input("Podaj liczbę ocen: "))

if liczba_ocen <= 0:
    print("Liczba ocen musi być większa od zera!")
else:
    suma = 0.0

    # Pętla for pobiera kolejne oceny i sumuje je
    for i in range(liczba_ocen):
        ocena = float(input(f"Podaj ocenę nr {i + 1} (1-6): "))
        suma += ocena

    srednia = suma / liczba_ocen
    print(f"Średnia: {srednia:.2f}")

    # Instrukcja warunkowa sprawdza, czy uczeń zdał
    if srednia >= 3.0:
        print("Uczeń zdał.")
    else:
        print("Uczeń nie zdał.")
