
namespace AtividadeAula74  
{
    public class EntregaExpressa : Entregas
    {
        public override void CalcularFrete()
        {
            decimal Frete = Distancia * 0.5m;
            Console.WriteLine($"O frete para a entrega de tipo expressa é de: {Frete}");
        }
    }
}