using AtividadeAula74;

public class ArquivoTexto : IArmazenavel
{
    private string _dadosSalvos = string.Empty;

    public void Salvar(string conteudo)
    {
        _dadosSalvos = conteudo;
        Console.WriteLine($"[Arquivo de Texto] Salvando o conteúdo no arquivo: \"{conteudo}\"");
    }

    public void Ler()
    {
        Console.WriteLine($"[Arquivo de Texto] Lendo o conteúdo do arquivo: \"{_dadosSalvos}\"");
    }
}