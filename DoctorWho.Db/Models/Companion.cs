﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.Db.Models;
[Table(nameof(Companion))]
public class Companion
{
    public Companion()
    {
        Episodes = new List<Episode>();
    }
    
    public int CompanionId { get; set; }
    public string CompanionName { get; set; }
    public string WhoPlayed { get; set; }

    public List<Episode> Episodes { get; set; }
}