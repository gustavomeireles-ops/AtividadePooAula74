
public class Hospedagem : Servico, IContratavel, ICancelavel
{
    public Hospedagem(string nome) : base(nome) { }

    public void Contratar()
    {
        Console.WriteLine($"[Hospedagem] O serviço \"{Nome}\" foi contratado. Reserva confirmada!");
    }

    public void Cancelar()
    {
        Console.WriteLine($"[Hospedagem] A reserva do serviço \"{Nome}\" foi cancelada.");
    }
}