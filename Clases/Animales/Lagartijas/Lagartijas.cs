namespace Lagartija
{
    internal class Lagartijas : Animal
    { 
        public Lagartijas(String nombre)
        {
            nombreReptil = nombre;
        }
        
        public override void getNombre()
        {
            WriteLine($"El nombre de la lagartija es {nombreReptil}");
        }

        private String nombreReptil;
    }
}
