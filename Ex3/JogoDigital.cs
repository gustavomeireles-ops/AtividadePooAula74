

namespace AtividadeAula74
{
    public class JogoDigital : Jogo
    {
        public int tamanhobyte { get; set; }
        public JogoDigital(string nome, string plataforma, int mb)
        {
            Nome = nome;
            Plataforma = plataforma;
            this.tamanhobyte = tamanhobyte;
            Console.WriteLine($"Nome: {Nome}, Plataforma: {Plataforma}, Tamanho: {tamanhobyte} MB");
        }
    }
}