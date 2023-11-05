using AdonetHw.Models;
using AdonetHw.Services;

//ArtistService artistService= new ArtistService();
//Artist artist = new Artist()
//{
//    Name = "Leyla",
//    Surname = "Shafiyeva",
//    Birthday = DateTime.Now,
//    Gender = "Female"
//};
//artistService.Create(artist);



//artistService.Delete(4);

//List<Artist> artists = artistService.GetAll();


//foreach (Artist item in artists)
//{
//    Console.WriteLine(item);
//}

//Artist artist1 = artistService.GetById(3);
//Console.WriteLine(artist1);

MusicService ms = new MusicService();
Music music = new Music()
{
    Name = "Hello",
    Duration = 1000,
    
    IsDeleted = false,
};

//ms.Create(music);

//Console.WriteLine(ms.GetById(6));



ms.Delete(6);

List<Music> musics = ms.GetAll();


foreach (Music musicc in musics)
{
    Console.WriteLine(musicc);
}