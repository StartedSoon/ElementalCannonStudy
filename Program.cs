string elementDurumu;
for (int sayac1 = 1; sayac1 <= 100; sayac1++)
{
    if (sayac1 % 15 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        elementDurumu = "Özel";
    }
    else if(sayac1 % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        elementDurumu = "Elektrik";
    }
    else if(sayac1 % 3 == 0)
    {
        Console.ForegroundColor= ConsoleColor.Red;
        elementDurumu = "Ateş";
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        elementDurumu = "Normal";
    }
    Console.WriteLine($"{sayac1}: {elementDurumu}");
}

