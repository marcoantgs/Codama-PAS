public class Hamburguer : Item
{
  // Atributo
  private string _tipoCarne;

  // Construtores
  public Hamburguer() { }

  public Hamburguer(string tipoCarne)
  {
    _tipoCarne = tipoCarne;
  }

  public Hamburguer(string tipoCarne, string idItem, int preco) 
  : base(idItem, preco)
  {
    _tipoCarne = tipoCarne;
  }
  
  // Gets e sets
  public override string getTipoCarne()
  {
    return _tipoCarne;
  }

  public override void setTipoCarne(string tipoCarne)
  {
    _tipoCarne = tipoCarne;
  }

  public override string ToString()
  {
    return "ID: " + getIdItem() + " | Item: Hambúrguer" + " | Carne: " + _tipoCarne + " | Preço: R$ " + getPreco();
  }

}