using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniAtm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bakiye = 1000;
            Console.WriteLine("Atm ye Hoşgeldiniz");
            Console.WriteLine("Lütfen Yapmak istediğiniz işlemi Seçiniz");
            /* 1-Bakiye Görüntüleme
             * 2-Para Çekme
             * 3-Para Yatırma
             * q-çıkış
             */
            string islem = Console.ReadLine();

            if (islem == "1")
            {
                Console.WriteLine("Bakiyeniz : " + bakiye);
                Console.ReadLine();
            }
            else if (islem == "2") { 
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
                int cek = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Güncel Bakiyeniz: " + (bakiye - cek));
                Console.ReadLine();
            } else if  (islem == "3") {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz: ");
                int yat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Güncel Bakiyeniz: " + (bakiye + yat));
                Console.ReadLine();

            }  else if (islem == "q") {
                Console.WriteLine("Bankamızı tercih ettiğiz için Teşekkürler,Hayırlı Günler.");
                Console.ReadLine();
            }else{
                Console.WriteLine("Lütfen Geçerli bir değer Giriniz");


            }
        }
    }
}