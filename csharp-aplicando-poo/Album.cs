class Album
{
    private List<Music> musics = new List<Music>();
    public string Name { get; set; }
    public int TotalDuration => musics.Sum(m => m.Duration);
    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void DisplayAlbumsMusic()
    {
        Console.WriteLine($"Lista de músicas do álbum {Name}:\n");
        foreach (var music in musics)
        {
            Console.WriteLine($"Música: {music.Name}");
        }
        Console.WriteLine($"\nPara ouvir este àlbum inteiro você preisa de {TotalDuration}");
    }
}