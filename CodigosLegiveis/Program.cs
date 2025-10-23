/*string firstName = "Bob";
int widgetsPurchased = 7;
// Testing a change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");


//Para aplicar um comentário em bloco que comente várias linhas, atualize seu código da seguinte maneira:
/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

/*
Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

*/

string str = "The quick brown fox jumps over the lazy dog.";

// convert the message into a char array
    char[] charMessage = str.ToCharArray();
    
// Reverse the chars
    Array.Reverse(charMessage);
    int x = 0;
    
// count the o's
    foreach (char i in charMessage) { if (i == 'o') { x++; } }

// convert it back to a string
    string new_message = new String(charMessage);

// print it out
    Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
    

// possivel solucao para organizacao do codigo com espacamentos e reestruturacao adequados

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");

/* alteracoes feitas: 

O código inclui uma descrição de nível superior do que a listagem de código inteira está tentando realizar em um comentário de várias linhas na parte superior. Você poderia argumentar que esse é um pequeno aprimoramento nos comentários do código original, no entanto, dada a descrição do desafio do código, não havia muito mais contexto disponível.
Os comentários individuais foram removidos porque eles não estavam fornecendo nenhuma informação real sobre a finalidade ou a função do código.
Várias linhas em branco foram adicionadas para aprimorar a fluência da listagem de código. Mantenha as linhas de código juntas quando parecerem semelhantes ou quando trabalharem entre si para realizar uma tarefa pequena.
Feeds de linha e guias foram adicionados para aprimorar a aparência da instrução foreach e da instrução if.
Convenções de nomenclatura de variáveis locais foram aplicadas para transmitir melhor a finalidade de cada valor.

*/