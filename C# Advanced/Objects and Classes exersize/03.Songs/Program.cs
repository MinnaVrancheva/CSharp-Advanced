
int numberOfSongs = int.Parse(Console.ReadLine());
List<Song> songsType = new List<Song>();

for (int i = 0; i < numberOfSongs; i++)
{
    string[] input = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries);
    string type = input[0];
    string songName = input[1];
    string songDuration = input[2];

    Song song = new Song();
    song.Name = songName;
    song.TypeList = type;
    song.Time = songDuration;

    songsType.Add(song);
}

string command2 = Console.ReadLine();

if (command2 == "all")
{
    foreach (Song song in songsType)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    List<Song> filteredSongs = songsType.Where(t => t.TypeList == command2).ToList();
    
    foreach (Song song in filteredSongs)
    {
        Console.WriteLine(song.Name);
    }
}

public class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }

}
