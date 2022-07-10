using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Siparişİçerik _siparişVer = new LaktozsuzÜrünSipariş();
            _siparişVer._restoran = new AkşamYemeği();
            _siparişVer.Bilgi();

            _siparişVer._restoran = new FitRestoran();
            _siparişVer.Bilgi();

            _siparişVer = new GlutensizÜrünSipariş();
            _siparişVer._restoran = new AkşamYemeği();
            _siparişVer.Bilgi();

            _siparişVer._restoran = new FitRestoran();
            _siparişVer.Bilgi();

            Console.ReadKey();
        }
    }
}
