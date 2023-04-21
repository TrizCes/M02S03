namespace CadastroDeCarros
{
  public class Proprietario
  {
    public int idDeCadastro { get; set; }
    public string nome { get; set; }
    public string cpf { get; set; }
    public string telefone { get; set; }
    public string endereco { get; set; }

    public Proprietario()
    {
      idDeCadastro = new Random().Next(10000, 99999);
    }
    public void CadastrarProprietario()
    {
      Console.WriteLine($"Cadastro de {nome} realizado com sucesso! ID: {idDeCadastro}");
    }
  }
}