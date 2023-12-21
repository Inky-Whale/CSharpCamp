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
        basvuruManager.BasvuruYap(ihtiyacKrediManager, new List<ILoggerService>());
        basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService>(){new SmsLoggerService(), fileLoggerService});
        basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService>());
        List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, konutKrediManager, tasitKrediManager };



        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
    }
}

