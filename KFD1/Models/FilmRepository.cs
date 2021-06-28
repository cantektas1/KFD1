using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KFD1.Models
{
    public static class FilmRepository
    {
        private static List<Film> filmler = null;
        static FilmRepository()
        {
            filmler = new List<Film>()
            {
                new Film(){Id=1, Name="Esaretin Bedeli", Image="1.jpg", Description="Esaretin Bedeli, Frank Darabont'un senaryosunu yazdığı ve yönettiği, başrollerinde Tim Robbins ve Morgan Freeman'ın yer aldığı 1994 yapımı Amerikan dram filmidir."},
                new Film(){Id=2, Name="Baba", Image="2.jpg", Description="Baba, Mario Puzo'nun yazdığı aynı adlı romandan uyarlanan, Francis Ford Coppola'nın yönettiği, Marlon Brando ve Al Pacino'nun başrollerini paylaştığı filmdir. Filmde ayrıca yardımcı rollerde James Caan, Robert Duvall, Diane Keaton, John Cazale vardır. "},
                new Film(){Id=3, Name="Kara Şövalye", Image="3.jpg", Description="Kara Şövalye, Christopher Nolan'ın yönettiği bir süper kahraman filmidir. DC Comics'in kurgusal karakteri Batman'den uyarlanan 2005 tarihli Batman Başlıyor filminin devamıdır. Kara Şövalye'nin senaryosunu Christopher ve kardeşi Jonathan Nolan yazmıştır. Hikâyeyi ise David S. Goyer oluşturmuştur."},
                new Film(){Id=4, Name="Dövüş Kulübü", Image="4.jpg", Description="Dövüş Kulübü, Chuck Palahniuk tarafından yazılmış aynı isimli romandan uyarlanan kült filmdir. 1999 yapımı olan film, David Fincher tarafından yönetilmiştir ve başrollerde Brad Pitt, Edward Norton ve Helena Bonham Carter rol almıştır. Müziklerini Dust Brothers yapmıştır."},
                new Film(){Id=5, Name="Matrix", Image="5.jpg", Description="Matrix, Wachowski Kardeşlerin yazıp yönettiği bilimkurgu-aksiyon filmi. 1999 yılında gösterime girdi. Filmde Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss ve Hugo Weaving gibi yıldızlar yer almaktadır. Matrix ABD'de 171.479.930 $, ABD dışında 288.900.000 $ olmak üzere toplam 460.379.930 $ hasılat elde etti."},
                new Film(){Id=6, Name="Yenilmezler: Son Sahne", Image="7.jpg", Description="Avengers: Endgame, Marvel Comics'in İntikamcılar adlı süper kahraman grubundan uyarlanan ve Marvel Studios tarafından yapımı üstlenilen ABD süper kahraman filmi. 2018 yapımı Avengers: Sonsuzluk Savaşı filminin devamı niteliğinde olup yirmi ikinci Marvel Sinematik Evreni filmidir."},
                new Film(){Id=7, Name="Açlık Oyunları: Alaycı Kuş Bölüm", Image="8.jpg", Description="Açlık Oyunları: Alaycı Kuş Bölüm 1, 2014 yapımı sinema filmi. 21 Kasımda vizyona girmiştir. Açlık Oyunları'nın üçüncü filmi olan ve Suzanne Collins'in Alaycı Kuş adlı eserinden uyarlanan filmde kitabın ilk yarısı, yani 195. sayfaya kadar olan kısmı anlatılmaktadır."},
                new Film(){Id=8, Name="7.Koğuştaki Mucize", Image="9.jpg", Description="7. Koğuştaki Mucize, Mehmet Ada Öztekin'in yönetmenliğini yaptığı; Aras Bulut İynemli, Nisa Sofiya Aksongur, Celile Toyon, İlker Aksum, Mesut Akusta, Deniz Baysal, Yurdaer Okur ve Sarp Akkaya'nın başrollerini paylaştığı Türk yapımı dram filmi."},

            };
        }

        public static List<Film> Filmler
        {
            get { return filmler; }
        }
        public static void AddFilm(Film film)
        {
            filmler.Add(film);
        }
        public static Film GetById(int id)
        {
            return filmler.FirstOrDefault(i => i.Id == id);
        }
    }
}