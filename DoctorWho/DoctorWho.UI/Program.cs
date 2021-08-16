using DoctorWho.Db;
using DoctorWho.Db.Repositories;
using System.Linq;

namespace DoctorWho.UI
{
    public class Program
    {
        protected static void Main(string[] args)
        {
            //AuthorsRepository.Create("foo");
            var author = DoctorWhoCoreDbContext._context.Authors.FirstOrDefault(a => a.AuthorName == "Foo1");
            //author.AuthorName = "Foo1";
            //AuthorsRepository.Update();
            AuthorsRepository.Delete(author);
        }

    }
}
