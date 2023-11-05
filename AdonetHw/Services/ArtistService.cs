using AdonetHw.Data;
using AdonetHw.Models;
using System.Data;
using System.Data.SqlClient;

namespace AdonetHw.Services;

public class ArtistService
{
    private Sql _database = new Sql();

    public void Create(Artist artist)
    {
        string cmd = $"INSERT INTO Artists VALUES('{artist.Surname}','{artist.Name}','{artist.Birthday}','{artist.Gender}')";
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

    public Artist GetById(int id)
    {
        string query = $"SELECT * FROM Artists WHERE Id={id}";
        DataTable table = _database.ExecuteQuery(query);

        if (table.Rows.Count > 0)
        {
            Artist artist = new Artist
            {
                Id = Convert.ToInt32(table.Rows[0]["Id"]),
                Name = table.Rows[0]["Name"].ToString(),
            };

            return artist;

        }

        return null;
    }

    public List<Artist> GetAll()
    {
        string query = "SELECT * FROM Artists";
        DataTable table = _database.ExecuteQuery(query);

        List<Artist> artists = new List<Artist>();

        foreach (DataRow row in table.Rows)
        {
            Artist artist = new Artist()
            {
                Id = (int)row["id"],
                Name = (string)row["name"],
                Surname = (string)row["surname"],
                Birthday = (DateTime)row["Birthday"],
                Gender = (string)row["gender"]
            };

            artists.Add(artist);
        }
        return artists;
    }

    public void Delete(int id)
    {
        string cmd = $"DELETE FROM Artists WHERE Id={id}";
        _database.ExecuteCommand(cmd);
    }

}
