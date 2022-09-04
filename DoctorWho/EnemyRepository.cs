using DoctorWho.Db;
using DoctorWho.Db.Models;

namespace DoctorWho;

public class EnemyRepository
{
    private readonly DoctorWhoCoreDbContext _context;

    public EnemyRepository()
    {
        _context = new DoctorWhoCoreDbContext();
    }
    
    public void AddEnemy(Enemy enemy)
    {
        _context.Enemies.Add(enemy);
        _context.SaveChanges();
    }

    public void ModifyEnemyName(Enemy enemy, string newName)
    {
        enemy.EnemyName = newName;
        _context.SaveChanges();
    }
    
    public void ModifyEnemyDescription(Enemy enemy, string newDescription)
    {
        enemy.Description = newDescription;
        _context.SaveChanges();
    }

    public void DeleteEnemy(Enemy enemy)
    {
        _context.Enemies.Remove(enemy);
        _context.SaveChanges();
    }
}