
namespace AtividadeAula74
{
    public class Cachorro : Animal
    {
        public Cachorro(string Nome) : base(Nome)
        {
        }

        public override void EmitirSom()
        {
           Console.WriteLine($"Au! Au!");
        }
    }
}