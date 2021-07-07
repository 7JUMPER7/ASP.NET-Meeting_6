using Meeting_6.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meeting_6.Models
{
    public class NewsRepository : IRepository<News>
    {
        private List<News> news;

        public NewsRepository()
        {
            news = new List<News>()
            {
                new News() { Id = 1, Title = "Биткоин продолжает плавать в диапазоне от 32 до 38 тыс. долларов.",
                    Description = "В ночь на понедельник курс биткоина достигал отметки в $35,9 тыс., после чего начал снижаться. По состоянию на 20:10 мск цена первой криптовалюты составляет $33,6 тыс., за прошедшие сутки она упала на 5%. Биткоин продолжает сохранять тенденцию на снижение, следующие уровни $27 тыс. и $23 тыс., уверен CEO Xena Financial Systems Антон Кравченко. По его словам, скорость снижения значительно замедлилась и рынок ждет точку разворота, однако пока неизвестно на каком уровне это произойдет.",
                    Date = new DateTime(2021, 7, 5) },
                new News() { Id = 2, Title = "Новая Tesla Model S Plaid начала поставляться.",
                    Description = "По данным Tesla, благодаря трехмоторной электрической силовой установке мощностью 1200 лошадиных сил Model S Plaid разгоняется до 60 миль в час (97 км/ч) меньше чем за две секунды. Дальность хода без подзарядки составляет 390 миль (628 км), а максимальная скорость достигает 200 миль в час (322 км/ч). Однако для того, чтобы разгоняться до такой скорости, на машину необходимо установить специальные колеса и шины, которые поступят в продажу не раньше осени, говорится на сайте компании.",
                    Date = new DateTime(2021, 6, 28) },
                new News() { Id = 3, Title = "Илон Маск в очередной раз пошутил.",
                    Description = "Основатель компании SpaceX Илон Маск после вопроса о реакции «Роскосмоса» на запуск Crew Dragon к МКС, пошутил про «работающий батут». Директор NASA Джеймс Брайденстайн сообщил, что еще не говорил с главой Федерального космического агентства Дмитрием Рогозиным, но видел видеообращение представителя «Роскосмоса».",
                    Date = new DateTime(2020, 8, 13) }
            };
        }

        public void Create(News item)
        {
            news.Add(item);
        }

        public bool Delete(int id)
        {
            return news.Remove(GetItem(id));
        }

        public IEnumerable<News> GetAll()
        {
            return news;
        }

        public News GetItem(int id)
        {
            return news.Find(n => n.Id == id);
        }

        public void Update(News item)
        {
            News buf = GetItem(item.Id);
            buf.Title = item.Title;
            buf.Description = item.Description;
            buf.Date = item.Date;
        }
    }
}