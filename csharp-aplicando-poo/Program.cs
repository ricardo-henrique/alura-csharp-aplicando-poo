Album QueensAlbum = new Album();
QueensAlbum.Name = "A night at the opera";

Music music1 = new Music();
music1.Name = "Love of my life";
music1.Duration = 213;

Music music2 = new Music();
music2.Name = "Bohemia Rhapsody";
music2.Duration = 354;

QueensAlbum.AddMusic(music1);
QueensAlbum.AddMusic(music2);

QueensAlbum.DisplayAlbumsMusic();