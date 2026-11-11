using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeAula74
{
    public class NotificacaoEmail : Notificacao
    {
        public override void EnviarNotificacao(string mensagem)
        {
            Console.WriteLine($"Notificação por e-mail sendo enviada: {mensagem}");
        }
    }
}