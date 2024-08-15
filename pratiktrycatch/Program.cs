Console.WriteLine("Lütfen bir sayı giriniz : ");

try
{
    // Kullanıcının girdiği değeri al ve integer'a çevir
    int sayi = int.Parse(Console.ReadLine());
    // Sayının karesini hesapla ve ekrana yazdır
    int kare = sayi * sayi;
    Console.WriteLine("gridiğiniz sayının karesi: " + kare);
}
catch (FormatException)
{
    // Kullanıcı geçersiz bir giriş yaptığında hata mesajını göster
    Console.WriteLine("geçersiz giriş ");
}
