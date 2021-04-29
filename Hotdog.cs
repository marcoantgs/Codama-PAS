public class Hotdog : Item
{
  // Atributo
  private string _qtdSalsichas;

  // Construtores
  public Hotdog() { }

  public Hotdog(string qtdSalsichas)
  {
    _qtdSalsichas = qtdSalsichas;
  }

  public Hotdog(string qtdSalsichas, string idItem, int preco) 
  : base(idItem, preco)
  {
    _qtdSalsichas = qtdSalsichas;
  }

  // Gets e sets
  public override string getQtdSalsichas()
  {
    return _qtdSalsichas;
  }

  public override void setQtdSalsichas(string qtdSalsichas)
  {
    _qtdSalsichas = qtdSalsichas;
  }

  public override string ToString()
  {
    return "ID: " + getIdItem() + " | Item: Hot dog" + " | Salsichas: " + _qtdSalsichas + " | Preço: R$ " + getPreco();
  }

}