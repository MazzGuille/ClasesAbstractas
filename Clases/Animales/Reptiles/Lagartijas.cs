namespace Lagartija
{
    internal class Lagartijas : Animal
    { 
        public Lagartijas(String nombre)
        {
            nombreLagarto = nombre;
        }
        
        public override void getNombre()
        {
            WriteLine($"El nombre de la lagartija es {nombreLagarto}");
        }

        private String nombreLagarto;
    }
}
