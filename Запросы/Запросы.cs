using CourseWork.entities;
using System.Data.Linq;
using System.Linq;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Записная_книжка.Запросы
{
    class Queries
    {
        private readonly DataContext Dc = new DataContext(@"Data Source=.\SQLEXPRESS;Initial Catalog=Записная_книжка;Integrated Security=True");
        public Table<Users> GetUsersTable()
        {
            return Dc.GetTable<Users>();
        }
        public Table<Book> GetBooksTable()
        {
            return Dc.GetTable<Book>();
        }
        public Table<Notes> GetNotesTable()
        {
            return Dc.GetTable<Notes>();
        }
    }
}

