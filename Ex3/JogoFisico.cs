

namespace AtividadeAula74
{
    public class JogoFisico : Jogo
    {
        public int quantidadeCDs { get; set; }
        public JogoFisico(string nome, string plataforma, int quantidadeCD)
        {
            Nome = nome;
            Plataforma = plataforma;
            quantidadeCD = quantidadeCDs;
            Console.WriteLine($"Nome: {Nome}, Plataforma: {Plataforma}, Quantidade de CDs: {quantidadeCDs}");
        }
    }
}