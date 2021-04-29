using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

/*
Pure fabrication (fabricação/invenção pura): GRASP
É uma classe que não representa nenhum conceito no domínio do problema, ela apenas funciona como uma classe prestadora de serviços, e é projetada para que possamos ter um baixo acoplamento e alta coesão no sistema.
// Classe que representa
*/
class Lanchonete : IVerPedidos
{
    // Atributo
    private List<Pedido> _pedidos = new List<Pedido>();

    // Construtor
    public Lanchonete() { }

    // Gets e Sets
    public List<Pedido> getPedidos()
    {
        return _pedidos;
    }

    public void setPedidos(List<Pedido> pedidos)
    {
        _pedidos = pedidos;
    }

    // Método para cadastrar pedidos no sistema
    public void CadastrarPedido()
    {
        Pedido pedido = new Pedido();
        List<Item> itens = new List<Item>();
        int somaValorItens = 0;

        Console.WriteLine("CADASTRAR PEDIDO");
        Console.WriteLine();

        bool iniciarPedido = true;

        while (iniciarPedido == true)
        {
            Console.Write("> Digite o ID do pedido: ");
            string idPedido = Console.ReadLine();

            // Verificando se o ID do pedido é válido
            while (true)
            {
                try
                {
                    pedido.VerificarIdPedido(idPedido);
                    break;
                }
                catch (IdInvalido)
                {
                    Console.WriteLine("ID inválido!");
                    Console.Write("> Por favor, tente novamente: ");
                    idPedido = Console.ReadLine();
                }
            }

            Console.Write("> Digite o nome do cliente: ");
            string nomeCliente = Console.ReadLine();

            // Verificando se o nome do cliente é válido
            while (true)
            {
                try
                {
                    pedido.VerificarNomeCliente(nomeCliente);
                    break;
                }
                catch (NomeInvalido)
                {
                    Console.WriteLine("Nome inválido!");
                    Console.Write("> Por favor, tente novamente: ");
                    nomeCliente = Console.ReadLine();
                }
            }

            Console.WriteLine("1 - Hambúrguer");
            Console.WriteLine("2 - Hot dog");

            Console.Write("> Digite o ID do item | Opções [ 1 - 2 ]: ");
            string idItem = Console.ReadLine();

            // Cadastrando um item do tipo Hamburguer
            if (idItem == "1")
            {
                Item hamburguer = new Hamburguer();
                hamburguer.setIdItem(idItem);

                Console.WriteLine("1 - Blend clássico americano");
                Console.WriteLine("2 - Blend com carne de sol");

                Console.Write("> Digite a opção de carne | Opções [ 1 - 2 ]: ");
                int carne = int.Parse(Console.ReadLine());
                string tipoCarne = "";

                if (carne == 1)
                {
                    tipoCarne = "Blend clássico americano";
                    hamburguer.setPreco(10);
                }
                else if (carne == 2)
                {
                    tipoCarne = "Blend com carne de sol";
                    hamburguer.setPreco(9);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção não encontrada! Você retornou ao menu principal!");
                    break;
                }

                hamburguer.setTipoCarne(tipoCarne);
                itens.Add(hamburguer);

                // Verificando se será adicionada bebida
                Console.Write("> Inserir bebida? | Opções [ s / n ]: ");
                char opcaoBebida = char.Parse(Console.ReadLine());

                if (opcaoBebida == 's' || opcaoBebida == 'S')
                {
                    Item bebida = new Bebida();

                    Console.WriteLine("1 - Refrigerante");
                    Console.WriteLine("2 - Suco");
                    Console.WriteLine("3 - Milk-shake");

                    Console.Write("> Escolha a bebida | Opções [ 1 - 2 - 3 ]: ");
                    int bebi = int.Parse(Console.ReadLine());
                    string tipoBebida = "";

                    if (bebi == 1)
                    {
                        tipoBebida = "Refrigerante";
                        bebida.setPreco(7);
                        bebida.setIdItem("3");
                    }
                    else if (bebi == 2)
                    {
                        tipoBebida = "Suco";
                        bebida.setPreco(6);
                        bebida.setIdItem("4");
                    }
                    else if (bebi == 3)
                    {
                        tipoBebida = "Milk-shake";
                        bebida.setPreco(8);
                        bebida.setIdItem("5");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Opção não encontrada! Você retornou ao menu principal!");
                        break;
                    }

                    bebida.setTipoBebida(tipoBebida);
                    itens.Add(bebida);

                    somaValorItens = hamburguer + bebida;
                }
                else if (opcaoBebida == 'n' || opcaoBebida == 'N')
                {
                    Item bebida = new Bebida();
                    bebida.setPreco(0);
                    somaValorItens = hamburguer + bebida;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção não encontrada! Você retornou ao menu principal!");
                    break;
                }
            }
            // Cadastrando um item do tipo Hotdog
            else if (idItem == "2")
            {
                Item hotdog = new Hotdog();
                hotdog.setIdItem(idItem);

                Console.Write("> Digite a quantidade de salsichas | Opções [ 1 - 2 ]: ");
                int salsichas = int.Parse(Console.ReadLine());
                string qtdSalsichas = "";

                if (salsichas == 1)
                {
                    qtdSalsichas = "1";
                    hotdog.setPreco(7);
                }
                else if (salsichas == 2)
                {
                    qtdSalsichas = "2";
                    hotdog.setPreco(9);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção não encontrada! Você retornou ao menu principal!");
                    break;
                }

                hotdog.setQtdSalsichas(qtdSalsichas);
                itens.Add(hotdog);

                // Verificando se será adicionada bebida
                Console.Write("> Inserir bebida? | Opções [ s / n ]: ");
                char opcaoBebida = char.Parse(Console.ReadLine());

                if (opcaoBebida == 's' || opcaoBebida == 'S')
                {
                    Item bebida = new Bebida();

                    Console.WriteLine("1 - Refrigerante");
                    Console.WriteLine("2 - Suco");
                    Console.WriteLine("3 - Milk-shake");

                    Console.Write("> Escolha a bebida | Opções [ 1 - 2 - 3 ]: ");
                    int bebi = int.Parse(Console.ReadLine());
                    string tipoBebida = "";

                    if (bebi == 1)
                    {
                        tipoBebida = "Refrigerante";
                        bebida.setPreco(7);
                        bebida.setIdItem("3");
                    }
                    else if (bebi == 2)
                    {
                        tipoBebida = "Suco";
                        bebida.setPreco(6);
                        bebida.setIdItem("4");
                    }
                    else if (bebi == 3)
                    {
                        tipoBebida = "Milk-shake";
                        bebida.setPreco(8);
                        bebida.setIdItem("5");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Opção não encontrada! Você retornou ao menu principal!");
                        break;
                    }

                    bebida.setTipoBebida(tipoBebida);
                    itens.Add(bebida);

                    somaValorItens = hotdog + bebida;
                }
                else if (opcaoBebida == 'n' || opcaoBebida == 'N')
                {
                    Item bebida = new Bebida();
                    bebida.setPreco(0);
                    somaValorItens = hotdog + bebida;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção não encontrada! Você retornou ao menu principal!");
                    break;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Opção não encontrada! Você retornou ao menu principal!");
                break;
            }

            pedido.setIdPedido(idPedido);
            pedido.setNomeCliente(nomeCliente);
            pedido.setValorTotal(somaValorItens);

            // Adicionando pedido para a lista de pedidos em preparo
            FileStream fs = new FileStream("PedidosEmPreparo.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

            // Criando um arquivo com os itens do pedido
            FileStream fs2 = new FileStream("PedidoId" + idPedido + ".txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw2 = new StreamWriter(fs2, Encoding.UTF8);

            sw.WriteLine(pedido);

            foreach (Item i in itens)
            {
                sw2.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("Pedido enviado ao preparo!");

            sw.Close();
            sw2.Close();
            fs.Close();
            fs2.Close();

            iniciarPedido = false;
        }
    }

    // Método para entregar pedidos ao cliente (remover da lista de preparo e adicionar à lista de entregues)
    public void EntregarPedido()
    {
        List<Pedido> pedidosEmPreparo = new List<Pedido>();
        List<Pedido> pedidosEntregues = new List<Pedido>();

        // Verificando a lista de preparo
        string[] listaPedidosEmPreparo = File.ReadAllLines("PedidosEmPreparo.txt");
        for (int i = 0; i < listaPedidosEmPreparo.Length; i++)
        {
            Pedido pedido = new Pedido();
            string[] aux = listaPedidosEmPreparo[i].Split('|');
            pedido.setIdPedido(aux[0]);
            pedido.setNomeCliente(aux[1]);
            pedido.setValorTotal(Convert.ToInt32(aux[2]));
            pedidosEmPreparo.Add(pedido);
        }

        string[] listaPedidosEntregues = File.ReadAllLines("PedidosEntregues.txt");
        for (int i = 0; i < listaPedidosEntregues.Length; i++)
        {
            Pedido pedido = new Pedido();
            string[] aux = listaPedidosEntregues[i].Split('|');
            pedido.setIdPedido(aux[0]);
            pedido.setNomeCliente(aux[1]);
            pedido.setValorTotal(Convert.ToInt32(aux[2]));
            pedidosEntregues.Add(pedido);
        }

        if (listaPedidosEmPreparo.Length != 0)
        {
            Console.WriteLine("PEDIDOS EM PREPARO");
            Console.WriteLine();
            foreach (var pedido in pedidosEmPreparo)
            {
                Console.WriteLine(pedido.ToString());
            }

            Console.WriteLine();
            Console.Write("> Digite o ID do pedido a ser entregue: ");
            string idPedido = Console.ReadLine();

            // Procurando o pedido que contém o ID desejado
            Pedido p;
            p = pedidosEmPreparo.Find(y => y.getIdPedido().Contains(idPedido));

            // Deletando o arquivo do pedido que foi entregue
            if (System.IO.File.Exists(@"PedidoId" + idPedido + ".txt"))
            {
                try
                {
                    System.IO.File.Delete(@"PedidoId" + idPedido + ".txt");
                    
                    // Removendo o pedido do preparo
                    pedidosEmPreparo.Remove(p);
                    AtualizarPedidosEmPreparo(pedidosEmPreparo);

                    // Adicionando o pedido para entregues
                    pedidosEntregues.Add(p);
                    AtualizarPedidosEntregues(pedidosEntregues);

                    Console.WriteLine();
                    Console.WriteLine("Pedido entregue!");
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Este pedido não está em preparo!");
            }
        }
        else if (listaPedidosEmPreparo.Length == 0)
        {
            Console.WriteLine("Ainda não há nenhum pedido a ser entregue!");
        }

    }

    // Atualizando lista de pedidos em preparo
    public void AtualizarPedidosEmPreparo(List<Pedido> pedidos)
    {
        FileStream fs = new FileStream("PedidosEmPreparo.txt", FileMode.Create, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        foreach (Pedido pedido in pedidos)
        {
            sw.WriteLine(pedido);
        }

        sw.Close();
        fs.Close();
    }

    // Atualizando lista de pedidos entregues
    public void AtualizarPedidosEntregues(List<Pedido> pedidos)
    {
        FileStream fs = new FileStream("PedidosEntregues.txt", FileMode.Create, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        foreach (Pedido pedido in pedidos)
        {
            sw.WriteLine(pedido);
        }

        sw.Close();
        fs.Close();
    }

    // Ver lista de pedidos em preparo
    public void VerPedidosEmPreparo()
    {
        List<Pedido> pedidosEmPreparo = new List<Pedido>();

        string[] listaPedidos = File.ReadAllLines("PedidosEmPreparo.txt");
        if (listaPedidos.Length != 0)
        {
            for (int i = 0; i < listaPedidos.Length; i++)
            {
                Pedido pedido = new Pedido();
                string[] aux = listaPedidos[i].Split('|');
                pedido.setIdPedido(aux[0]);
                pedido.setNomeCliente(aux[1]);
                pedido.setValorTotal(Convert.ToInt32(aux[2]));
                pedidosEmPreparo.Add(pedido);
            }

            Console.WriteLine("PEDIDOS EM PREPARO");
            Console.WriteLine();
            foreach (var pedido in pedidosEmPreparo)
            {
                Console.WriteLine(pedido.ToString());
            }
        }
        else if (listaPedidos.Length == 0)
        {
            Console.WriteLine("Ainda não há nenhum pedido em preparo!");
        }

    }

    // Ver itens dos pedidos em preparo
    public void VerItensPedidosEmPreparo()
    {
        List<Pedido> pedidosEmPreparo = new List<Pedido>();

        string[] listaPedidos = File.ReadAllLines("PedidosEmPreparo.txt");
        if (listaPedidos.Length != 0)
        {
            for (int i = 0; i < listaPedidos.Length; i++)
            {
                Pedido pedido = new Pedido();
                string[] aux = listaPedidos[i].Split('|');
                pedido.setIdPedido(aux[0]);
                pedido.setNomeCliente(aux[1]);
                pedido.setValorTotal(Convert.ToInt32(aux[2]));
                pedidosEmPreparo.Add(pedido);
            }

            Console.WriteLine("PEDIDOS EM PREPARO");
            Console.WriteLine();
            foreach (var pedido in pedidosEmPreparo)
            {
                Console.WriteLine(pedido.ToString());
            }

            Console.WriteLine();
            Console.Write("> Digite o ID do pedido para ver os itens: ");
            string idPedido = Console.ReadLine();

            if (System.IO.File.Exists(@"PedidoId" + idPedido + ".txt"))
            {
                try
                {
                    // Lendo as linhas do pedido, que possuem os itens do mesmo
                    string[] itens = System.IO.File.ReadAllLines("PedidoId" + idPedido + ".txt");

                    Console.WriteLine();
                    System.Console.WriteLine("ITENS DO PEDIDO " + idPedido);
                    Console.WriteLine();

                    foreach (var i in itens)
                    {
                        Console.WriteLine(i);
                    }
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Este pedido não está em preparo!");
            }

        }
        else if (listaPedidos.Length == 0)
        {
            Console.WriteLine("Ainda não há nenhum pedido em preparo!");
        }

    }

    // Ver lista de pedidos entregues
    public void VerPedidosEntregues()
    {
        List<Pedido> pedidosEntregues = new List<Pedido>();

        string[] listaPedidos = File.ReadAllLines("PedidosEntregues.txt");
        if (listaPedidos.Length != 0)
        {
            for (int i = 0; i < listaPedidos.Length; i++)
            {
                Pedido pedido = new Pedido();
                string[] aux = listaPedidos[i].Split('|');
                pedido.setIdPedido(aux[0]);
                pedido.setNomeCliente(aux[1]);
                pedido.setValorTotal(Convert.ToInt32(aux[2]));
                pedidosEntregues.Add(pedido);
            }
            Console.WriteLine("PEDIDOS ENTREGUES");
            Console.WriteLine();
            foreach (var pedido in pedidosEntregues)
            {
                Console.WriteLine(pedido.ToString());
            }
        }
        else if (listaPedidos.Length == 0)
        {
            Console.WriteLine("Ainda não há nenhum pedido entregue!");
        }

    }

}
