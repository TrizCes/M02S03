using CadastroDeCarros;

internal class NewBaseType
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

    Carro carro1 = new Carro()
    {
      marca = "Jaguar",
      modelo = "XJS-C 6.0 V12",
      placa = "MFX1809",
      ano = "1994",
      cor = "Azul",
      renavam = "61814316621",
      proprietario = proprietario1,
    };

    Carro carro2 = new Carro()
    {
      marca = "Seat",
      modelo = "Cordoba Vario 1.6L",
      placa = "MDQ5886",
      ano = "2000",
      cor = "Marrom",
      renavam = "97984853386",
      proprietario = proprietario2,
    };

    Carro carro3 = new Carro()
    {
      marca = "Dodge",
      modelo = "Dakota 2.5",
      placa = "MJY8958",
      ano = "1998",
      cor = "Bege",
      renavam = "50623176978",
      proprietario = proprietario3,
    };

    List<Carro> listaCarros = new List<Carro>();

    listaCarros.Add(carro1);
    listaCarros.Add(carro2);
    listaCarros.Add(carro3);
  }
}
