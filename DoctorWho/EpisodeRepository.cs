using DoctorWho.Db;
using DoctorWho.Db.Models;

namespace DoctorWho;

public class EpisodeRepository
{
    private readonly DoctorWhoCoreDbContext _context;

    public EpisodeRepository()
    {
        _context = new DoctorWhoCoreDbContext();
    }
    
    public void AddEpisode(Episode episode)
    {
        _context.Episodes.Add(episode);
        _context.SaveChanges();
    }

    public void ModifyEpisodeTitle(Episode episode, string newTitle)
    {
        episode.Title = newTitle;
        _context.SaveChanges();
    }
    
    public void ModifyEpisodeDoctor(Episode episode, Doctor newDoctor)
    {
        if (!_context.Doctors.Contains(newDoctor)) throw new ArgumentException("Doctor doesn't exist!");

        episode.DoctorId = newDoctor.DoctorId;
        _context.SaveChanges();
    }
    
    public void ModifyEpisodeAuthor(Episode episode, Author newAuthor)
    {
        if (!_context.Authors.Contains(newAuthor)) throw new ArgumentException("Author doesn't exist!");

        episode.AuthorId = newAuthor.AuthorId;
        _context.SaveChanges();
    }
    
    public void ModifyEpisodeNotes(Episode episode, string newNotes)
    {
        episode.Notes = newNotes;
        _context.SaveChanges();
    }
    
    public void ModifyEpisodeNumber(Episode episode, int newNumber)
    {
        episode.EpisodeNumber = newNumber;
        _context.SaveChanges();
    }
    
    public void ModifyEpisodeSeries(Episode episode, int newSeries)
    {
        episode.SeriesNumber = newSeries;
        _context.SaveChanges();
    }
    
    public void ModifyEpisodeDate(Episode episode, DateTime newDate)
    {
        episode.EpisodeDate = newDate;
        _context.SaveChanges();
    }
    
    public void ModifyEpisodeType(Episode episode, string newType)
    {
        episode.EpisodeType = newType;
        _context.SaveChanges();
    }

    public void DeleteEpisode(Episode episode)
    {
        _context.Episodes.Remove(episode);
        _context.SaveChanges();
    }
}