namespace AdonetHw.Models;

public class Artist
{
    public int Id { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public string Gender { get; set; }

    public override string ToString()
    {
        return $@"{Id} {Name} {Surname} {Birthday} {Gender}";
    }
}
