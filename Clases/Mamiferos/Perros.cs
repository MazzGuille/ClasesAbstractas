namespace Clases
{
     class Perros : Mamiferos, IMamiferosTerrestres
    {
        public Perros(String nombrePerro, int cantidadDeOjos) : base(nombrePerro, cantidadDeOjos)
        {

        }
        public void Ladrar()
        {
            WriteLine("Estoy ladrando");            
        }

        public int NumeroPatas()
        {
            return 4;
        }
    }
}