
namespace AtividadeAula74
{
    public class Passaro : Animal
    {
        public Passaro(string Nome) : base(Nome)
        {
        }

        public override void EmitirSom()
        {
           Console.WriteLine($"Piu! Piu!");
        }
    }
}