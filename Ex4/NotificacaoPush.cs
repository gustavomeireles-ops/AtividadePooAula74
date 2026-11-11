using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeAula74
{
    public class NotificacaoPush : Notificacao
    {
        public override void EnviarNotificacao(string mensagem)
        {
            Console.WriteLine($"Notificação por push sendo enviada: {mensagem}");
        }
        
    }
}