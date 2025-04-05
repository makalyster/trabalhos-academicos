class NotificacaoPush : Notificacao
{
    public override void Enviar()
    {
        Console.WriteLine($"Enviando push para {Destinatario}\n");
        FormatarMensagem();
        RegistrarEstatistica();
    }

    public override void FormatarMensagem()
    {
        Console.WriteLine($"[Push] Para: {Destinatario} \nMensagem: {Mensagem}");
    }
}