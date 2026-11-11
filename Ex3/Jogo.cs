

namespace AtividadeAula74
{
    public abstract class Jogo
    {
        public string? Nome { get; set; }

        protected string? Plataforma { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Plataforma: {Plataforma}");
        }
    }
}