internal class Program
{
    private static void Main(string[] args)
    {

        // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
        Console.Write("Lütfen bir sayı giriniz: ");
        int sayac = int.Parse(Console.ReadLine()); //Console.Readline sadece string okur bu sebeple başına int.Parse yazdık ki okusun.
        for (int i = 0; i < sayac; i++) // i sıfırdan başlayarak her döngüde 1 arttırarak ve length^den küçük olana kadar bu for'u dön, her seferinde bu satırları çalıştır anlamına geliyor. 
        {
            if(i%2 ==1) // % mod alma işareti. tek sayı old. anlatmak için (bir sayının 2^ye bölümünden kalan 1'se tektir) i mod2 =1 diyoruz.
            
            Console.WriteLine(i);
        }
        //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
        int tekToplam = 0;
        int ciftToplam = 0;

        for (int i = 1; i <= 1000; i++)
        {
            if(i%2 == 1) //tek sayılar
             tekToplam += i; // tekToplam = tekToplam + i; ile eşdeğer bir ifadedir.
            else
             ciftToplam += i;
        }
        Console.WriteLine("Tek Toplam:" + tekToplam);
        Console.WriteLine("Çift Toplam:" + ciftToplam);

        //break (eğer bi döngü içerisinde bir case'e bağlı olarak looptan çıkmak istiyorsanız yani döngüyü sonlandırmak istiyorsanız-komple döngüyü sonlandırır.) continue (eğer bir şarta bağlı olarak mevcut döngünün o cycle'ının atlamak istiyorsanız)

        for (int i = 1; i < 10; i++)
        {
            if (i==4)
             break;
            Console.WriteLine(i);
        }
        for (int i = 1; i < 10; i++)
        {
            if(i==4)
             continue;
            Console.WriteLine(i);
        }
    }
}