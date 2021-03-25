using System.Data.Linq.Mapping;

namespace записная_книжка.entities
{
    [Table(Name = "Users")]
    public class Users
    {
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Name")]
        public string FirstName { get; set; }

        [Column(Name = "Surname")]
        public string LastName { get; set; }

        [Column(Name = "Phone")]
        public string PhoneNumber { get; set; }

        [Column(Name = "Adress")]
        public string Adress { get; set; }

        [Column(Name = "Mail")]
        public string Mail { get; set; }

        [Column(Name = "Login")]
        public string Login { get; set; }

        [Column(Name = "Password")]
        public string Password { get; set; }
    }
}
