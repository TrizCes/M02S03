using CadastroDeCarros;
internal class Program
{
  private static void Main(string[] args)
  {
    Proprietario proprietario1 = new Proprietario()
    {
      nome = "Beatriz",
      cpf = "987.753.159-64",
      telefone = "(47) 96547-7895",
      endereco = "Rua Bela Vista, nº 821"
    };
    proprietario1.CadastrarProprietario();

    Proprietario proprietario2 = new Proprietario()
    {
      nome = "Vopen",
      cpf = "673.660.120-76",
      telefone = "(47) 96547-7895",
      endereco = "Rua Três Barras, nº 377"
    };
    proprietario2.CadastrarProprietario();

    Proprietario proprietario3 = new Proprietario()
    {
      nome = "Melra",
      cpf = "962.075.940-02",
      telefone = "(47) 96547-7895",
      endereco = "Rua Professor José Motta, nº 99"
    };
    proprietario3.CadastrarProprietario();

  }
}
