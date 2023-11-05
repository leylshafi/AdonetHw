namespace AdonetHw.Models;

public class Music
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Duration { get; set; }
    public bool IsDeleted { get; set; }

    public override string ToString()
    {
        return $@"{Id}  {Name}  {Duration}  {IsDeleted}";
    }
}
