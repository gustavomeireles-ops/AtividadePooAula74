
namespace AtividadeAula74
{
    public class EntregaEconomica : Entregas
    {
        public override void CalcularFrete()
        {
            decimal Frete = Distancia * 0.2m;
            Console.WriteLine($"O frete para a entrega de tipo econômica é de: {Frete}");
        }
        
    }
}