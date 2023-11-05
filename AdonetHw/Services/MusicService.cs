using AdonetHw.Data;
using AdonetHw.Models;
using System.Data;

namespace AdonetHw.Services;

public class MusicService
{
    private Sql _database = new Sql();

    public void Create(Music music)
    {
        string cmd = $"INSERT INTO Musics(Name,Duration,IsDeleted) VALUES('{music.Name}',{music.Duration},'{music.IsDeleted}')";
        int result = _database.ExecuteCommand(cmd);
        if (result > 0)
        {
            Console.WriteLine("Command successfully completed");
        }
        else
        {
            Console.WriteLine("Error occured");
        }

    }

    public Music GetById(int id)
    {
        string query = $"SELECT * FROM Musics WHERE Id={id}";
        DataTable table = _database.ExecuteQuery(query);

        if (table.Rows.Count > 0)
        {
            Music music = new Music
            {
                Id = Convert.ToInt32(table.Rows[0]["Id"]),
                Name = table.Rows[0]["Name"].ToString(),
                Duration = Convert.ToInt32(table.Rows[0]["duration"]),
                IsDeleted = (bool)table.Rows[0]["isdeleted"]
            };

            return music;

        }

        return null;
    }

    public List<Music> GetAll()
    {
        string query = "SELECT * FROM Musics";
        DataTable table = _database.ExecuteQuery(query);

        List<Music> musics = new List<Music>();

        foreach (DataRow row in table.Rows)
        {
            Music music = new Music
            {
                Id = (int)row["id"],
                Name = (string)row["name"],
                Duration = (int)table.Rows[0]["duration"],
                IsDeleted = (bool)table.Rows[0]["isdeleted"]

            };
            

            musics.Add(music);
        }
        return musics;
    }

    public void Delete(int id)
    {
        string cmd = $"DELETE FROM Musics WHERE Id={id}";
        _database.ExecuteCommand(cmd);
    }

}
