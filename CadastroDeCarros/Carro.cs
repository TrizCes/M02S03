namespace CadastroDeCarros
{
  public class Carro
  {
    public string marca { get; set; }
    public string modelo { get; set; }
    public string placa { get; set; }
    public string cor { get; set; }
    public string ano { get; set; }
    public string renavam { get; set; }
    public Proprietario proprietario { get; set; }
  }
}
