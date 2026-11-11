
namespace AtividadeAula74
{
    public class Motocicleta : Veiculo
    {
        public int Cilindradas { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Cilindradas: {Cilindradas}");
        }

        public Motocicleta(string marca, string modelo, int cilindradas) : base()
        {
            Marca = marca;
            Modelo = modelo;
            Cilindradas = cilindradas;
        }

    }
}