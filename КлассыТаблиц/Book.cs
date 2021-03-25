using System.Data.Linq.Mapping;

namespace Записная_книжка.entities
{
    [Table(Name = "Book")]
    public class Book
    {
        [Column(Name = "id_User", IsPrimaryKey = true)]
        public int User { get; set; }

        [Column(Name = "title", IsPrimaryKey = true)]
        public string title { get; set; }

        [Column(Name = "id")]
        public int id { get; set; }
    }
}
