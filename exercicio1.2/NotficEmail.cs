
class NotificacaoEmail : Notificacao
{
    public override void Enviar()
    {
        Console.WriteLine($"Enviando e-mail para {Destinatario}\n");
        FormatarMensagem();
        RegistrarEstatistica();
    }

    public override void FormatarMensagem()
    {
        Console.WriteLine($"[E-mail] Para: {Destinatario} \nMensagem: {Mensagem}");
    }
}

