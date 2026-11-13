
namespace AtividadeAula74
{
    public abstract class Animal
    {
        public string? Nome {get; set;}

        public Animal (string Nome)
        {
            this.Nome = Nome;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olhe, é um {Nome}!!!");
        }

        public abstract void EmitirSom();
        
    }
}