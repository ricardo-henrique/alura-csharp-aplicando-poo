Music music1 = new Music();

music1.Name = "castelo forte";
music1.Artist = "HCC";
music1.Duration = 274;
music1.Available = true;
Console.WriteLine(music1.Overview);


Music music2 = new Music();
music2.Name = "Eduardo e Mônica";
music2.Artist = "legião Urbana";
music2.Duration = 258;
music2.Available = false;


music1.DisplayTechnicalSpecification();
music2.DisplayTechnicalSpecification();