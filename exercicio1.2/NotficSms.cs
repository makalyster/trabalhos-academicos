class NotificacaoSMS : Notificacao
{
    public override void Enviar()
    {
        Console.WriteLine($"Enviando SMS para {Destinatario}\n");
        FormatarMensagem();
        RegistrarEstatistica();
    }

    public override void FormatarMensagem()
    {
        Console.WriteLine($"[SMS] Para: {Destinatario} \nMensagem: {Mensagem}");
    }
}
