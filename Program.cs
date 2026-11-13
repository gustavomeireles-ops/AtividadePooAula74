using AtividadeAula74;

//! Exercício 1
// Veiculo v1 = new Carro("Onix", "Chrevolet", 4);
// Veiculo v2 = new Motocicleta("Honda", "CB500", 500);

// v1.ExibirInformacoes();
// v2.ExibirInformacoes();

//! Exercício 5
// foreach (var frete in new List<Entrega> { new EntregaExpressa(), new EntregaEconomica(), new RetiradaLocal() })
// {
//     frete.Distancia = 200;
//     frete.CalcularFrete(); 
// }

//! Exercício 6
// Relatorio relatorio = new Relatorio();
// relatorio.Exportar();
// relatorio.Imprimir();

// Contrato contrato = new Contrato();
// contrato.Imprimir();

//! Exercício 7
// class Program
// {
//     static void Main(string[] args)
//     {
//         Notebook notebook = new Notebook("Dell XPS 15", "SN-987654", 16);
//         Smartphone smartphone = new Smartphone("Samsung Galaxy S24", "SN-123456", 256);

//         Console.WriteLine("Dados do Notebook");
//         notebook.ExibirInformacoes();

//         Console.WriteLine("\nDados do Smartphone");
//         smartphone.ExibirInformacoes();
//     }
// }

//! Exercício 8
//  List<Animal> animais = new List<Animal>
// {
//     new Cachorro("Cachorro"),
//     new Gato("Gato"),
//     new Passaro("Pássaro")
// };

// foreach (Animal animal in animais)
// {
//     animal.Apresentar(); 
//     animal.EmitirSom(); 
// }

//! Exercício 9
// class Program
// {
//     static void Main(string[] args)
//     {
//         IArmazenavel armazenamento;

//         armazenamento = new ArquivoTexto();
//         armazenamento.Salvar("Relatório financeiro de 2026.");
//         armazenamento.Ler();

//         Console.WriteLine(); 

//         armazenamento = new BancoDados();
//         armazenamento.Salvar("SELECT * FROM Usuarios;");
//         armazenamento.Ler();
//     }
// }

//! Exercício 10
class Program
{
    static void Main(string[] args)
    {
        IContratavel servicoContratavel;

        Hospedagem hospedagem = new Hospedagem("Hotel Fazenda Serra Azul");
        servicoContratavel = hospedagem;
        servicoContratavel.Contratar();

        servicoContratavel = new Consultoria("Consultoria em Arquitetura Cloud");
        servicoContratavel.Contratar();

        Console.WriteLine();

        ICancelavel servicoCancelavel = hospedagem;
        servicoCancelavel.Cancelar();
    }
}