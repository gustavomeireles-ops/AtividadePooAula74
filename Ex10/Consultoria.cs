
public class Consultoria : Servico, IContratavel
{
    public Consultoria(string nome) : base(nome) { }

    public void Contratar()
    {
        Console.WriteLine($"[Consultoria] O pacote \"{Nome}\" foi contratado. Aguardando agendamento com especialista.");
    }
}