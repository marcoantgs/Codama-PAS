// Classe abstrata Item
// Princípio da inversão de dependência : SOLID
/*A utilização da classe abstrata Item nos permite ter flexibilidade,pois podemos criar novos itens diferentes quando necessário com facilidade. */
public abstract class Item
{
    // Atributos
    private string _idItem;
    private int _preco;

    // Construtores
    public Item() { }

    public Item(string idItem, int preco)
    {
        _idItem = idItem;
        _preco = preco;
    }

    // Gets e sets
    public string getIdItem()
    {
        return _idItem;
    }

    public float getPreco()
    {
        return _preco;
    }
    
    public void setIdItem(string idItem)
    {
        _idItem = idItem;
    }

    public void setPreco(int preco)
    {
        _preco = preco;
    }

    // Utilização de sobrecarga de operadores (operador +)
    public static int operator+(Item i1, Item i2)
    {
        int soma;

        soma = i1._preco + i2._preco;

        return soma;
    }

    // Métodos virtuais
    // Polimorfismo : GRASP
    /* A utilização de métodos virtuais nos permite reaproveita-los e personaliza-los de acordo com a necessidade de cada classe onde esses serão utilizados
    
    */
    public virtual string getTipoCarne()
    {
        return "";
    }

    public virtual string getQtdSalsichas()
    {
        return "";
    }

    public virtual string getTipoBebida()
    {
        return "";
    }

    public virtual void setTipoCarne(string tipoCarne) { }

    public virtual void setQtdSalsichas(string qtdSalsichas) { }

    public virtual void setTipoBebida(string tipoBebida) { }

}