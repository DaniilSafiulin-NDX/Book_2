using System.Data.Linq.Mapping;

namespace Записаня_книжка.entities
{
    [Table(Name = "Notes")]
    public class Notes
    {
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "data")]
        public string data { get; set; }

        [Column(Name = "id_Book")]
        public int id_Book { get; set; }
    }
}