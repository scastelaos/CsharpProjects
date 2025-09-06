// Combinando cadeia de caracteres com interpolação de cadeias de caracteres

//Desafio de Código
// Imprimir instrucoes para o usuario final para que ele saiba onde seu app gerara o arquivo de saida.

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

// Regras: A variavel projectName sera usada 2x na saida desejada. 
// A variavel russianMessage contem a mensagem "Exibir saida russa" em russo.
// Vc so pode usar o Console.WriteLine ou o metodo Console.Write duas vezes. 

Console.WriteLine("View English output: \n\t c:\\Exercise\\" + projectName + "\\data.txt \n");
Console.WriteLine(russianMessage + "\n\t c:\\Exercise\\" + projectName + "\\ru-RU\\data.txt");



