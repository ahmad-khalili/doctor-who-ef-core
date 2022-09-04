using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories;

public class AuthorRepository
{
    private readonly DoctorWhoCoreDbContext _context;

    public AuthorRepository()
    {
        _context = new DoctorWhoCoreDbContext();
    }
    
    public void AddAuthor(Author author)
    {
        _context.Authors.Add(author);
        _context.SaveChanges();
    }

    public void ModifyAuthor(Author author, string newName)
    {
        author.AuthorName = newName;
        _context.SaveChanges();
    }

    public void DeleteAuthor(Author author)
    {
        _context.Authors.Remove(author);
        _context.SaveChanges();
    }
}