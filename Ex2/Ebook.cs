

namespace AtividadeAula74
{
    public class Ebook : ProdutoDigital
    {
        public int QuantidadePaginas { get; set; }
        
        public Ebook(string nome, decimal preco, int quantidadePaginas) : base(nome, preco)
        {
            QuantidadePaginas = quantidadePaginas;
        }

    }
}