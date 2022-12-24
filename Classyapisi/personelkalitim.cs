using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classyapisi
{
    public class personelkalitim
    {
        public int tc;
        public string adsoyad;
        public int maas;
        public string görev;
        public DateTime isealimtarihi, istencikarimtarihi;



        public virtual void personelekle(int tc, string adsoyad, string görev, int maas)
        {
            
            this.görev = görev;
            this.tc = tc;
            this.maas = maas;
            this.adsoyad = adsoyad;
        }

        
        public virtual void personelcikar(int tc)
        {
            this.tc = tc;


        }
        public virtual void personelgüncelle(int tc, string görev, int maas)
        {
            this.tc = tc;
            this.görev = görev;
            this.maas = maas;
           

        }
    }
}
