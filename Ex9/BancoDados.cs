using AtividadeAula74;

public class BancoDados : IArmazenavel
{
    private string _registroBanco = string.Empty;

    public void Salvar(string conteudo)
    {
        _registroBanco = conteudo;
        Console.WriteLine($"[Banco de Dados] Inserindo registro na tabela: \"{conteudo}\"");
    }

    public void Ler()
    {
        Console.WriteLine($"[Banco de Dados] Consultando registro na tabela: \"{_registroBanco}\"");
    }
}