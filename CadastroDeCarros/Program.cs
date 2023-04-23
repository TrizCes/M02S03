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

    Proprietario proprietario2 = new Proprietario()
    {
      nome = "Vopen",
      cpf = "673.660.120-76",
      telefone = "(47) 96547-7895",
      endereco = "Rua Três Barras, nº 377"
    };

    Proprietario proprietario3 = new Proprietario()
    {
      nome = "Melra",
      cpf = "962.075.940-02",
      telefone = "(47) 96547-7895",
      endereco = "Rua Professor José Motta, nº 99"
    };

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

    menuIniciar();

    void AddCarro()
    {

      Proprietario proprietario = new Proprietario() { };
      Carro carro = new Carro();

      Console.WriteLine($"----------------------------------------------------");
      Console.WriteLine("            Vamos cadastrar novo veículo:            ");
      Console.WriteLine($"----------------------------------------------------");

      Console.Write("\nQual é o nome do proprietário do veículo?: ");
      proprietario.nome = Console.ReadLine();
      Console.Write("Qual é o cpf do proprietário do veículo?: ");
      proprietario.cpf = Console.ReadLine();
      Console.Write("Qual é o telefone do proprietário do veículo?: ");
      proprietario.telefone = Console.ReadLine();
      Console.Write("Qual é o endereço do proprietário do veículo?: ");
      proprietario.endereco = Console.ReadLine();

      carro.proprietario = proprietario;

      Console.WriteLine("Vamos aos dados do veículo:");
      Console.Write("Qual é a MARCA do veículo?: ");
      carro.marca = Console.ReadLine();
      Console.Write("Qual é o MODELO do veículo?: ");
      carro.modelo = Console.ReadLine();
      Console.Write("Qual é a COR do veículo?: ");
      carro.cor = Console.ReadLine();
      Console.Write("Qual é o ANO do veículo?: ");
      carro.ano = Console.ReadLine();
      Console.Write("Qual é a PLACA do veículo?: ");
      carro.placa = Console.ReadLine();
      Console.Write("Qual é o RENAVAM do veículo?: ");
      carro.renavam = Console.ReadLine();

      listaCarros.Add(carro);
      Console.WriteLine($"\n \nVeículo {listaCarros[listaCarros.Count - 1].modelo}, de {listaCarros[listaCarros.Count - 1].proprietario.nome} foi cadastrado com sucesso!\n");

      Console.WriteLine("\nAgradecemos por usar nosso \nsistema de cadastro!\n");
    }

    void ExibirCarros()
    {
      Console.WriteLine("Veículos cadastrados: ");
      foreach (var item in listaCarros)
      {
        Console.WriteLine($"__________________________________________");
        Console.WriteLine($"Marca:        | {item.marca}");
        Console.WriteLine($"Modelo:       | {item.modelo}");
        Console.WriteLine($"Cor:          | {item.cor}");
        Console.WriteLine($"Ano:          | {item.ano}");
        Console.WriteLine($"Placa:        | {item.placa}");
        Console.WriteLine($"Renavam:      | {item.renavam}");
        Console.WriteLine($"------------------------------------------");
        Console.WriteLine($"Proprietário:\n|Nome: {item.proprietario.nome}|\n|Tel:  {item.proprietario.telefone}|\n|CPF:  {item.proprietario.cpf}|\n|End.: {item.proprietario.endereco}|");
        Console.WriteLine($"__________________________________________");
      }

    };

    void menuIniciar()
    {
      string itemMenu;

      Console.WriteLine(" Bem Vindo(a) ao sistema de cadastro de veículos C#.");
      do
      {
        Console.WriteLine($"----------------------------------------------------");
        Console.WriteLine($"                   Menu de opções:                  ");
        Console.WriteLine($"Para cadastrar um veículo digite:              1    ");
        Console.WriteLine($"Para acessar nossa lista de veículos digite:   2    ");
        Console.WriteLine($"Para SAIR digite:                              3    ");
        Console.WriteLine($"----------------------------------------------------");
        Console.Write($"Digite sua escolha:   ");
        itemMenu = Console.ReadLine();

        if (itemMenu == "1")
        {
          AddCarro();
        }
        else if (itemMenu == "2")
        {
          ExibirCarros();
        }
        else if (itemMenu != "3")
        {
          Console.WriteLine($"\n\n\nOpção indisponível, tente novamente.\n\n\n");
        };

      } while (itemMenu != "3");
    };
  }

}
