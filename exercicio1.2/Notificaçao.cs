class Notificacao
{
    public string Destinatario { get; set; }
    public string Mensagem { get; set; }
    public DateTime DataEnvio { get; set; }

    public virtual void Enviar()
    {
        Console.WriteLine("Enviando notificação genérica\n");
        FormatarMensagem();
        RegistrarEstatistica();
    }

    public virtual void FormatarMensagem()
    {
        Console.WriteLine($"[Mensagem] Para: {Destinatario} \nMensagem: {Mensagem}");
    }

    public void RegistrarEstatistica()
    {
        Console.WriteLine($"[LOG] Enviado para {Destinatario} em {DateTime.Now}");
    }
}

