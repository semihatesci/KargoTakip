using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classyapisi
{
    public class kargo:abstractkargo
    {
        public int kargono;
        public string adres;
        public string ad,soyad;
        public string aliciad, alicisoyad;
        public DateTime time=DateTime.Now;



        public  List<string> d2 = new List<string>();
        public List<string> d = new List<string>();
        public List<string> a = new List<string>();
public kargo()
        {

        }
        public kargo(int kargono, string adres, string ad, string soyad, string aliciad, string alicisoyad)

        {
            this.kargono = kargono;
            this.adres = adres;
            this.ad = ad; this.soyad = soyad;
            this.aliciad = aliciad; this.alicisoyad = alicisoyad;
           
            string dosyayolu = "C:\\Users\\atesci\\s.txt";
            //dosyayı okuma modunda açıyoruz
            FileStream fileStream = new FileStream(dosyayolu, FileMode.OpenOrCreate, FileAccess.Read);
            //dosyadan satır satır okuyup textBox içine yazıdırıyoruz
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (true)
                {

                    string satir = reader.ReadLine();
                    if (satir == null) break;
                    d.Add(satir + "\n"); // satır  ve yeni satır(\n)

                }
                reader.Close();
            }
            fileStream.Close();

            string dosyayolu1 = "C:\\Users\\atesci\\d.txt";
            //dosyayı okuma modunda açıyoruz
            FileStream fileStream1 = new FileStream(dosyayolu1, FileMode.OpenOrCreate, FileAccess.Read);
            //dosyadan satır satır okuyup textBox içine yazıdırıyoruz
            using (StreamReader reader = new StreamReader(fileStream1))
            {
                while (true)
                {

                    string satir = reader.ReadLine();
                    if (satir == null) break;
                    a.Add(satir + "\n"); // satır  ve yeni satır(\n)

                }
                reader.Close();
            }
            fileStream1.Close();
        }
      
        public override void kargoekle()
        {
            d.Add(kargono.ToString()+ adres+ ad+ aliciad);
            a.Add(kargono.ToString());
        }
       
        public override void kargoyerdegisimi()
        {
           
        }
        public override void kargosilme()
        {
            string f = kargono.ToString();
            int ara = 0;
            ara = a.BinarySearch(f);
            a.RemoveAt(ara);
            String[] sitesDizi1 = new String[a.Count];
            d.CopyTo(sitesDizi1, 0);
            System.IO.File.WriteAllLines("C:\\Users\\atesci\\d.txt", sitesDizi1);
            String[] sitesDizi = new String[a.Count];
            a.CopyTo(sitesDizi, 0);
            System.IO.File.WriteAllLines("C:\\Users\\atesci\\s.txt", sitesDizi);

        }

        public void kargotakip(int kargonoq )
        {
            string f = kargonoq.ToString();
            int ara = 0;
            ara = a.BinarySearch(f);
            d2.Add(d[ara]);
            String[] sitesDizi1 = new String[a.Count];
            d.CopyTo(sitesDizi1, 0);
            System.IO.File.WriteAllLines("C:\\Users\\atesci\\d.txt", sitesDizi1);
            String[] sitesDizi = new String[a.Count];
            a.CopyTo(sitesDizi, 0);
            System.IO.File.WriteAllLines("C:\\Users\\atesci\\s.txt", sitesDizi);


        }
    }

}
