using System;
namespace OOP3
{
	public class BasvuruManager
	{
		public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
		{
			//Başvuran bilgilerini değerlendirme
			//

			krediManager.Hesapla();
            foreach (ILoggerService logger in loggerService)
            {
                logger.Log();
            }
		}

		public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
		{
			foreach (var kredi in krediler)
			{
				kredi.Hesapla();
			}
		}
	}
}

