using System;

class MainClass
{
  public static void Main(string[] args)
  {
    while (true)
    {
      try
      {
        Menu();
        break;
      }
      catch
      {
        Console.WriteLine();
        Console.WriteLine("Erro inesperado! Você retornou ao menu principal!");
      }
    }
  }

  public static void Menu()
  {
    Console.WriteLine("                                      "
                      + "    ____________________________________");
    Console.WriteLine();
    Console.WriteLine("                                      "
                      + "    SpaceBurguer - Drive-thru de Lanches");
    Console.WriteLine("                                      "
                      + "    ____________________________________");
    Console.WriteLine();
    Console.WriteLine("                                      "
                      + "               MENU PRINCIPAL         ");
    Console.WriteLine();
    Console.WriteLine("                                " +
                      "           1 - Cadastrar Pedido");
    Console.WriteLine("                                " +
                      "           2 - Entregar Pedido");
    Console.WriteLine("                                " +
                      "           3 - Ver Pedidos em Preparo");
    Console.WriteLine("                                " +
                      "           4 - Ver Itens dos Pedidos em Preparo");
    Console.WriteLine("                                " +
                      "           5 - Ver Pedidos Entregues");                 
    Console.WriteLine("                                " +
                      "           6 - Sair");
    Console.WriteLine();
    Console.Write("> Digite o número da opção desejada: ");
    int opcao = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (opcao == 1)
    {
      Lanchonete lanchonete = new Lanchonete();
      lanchonete.CadastrarPedido();
      Console.WriteLine();
      Menu();
    }
    else if (opcao == 2)
    {
      Lanchonete lanchonete = new Lanchonete();
      lanchonete.EntregarPedido();
      Console.WriteLine();
      Menu();
    }
    else if (opcao == 3)
    {
      IVerPedidos lanchonete = new Lanchonete();
      lanchonete.VerPedidosEmPreparo();
      Console.WriteLine();
      Menu();
    }
    else if (opcao == 4)
    {
      IVerPedidos lanchonete = new Lanchonete();
      lanchonete.VerItensPedidosEmPreparo();
      Console.WriteLine();
      Menu();
    }
    else if (opcao == 5)
    {
      IVerPedidos lanchonete = new Lanchonete();
      lanchonete.VerPedidosEntregues();
      Console.WriteLine();
      Menu();
    }
    else
    {
      Console.WriteLine("Sistema finalizado!");
    }
  }
  
}



