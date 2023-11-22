
List<(int id, string name, DateTime born)> list = new();
list.Add( (01,"gabriel",new DateTime(2000,03,14)) );
list.Add( (02,"girleide", new DateTime(1999,10,25)));
list.ForEach (x => Console.WriteLine($"lista de tuplas: {x.id}, {x.name}, {x.born}") );
