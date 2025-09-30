/* Imagine que você trabalha para uma empresa de manufatura. 
A empresa precisa que você faça um inventário do depósito para determinar o número de produtos que estão prontos para envio. 
Além do número total de produtos prontos, é necessário relatar o número de produtos prontos armazenados em cada compartimento individual do depósito e o total acumulado. 
Esse total acumulado será usado para criar uma trilha de auditoria a fim de verificar novamente o trabalho e identificar qualquer "redução". */

/* 
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

// O bloco de codigo foi executado para cada elemento dentro do array, entao a saida vai ser uma vey para cada um 
*/
/*
int[] inventory = { 200, 450, 700, 175, 250 };

// adicionando um foreach para fazer interacao com cada elemento do array
// declarando uma nova variavel que vai representar a soma de td
// int sum = 0;
// e para adicionar o valor atual armazenado em items na variavel sum, coloque:
// sum += items;

int sum = 0;
foreach (int items in inventory)
{
    sum += items;
}

Console.WriteLine($"We have {sum} items in inventory.");

// Crie uma variavel para manter o numero do compartimento atual

int bin = 0;

// e entao adicionamos ele no foreach para att.
// bin++; totalmente igual a bin=bin+1

*/

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

/* para relatar o numeto do compartimento, o numero de produtos prontos nele e o total acumulado de produtos prontos
Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
*/