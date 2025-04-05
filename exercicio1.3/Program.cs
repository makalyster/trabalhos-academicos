class Program
{
    static void Main(string[] args)
    {
        //variavelObjeto nomeObjeto = new classeMolde;

        RegistroBase sobrescrito = new RegistroSobrescrito();
        sobrescrito.Salvar(); // vai chamar o sobrescrito 

    
        RegistroBase ocultoBase = new RegistroOculto();
        ocultoBase.Salvar(); //chama do base pq n foi sobrescrito

        
        RegistroOculto oculto = new RegistroOculto();
        oculto.Salvar(); // chama do oculto

    }
}
