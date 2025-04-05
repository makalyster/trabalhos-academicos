class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Notificacao> notificacoes = new List<Notificacao>
        {
            new NotificacaoEmail { Destinatario = "alice@email.com", Mensagem = "Bem-vinda!", DataEnvio = DateTime.Now },
            new NotificacaoSMS { Destinatario = "+5511999999999", Mensagem = "Seu código é 1234", DataEnvio = DateTime.Now },
            new NotificacaoPush { Destinatario = "usuário123", Mensagem = "Você tem uma nova conquista!", DataEnvio = DateTime.Now }
        };

        foreach (var notificacao in notificacoes)
        {
            notificacao.Enviar();
            Console.WriteLine();
        }
    }
}
