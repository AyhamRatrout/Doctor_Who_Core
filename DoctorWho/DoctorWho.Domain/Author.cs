using System.Collections.Generic;

namespace DoctorWho.Domain
{
    public class Author
    {
        public Author()
        {
            this.Episodes = new List<Episode>();
        }
        public Author(string AuthorName) : this()
        {
            this.AuthorName = AuthorName;
        }
        public int AuthorId { get; set; }

        public string AuthorName { get; set; }

        public List<Episode> Episodes { get; set; }
    }
}
