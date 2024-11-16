using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemauygulama
{
    public class sinema
    {
       private double ogrenci;
       private double tam;
       private double bakiye;
       private int boskoltuksayisi;
       private int koltuksayisi;
       private string salonno;

        public sinema(string salonno,int koltuksayisi,double ogrenci,double tam)
        {
            this.ogrenci = ogrenci;
            this.tam = tam;
            this.boskoltuksayisi=koltuksayisi;
            this.salonno = salonno;
            this.bakiye = 0;
        }
        public void Biletsat(bool indirimli)
        {
            boskoltuksayisi--;
            if(indirimli)
            {
                bakiye += ogrenci;
            }
            else
            {
                bakiye += tam;
            }
           
        }
        public void Biletiptal(bool indirimli)
        {
            boskoltuksayisi++;//bir artır
            if(indirimli)
            {
                bakiye -= ogrenci;
            }
            else
            {
                bakiye -= tam;
            }

        }
        public string BakiyeOgren()
        {
            return bakiye.ToString();
        }
        public string BosKoltukOgren()
        {
            return boskoltuksayisi.ToString();
        }
    }
}
