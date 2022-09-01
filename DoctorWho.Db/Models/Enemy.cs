using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.Db.Models;
[Table(nameof(Enemy))]
public class Enemy
{
    public Enemy()
    {
        Episodes = new List<Episode>();
    }
    
    public int EnemyId { get; set; }
    public string EnemyName { get; set; }
    public string Description { get; set; }

    public List<Episode> Episodes { get; set; }
}