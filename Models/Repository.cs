using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcbooks.Models
{
    public class Repository
    {
      public static  List<Book> Books {get; set;} = new List<Book>()
            {
                new Book()
                {
                    Id=1,
                    Title="Bilincaltinin Gucu",
                    Image="bilinaltiningucu.jpg",
                    Author="Joseph Murphy",
                    Description="Zihniniz, anbean yaşadıklarınızı işleyip kendinizi gerçekleştirme yolculuğunuzda gideceğiniz yönü belirlemenizi sağlıyor. "

                },
                new Book()
                {
                    Id=2,
                    Title="Senin Cahilliğin Benim Yaşamımı Etkiliyor",
                    Image="cahilligin.jpg",
                    Author="A. M. Celal Şengör",
                    Description="Senin bilgeliğin bizim yaşamımızı etkiliyor."

                },
                new Book()
                {
                    Id=3,
                    Title="Gece Yarısı Kütüphanesi",
                    Image="geceyarisi.jpg",
                    Author="Matt Haig",
                    Description="Yaşamla ölüm arasında bir kütüphane var,” dedi. “Bu kütüphanedeki raflar sonsuza kadar gider.  Her kitap yaşamış olabileceğin başka bir hayatı yaşama şansını sunar sana. Farklı seçimler yapmış olsan, şu an nasıl bir hayatın olacağını görürsün…"

                },
                new Book()
                {
                    Id=4,
                    Title="Otuz Milyon Kelime",
                    Image="otuzmilyon.jpg",
                    Author="Dana Suskind , Beth Suskind",
                    Description="enim yıllardır yazı ve konuşmalarımda anlattığım ama her seferinde anlatmakta yetersiz kaldığım bir mevzudur Otuz Milyon Kelime farkı. Artık içim rahat. "

                },
                new Book()
                {
                    Id=5,
                    Title="Seninle Başlamadı",
                    Image="seninlebaslamadi.jpg",
                    Author=" Mark Wolynn",
                    Description="Kendinizi keşfedeceğiniz bir psikoloji kitabına hazır mısınız? Yaşadığınız sorunların, hissettiğiniz duyguların yalnızca kendinize ait olmadığını bilseydiniz ne düşünürdünüz? "

                },
                 new Book()
                {
                    Id=6,
                    Title="Balonla Beş Hafta",
                    Image="balon.jpg",
                    Author="  Jules Verne",
                    Description="1863 yılında yayımlanan Balonla Beş Hafta, Jules Verne’in hem ilk romanı hem de muazzam Olağanüstü Yolculuklar koleksiyonunun ilk yapıtıdır. Üç İngiliz kâşifin o dönemde Avrupalıların gözünde hâlâ gizemini koruyan Afrika kıtasını balonla baştan başa aştıkları macera dolu yolculuğun hikâyesi, sonraki Jules Verne romanlarına da damgasını vuran bütün özellikleri taşır. Yenilikçi bir bilimsel icat, gerilim ve sürprizlerle dolu girift bir olay örgüsü, bilinmeyene yapılan bir yolculuk, hedeflerine ulaşma yolunda gözünü budaktan sakınmayan karakterlerin sergilediği azim ve cesaret, dostluk ve sadakat temaları, yazarın muziplik sınırında gezinen mizahıyla harmanlanmıştır. Roman, bütünüyle kurgu bir yapıt olmasına karşın gerçek bir gezi günlüğü edasıyla kaleme alınmıştır. Karakterlerin Afrika halklarına ilişkin gözlem ve söylemleri, o dönemde Avrupa’daki düşünce ikliminin, Batılıların kendilerinden olmayana yönelik yaklaşımlarının izlerini taşır."

                }
    
            };
            public static Book GetCourseById(int id)
            {
                return Books.FirstOrDefault(b=>b.Id==id);
            }
    }
}