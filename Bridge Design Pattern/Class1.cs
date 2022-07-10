using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// sipariş vermek için bir arayüz tanımlayan implementor
    /// </summary>
    public interface ISiparişBilgi
    {
        void BilgiMesaj(string sipariş);
    }


    /// <summary>
    /// siparişin verildiği restorana bilgi sağlayan abstract sınıf
    /// </summary>
    public abstract class Siparişİçerik
    {
        public ISiparişBilgi _restoran;

        public abstract void Bilgi();
    }

    /// <summary>
    /// laktozsuz ürün siparişi için oluşturulmuş RefinedAbstraction sınıfı
    /// </summary>
    public class LaktozsuzÜrünSipariş : Siparişİçerik
    {
        public override void Bilgi()
        {
            _restoran.BilgiMesaj("Laktoz içermeyen ürün");
        }
    }

    /// <summary>
    /// Glutensiz ürün siparişi için oluşturulmuş RefinedAbstraction sınıfı
    /// </summary>
    public class GlutensizÜrünSipariş : Siparişİçerik
    {
        public override void Bilgi()
        {
            _restoran.BilgiMesaj("Gluten içermeyen ürün");
        }
    }
    

    /// <summary>
    /// restorandan sipariş verilebilen sistem için Concrete Implementor sınıfı
    /// </summary>
    public class AkşamYemeği : ISiparişBilgi
    {
        public void BilgiMesaj(string sipariş)
        {
            Console.WriteLine("Akşam yemeği için " + sipariş + " sipariş ediliyor.");
            System.Threading.Thread.Sleep(2000);
        }
    }


    /// <summary>
    /// Fit Restoran adlı restoranın sipariş sistemi için Concrete Implementor sınıfı
    /// </summary>
    public class FitRestoran : ISiparişBilgi
    {
        public void BilgiMesaj(string sipariş)
        {
            Console.WriteLine("Fit Restoran'dan " + sipariş + " sipariş edildi.\n");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
