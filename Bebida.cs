class Bebida : Item
{
  // Atributo
  private string _tipoBebida;

  // Construtores
  public Bebida() { }

  public Bebida(string tipoBebida)
  {
    _tipoBebida = tipoBebida;
  }

  public Bebida(string tipoBebida, string idItem, int preco) 
  : base(idItem, preco)
  {
    _tipoBebida = tipoBebida;
  }

  // Gets e sets
  public override string getTipoBebida()
  {
    return _tipoBebida;
  }

  public override void setTipoBebida(string tipoBebida)
  {
    _tipoBebida = tipoBebida;
  }

  public override string ToString()
  {
    return "ID: " + getIdItem() + " | Item: " + _tipoBebida + " | Preço: R$ " + getPreco();
  }

}