namespace OOP2;

class Program
{
    static void Main(string[] args)
    {
        GercekMusteri musteri1 = new GercekMusteri();
        musteri1.Id = 1;
        musteri1.MusteriNo = "12345";
        musteri1.Adi = "Berk";
        musteri1.Soyadi = "Karanfil";
        musteri1.TcNo = "123444221";


        TuzelMusteri musteri2 = new TuzelMusteri();
        musteri2.Id = 2;
        musteri2.MusteriNo = "234123";
        musteri2.SirketAdi = "Tobeto";
        musteri2.VergiNo = "12341242";

        Musteri musteri3 = new GercekMusteri();
        Musteri musteri4 = new TuzelMusteri();

        CustomerManager musteriManager = new CustomerManager();
        musteriManager.Add(musteri3);

    }
}

