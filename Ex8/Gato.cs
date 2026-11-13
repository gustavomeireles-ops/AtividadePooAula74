
namespace AtividadeAula74
{
    public class Gato : Animal
    {
        public Gato(string Nome) : base(Nome)
        {
        }

        public override void EmitirSom()
        {
           Console.WriteLine($"Miau!");
        }
    }
}