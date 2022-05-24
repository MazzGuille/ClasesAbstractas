namespace Clases
{
     class Mamiferos : Animal
    {
        //public Mamiferos()
        //{

        //}

        public Mamiferos(String nombre, int ojos)
        {
            nombreSerVivo = nombre;
            numeroDeOjos = ojos;
        }
        public virtual void Pensar()
        {
            WriteLine("Pensamiento basico e instintivo");
        }

        public void CuidarCrias()
        {
            WriteLine("Cuido de mis crias hasta que se valgan por si mismos");
        }

        public override void getNombre()
        {
            WriteLine($"El nombre del mamifero es: {nombreSerVivo}");
        }

        public void getOjos()
        {
            WriteLine($"El ser vivo tiene {numeroDeOjos} ojos");
        }

        private String nombreSerVivo;

        private int numeroDeOjos;
    }
}