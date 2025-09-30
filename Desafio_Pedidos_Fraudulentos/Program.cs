/* Desafio dos pedidos fraudulentos
Anteriormente neste módulo, você escreveu um código para armazenar IDs de pedidos possivelmente fraudulentos. 
Sua meta era encontrar pedidos fraudulentos o quanto antes e sinalizá-los para uma análise mais profunda.

Desafio de codificacao - Reportar as IDs de pedido que precisam de uma investigacao mais aprofundada
Sua equipe encontrou um padrão. 
Pedidos que começam com a letra "B" têm uma taxa de incidência de fraude 25 vezes maior que o normal. 
Você escreverá um novo código para imprimir na saída a ID de novos pedidos que comecem com a letra "B". 
Isso será usado pela nossa equipe anti-fraude para investigar mais a fundo.*/

string[] OrdersIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string order in OrdersIDs)
{
    if (order.StartsWith("B"))
    { Console.WriteLine($"ATENCAO, RISCO DE FRAUDE: {order}"); }
}


/* Solucao possivel:

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}

*/