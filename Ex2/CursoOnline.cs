
namespace AtividadeAula74
{
    public class CursoOnline : ProdutoDigital
    {
        public int DuracaoHoras { get; set; }
        
        public CursoOnline(string nome, decimal preco, int duracaoHoras) : base(nome, preco)
        {
            DuracaoHoras = duracaoHoras;
        }
        
    }
}