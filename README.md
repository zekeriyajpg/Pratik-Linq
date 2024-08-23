# LINQ ile Rastgele Sayıların Filtrelenmesi ve Manipülasyonu

Bu proje, C# programlama dilinde rastgele sayılar üreten ve bu sayılar üzerinde çeşitli LINQ sorguları çalıştıran bir uygulama örneğidir. Amaç, LINQ kullanarak sayıları filtrelemek, sayılar üzerinde matematiksel işlemler yapmak ve sonuçları konsol ekranına yazdırmaktır.

## Kullanılan Teknolojiler

- **Dil:** C#
- **Çerçeve:** .NET Framework

## Proje İçeriği

1. **Rastgele Sayılar:**
   - `Random` sınıfı kullanılarak -50 ile 50 arasında rastgele 10 adet sayı üretilir ve bu sayılar bir listeye eklenir.

2. **Çift Sayılar:**
   - `Where` yöntemi kullanılarak listenin içindeki çift sayılar (`n % 2 == 0`) filtrelenir ve konsola yazdırılır.

3. **Tek Sayılar:**
   - `Where` yöntemi kullanılarak listenin içindeki tek sayılar (`n % 2 != 0`) filtrelenir ve konsola yazdırılır.

4. **Negatif Sayılar:**
   - `Where` yöntemi kullanılarak listenin içindeki negatif sayılar (`n < 0`) filtrelenir ve konsola yazdırılır.

5. **Pozitif Sayılar:**
   - `Where` yöntemi kullanılarak listenin içindeki pozitif sayılar (`n > 0`) filtrelenir ve konsola yazdırılır.

6. **15'ten Büyük ve 22'den Küçük Sayılar:**
   - `Where` yöntemi kullanılarak listenin içindeki 15'ten büyük ve 22'den küçük sayılar (`n > 15 && n < 22`) filtrelenir ve konsola yazdırılır.

7. **Listedeki Her Bir Sayının Karesi:**
   - `Select` yöntemi kullanılarak listedeki her bir sayının karesi hesaplanır ve yeni bir liste oluşturularak konsola yazdırılır.
