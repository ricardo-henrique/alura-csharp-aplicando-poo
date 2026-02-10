class Band
{
    private List<Album> albums = new List<Album>();
    public string Name { get; }

    public Band(string name)
    {
        Name = name;
    }
    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void displayDics()
    {
        Console.WriteLine($"Discografia da Banda {Name}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Name} ({album.TotalDuration})");
        }
    }
}