using System.Security.Cryptography.X509Certificates;

public class Author
{
    public int Id {  get; set; }
    public string Name {  get; set; }
    public List<Book> Books {  get; set; }
}

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }

    public int AuthorId { get; set; }
    public Author Author { get; set; }

    public List<Issue> Issues { get; set; }
}

public class Reader
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Issue> Issues { get; set; }
}

public class Librarian
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Issue> Issues { get; set; }
}


public class Issue
{
    public int Id { get; set; }

    public int BookId { get; set; }
    public Book Book { get; set; }

    public int ReaderId { get; set; }
    public Reader Reader { get; set; }

    public int LibrarianID { get; set; }
    public Librarian Librarian { get; set; }

    public DateTime IssueDate { get; set }
}