class Program
{
    static void Main()
    {
        // Cria Texto
        var texto = new DocumentoTexto("Relatorio", "Alice", DateTime.Now, "Isso é um relatorio.");

        // Cria HTML 
        var html = new DocumentoHtml ("Pagina", "Bob", DateTime.Now, "<h1>!odnum alO</h1>");

        // Cria PDF 
        var pdf = new DocumentoPdf("Contrato", "Carol", DateTime.Now, "Isso é um contrato.");
        pdf.AdicionarMarcaDagua("UltraConfidencial");

        //Lista de documentos
        List<Documento> documentos = new List<Documento> { texto, html, pdf };

        // Processa os documentos
        var processador = new GerenciadorDocumentos();
        processador.ProcessarColecao(documentos);

        //Conta palavras
        Console.WriteLine($"Palavras no DocumentoTexto: {texto.ContarPalavras()}");
    }
}
