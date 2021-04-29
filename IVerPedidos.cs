// Segregação de Interface : SOLID
/* O princípio da segregação de interface foi utilizado:
Utilizamos esta interface para um propósito específico que é a visualização dos pedidos.

---------
"É melhor ter muitas interfaces específicas do que uma de propósito geral."
*/
interface IVerPedidos
{
  void VerPedidosEmPreparo();
  void VerItensPedidosEmPreparo();
  void VerPedidosEntregues();
  
}