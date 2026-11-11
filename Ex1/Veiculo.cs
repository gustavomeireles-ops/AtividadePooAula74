namespace AtividadeAula74
{
    public class Veiculo
    {
        public string? Marca { get; set;}

        public string? Modelo { get; set;}
        
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($" O veículo da Marca: {Marca}, pertence ao Modelo: {Modelo}");
        }
        
    }
}