using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Rastgele sayılardan oluşan bir liste oluşturma
        Random random = new Random();
        List<int> sayilar = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            sayilar.Add(random.Next(-50, 50)); // -50 ile 50 arasında rastgele sayılar
        }

        // Listeyi yazdırma
        Console.WriteLine("Rastgele Sayılar: " + string.Join(", ", sayilar));

        // Çift olan sayılar
        var evenSayilar = sayilar.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Çift Sayılar: " + string.Join(", ", evenSayilar));

        // Tek olan sayılar
        var oddNumbers = sayilar.Where(n => n % 2 != 0).ToList();
        Console.WriteLine("Tek Sayılar: " + string.Join(", ", oddNumbers));

        // Negatif sayılar
        var negativeNumbers = sayilar.Where(n => n < 0).ToList();
        Console.WriteLine("Negatif Sayılar: " + string.Join(", ", negativeNumbers));

        // Pozitif sayılar
        var positiveNumbers = sayilar.Where(n => n > 0).ToList();
        Console.WriteLine("Pozitif Sayılar: " + string.Join(", ", positiveNumbers));

        // 15'ten büyük ve 22'den küçük sayılar
        var between15and22 = sayilar.Where(n => n > 15 && n < 22).ToList();
        Console.WriteLine("15'ten Büyük ve 22'den Küçük Sayılar: " + string.Join(", ", between15and22));

        // Listedeki her bir sayının karesi
        var squaredNumbers = sayilar.Select(n => n * n).ToList();
        Console.WriteLine("Sayıların Kareleri: " + string.Join(", ", squaredNumbers));
    }
}
