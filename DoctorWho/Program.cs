using System.Data;
using DoctorWho.Db;
using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho;

public class Program
{
    public static void PrintCompanions(int episodeId)
    {
        using var context = new DoctorWhoCoreDbContext();
        var companions = context.Episodes.Select(e => context.GetCompanions(episodeId)).FirstOrDefault();
        Console.WriteLine(companions);
    }
    
    public static void PrintEnemies(int episodeId)
    {
        using var context = new DoctorWhoCoreDbContext();
        var companions = context.Episodes.Select(e => context.GetEnemies(episodeId)).FirstOrDefault();
        Console.WriteLine(companions);
    }

    public static void SummariseEpisodes()
    {
        using var context = new DoctorWhoCoreDbContext();
        context.Database.OpenConnection();
        var cmd = context.Database.GetDbConnection().CreateCommand();
        cmd.CommandText = "dbo.spSummariseEpisodes";
        var reader = cmd.ExecuteReader();
        var companions = new List<EpisodeSummaryCompanion>();
        var enemies = new List<EpisodeSummaryEnemy>();

        while (reader.Read())
        {
            companions.Add(new EpisodeSummaryCompanion
            {
                CompanionName = reader.GetString("CompanionName"),
                TimesAppeared = reader.GetInt32("TimesAppeared")
            });
        }

        reader.NextResult();

        while (reader.Read())
        {
            enemies.Add(new EpisodeSummaryEnemy
            {
                EnemyName = reader.GetString("EnemyName"),
                TimesAppeared = reader.GetInt32("TimesAppeared")
            });
        }
        reader.Close();
        context.Database.CloseConnection();

        Console.WriteLine("-------\nCompanion Summary\n-------");
        foreach (var companion in companions)
        {
            Console.WriteLine($"{companion.CompanionName}\n" +
                              $"{companion.TimesAppeared}\n--------");
        }
        
        Console.WriteLine("-------\nEnemy Summary\n-------");
        foreach (var enemy in enemies)
        {
            Console.WriteLine($"{enemy.EnemyName}\n" +
                              $"{enemy.TimesAppeared}\n--------");
        }
    }

    public static void ListAllEpisodes()
    {
        using var context = new DoctorWhoCoreDbContext();
        var episodesWithInfo = context.EpisodesWithInfo
            .FromSqlRaw("SELECT * FROM dbo.viewEpisodes").ToList();
        foreach (var episode in episodesWithInfo)
        {
            Console.WriteLine($"{episode.AuthorName}\n" +
                              $"{episode.Companions}\n" 
                              + $"{episode.DoctorName}\n-----------");
        }
    }
    public static void Main()
    {
    }
}