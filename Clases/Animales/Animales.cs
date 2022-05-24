namespace Animales
{
    abstract class Animal
    {
        public void Respirar()
        {
            WriteLine("Soy capaz de respirar");
        }

        public abstract void getNombre();
    }
}
