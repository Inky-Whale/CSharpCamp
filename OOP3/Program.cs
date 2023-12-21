namespace OOP3;

class Program
{
    static void Main(string[] args)
    {
        IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
        IKrediManager tasitKrediManager = new TasitKrediManager();
        IKrediManager konutKrediManager = new KonutKrediManager();
        ILoggerService fileLoggerService = new FileLoggerService();

        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());
        basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);
        basvuruManager.BasvuruYap(new EsnafKrediManager(), new SmsLoggerService());
        List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, konutKrediManager, tasitKrediManager };



        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
    }
}

