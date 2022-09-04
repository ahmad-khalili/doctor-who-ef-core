using DoctorWho.Db;
using DoctorWho.Db.Models;

namespace DoctorWho;

public class CompanionRepository
{
    private readonly DoctorWhoCoreDbContext _context;

    public CompanionRepository()
    {
        _context = new DoctorWhoCoreDbContext();
    }
    
    public Companion GetCompanionById(int companionId)
    {
        var companion = _context.Companions.FirstOrDefault(c => c.CompanionId == companionId);
        if (companion == default)
            throw new Exception($"Companion with Id({companionId}) was not found!");
        return companion;
    }
    
    public void AddCompanion(Companion companion)
    {
        _context.Companions.Add(companion);
        _context.SaveChanges();
    }

    public void ModifyCompanionName(Companion companion, string newName)
    {
        companion.CompanionName = newName;
        _context.SaveChanges();
    }
    
    public void ModifyCompanionActor(Companion companion, string newActorName)
    {
        companion.WhoPlayed = newActorName;
        _context.SaveChanges();
    }

    public void DeleteCompanion(Companion companion)
    {
        _context.Companions.Remove(companion);
        _context.SaveChanges();
    }
}