Clear();

Perros perro1 = new("Negra", 2);
Caballos caballo1 = new("Epona", 2);
IMamiferosTerrestres Icaballo11 = caballo1;
ISaltoConPatas Icaballo12 = caballo1;

WriteLine($"Epona tiene {Icaballo11.NumeroPatas()} patas");
WriteLine($"Epona salta con {Icaballo12.NumeroPatas()} patas");
WriteLine($"Negra tiene {perro1.NumeroPatas()} patas");

Lagartijas lagarto1 = new("Sanke");
Humanos humano1 = new("Guille", 2);
Chimpance chimpance1 = new("Chita", 2);

lagarto1.Respirar();
lagarto1.getNombre();
humano1.Respirar();
humano1.getNombre();
chimpance1.getNombre();
chimpance1.getOjos();
chimpance1.Respirar();



WriteLine("El programa ha finalizado, presiona cualquier tecla para continuar");
ReadKey();
Clear();
