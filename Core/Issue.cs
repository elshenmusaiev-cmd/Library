
namespace Library.Core
{
    public class Issue
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int ReaderId { get; set; }
        public Reader Reader { get; set; }

        public int LibrarianID { get; set; }
        public Librarian Librarian { get; set; }

        public DateTime IssueDate { get; set; }
    }
}