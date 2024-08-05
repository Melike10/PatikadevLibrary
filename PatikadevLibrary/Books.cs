using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PatikadevLibrary
{
    // Class: herbir class bir nesneyi temsil eder. Bu nesneye ait özelliklere ve ozelleiklere ait metodları yani davranışları içerir.Sınıflar kodun daha düzenli ve yeniden kullanılabilir olmasını sağlar.
    public class Books
    {
        private string _bookName;
        private string _authorName;
        private string _authorSurname;
        private int _pageCount;
        private string _publisher;
        private DateTime _recordDate;

        // Property  yukarıda oluşturulan private alanlara kontrollü bir şekilde erişim sağlanmak için tanımlanmaktadır. Bunlara get methodu ile ulaşırken set methodu ile de değer atayıp günceleyebiliyoruz
        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }
        public string AuthorName
        {
            get { return _authorName; }
            set { _authorName = value; }
        }

        public string AuthorSurname
        {
            get { return _authorSurname; }
            set { _authorSurname = value; }
        }

        public int PageCount
        {
            get { return _pageCount; }
            set { 
                // sayfası sayısı 0 dan büyük girilmemeli
                if(value>0)
                 _pageCount = value;
                else
                    Console.WriteLine(" Yanlış değer girdiniz. ");
            }
        }
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public DateTime RecordDate
        {
            get { return _recordDate; }
            set { _recordDate = value; }
        }

        // Constructure ; sınıf yapılarının nesne olarak tanımlanmasında alt yapıyı hazırlayan, kurucu rolü üstlenen, sınıf ismi ile aynı isime sahip olan, geriye değer döndürmeyen fonksiyon türleridir.
        public Books()
        {
            RecordDate = DateTime.Now;

        }
        public Books(string BookName, string AuthorName, string AuthorSurname, string Publisher, int PageCount)
        {
            _bookName = BookName;
            _authorName = AuthorName;
            _authorSurname = AuthorSurname;
            _publisher = Publisher;
            _pageCount = PageCount;
            RecordDate = DateTime.Now;
        }

        public void Recording()
        {
            Console.WriteLine(" Kaydedilen Kitap Adı: "+BookName+" \n Yazar Adı Soyadı: "+ AuthorName+" "+AuthorSurname+"\n Yayın evi: "+ Publisher+" \n Sayfa Sayısı: "+PageCount+" \n Kayıt Tarihi: "+ RecordDate );
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }



    }


}
