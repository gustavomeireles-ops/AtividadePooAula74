

namespace AtividadeAula74
{
    public abstract class ProdutoDigital
    {
        public string? Nome { get; set; }

        public decimal? Preco { get; set; }
    
        public ProdutoDigital(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
        
    }
}