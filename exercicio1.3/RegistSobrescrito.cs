class RegistroSobrescrito : RegistroBase
{
    public override void Salvar()
    {
        Console.WriteLine("RegistroSobrescrito: Salvando com sobrescrita...");
    }
}
