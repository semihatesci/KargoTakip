using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classyapisi
{
   public class personel:personelkalitim

    {
        public override void personelekle(int tc, string adsoyad, string görev, int maas)
        {
            base.personelekle(tc, adsoyad, görev, maas);
        }

        public override void personelcikar(int tc)
        {
            base.personelcikar(tc);
        }
        public override void personelgüncelle(int tc, string görev, int maas)
        {
            base.personelgüncelle(tc, görev, maas);
        }









    }
}
