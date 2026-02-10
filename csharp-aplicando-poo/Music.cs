class Music
{
    public string Name { get; }
    public Band Artist { get; }
    public int Duration { get; set; }
    public bool Available { get; set; }

    public string Overview => $"A musica {Name} pertence à banda: {Artist}";

    public Music(Band artist, string name)
    {
        Artist = artist;
        Name = name;
    }

    public void DisplayTechnicalSpecification()
    {
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Artista: {Artist.Name}");
        Console.WriteLine($"Duração: {Duration}");
        if (Available)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adiquira o plano Plus+");
        }
    }
}