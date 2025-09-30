/*// Declarando uma nova Matriz/Array de cadeias de caracteres que possa conter 3 elementos

string[] fraudulentOrderIDs = new string[3];

// o primeiro conjunto de [] diz: a variavel fraudulentOrderIDs é uma matriz
// o segundo [3] diz: este contera 3 elementos

//atribuindo valores de IDs

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// agora vamos reatribuir o valor do primeiro elemento da matriz 
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
*/

// Para declarar a matriz  e inicializar os valores em uma unica instrucao
// sintaxe de expressao Colletion

string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

// exemplo da mesma sintaxe porem mais antiga
// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
// ambas estao corretas

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// propriedade Length: 
// Serve para determinar o tamando de uma matriz 
// A propriedade Length de uma matriz nao comeca no zero

// Relarando um numero de pedidos fraudulentos
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process");

// aqui a gente usou o Lenght para retornar a quantidade de elementos da minha matriz criada
// entao mesmo tendo 4 elementos (3 + 1 reatribuicao), ele sabe que a retribuicao é uma substituicao, entao nao conta como um novo elemento


/*Recap:
 - Uma matriz é uma variavel especial que contem uma colecao de elementos de dados relacionados
 - Tenho que decorar o formato basico de uma declaracao de uma variavel de matriz
 - lembrar que ele comeca a partir do 0 e nao do 1
 - se eu tiver 3 elementos, eles serao 0,1,2 e se eu tentar acessar o 3, ele vai dar um erro de fora de limite da matriz


Exemplos corretos de criacao e inicializacao de uma Matriz

1) string[] myarray = new string[3]; myarray[0] = test1; myarray[1] = test2; myarray[2] = test3;.
2) int[] myarray = new int[3]; myarray[0] = 1; myarray[1] = 2; myarray[2] = 3;.
*/

