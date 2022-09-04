using DoctorWho.Db;
using DoctorWho.Db.Models;

namespace DoctorWho;

public class DoctorRepository
{
    private readonly DoctorWhoCoreDbContext _context;

    public DoctorRepository()
    {
        _context = new DoctorWhoCoreDbContext();
    }
    
    public void AddDoctor(Doctor doctor)
    {
        _context.Doctors.Add(doctor);
        _context.SaveChanges();
    }

    public void ModifyDoctorName(Doctor doctor, string newName)
    {
        doctor.DoctorName = newName;
        _context.SaveChanges();
    }
    
    public void ModifyDoctorNumber(Doctor doctor, int newNumber)
    {
        doctor.DoctorNumber = newNumber;
        _context.SaveChanges();
    }
    
    public void ModifyDoctorBirth(Doctor doctor, DateTime newBirth)
    {
        doctor.BirthDate = newBirth;
        _context.SaveChanges();
    }
    
    public void ModifyDoctorFirstEpisode(Doctor doctor, DateTime newDate)
    {
        doctor.FirstEpisodeDate = newDate;
        _context.SaveChanges();
    }
    public void ModifyDoctorLastEpisode(Doctor doctor, DateTime newDate)
    {
        doctor.LastEpisodeDate = newDate;
        _context.SaveChanges();
    }

    public void DeleteDoctor(Doctor doctor)
    {
        _context.Doctors.Remove(doctor);
        _context.SaveChanges();
    }
}