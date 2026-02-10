Episode ep1 = new(1, "técnicas de falicitação", 45);
ep1.addGuests("Maria");
ep1.addGuests("Marcelo");


Episode ep2 = new(2, "técnicas de aprendizado", 67);
ep2.addGuests("Fernando");
ep2.addGuests("Marcos");
ep2.addGuests("Flavia");


Podcast podcast = new("Podcast especial", "Daniel");
podcast.AddEpisode(ep1);
podcast.AddEpisode(ep2);
podcast.DisplayDetails();