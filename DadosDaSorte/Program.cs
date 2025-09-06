// Rolando os dados e verificando o resultado para ganhar premios
// >= 16 - Carro Novo
// >= 10 - Laptop Novo
// =7 - Viagem
// Caso contrario - gatinho

Random Dice = new Random();

int roll1 = Dice.Next(1, 7);
int roll2 = Dice.Next(1, 7);
int roll3 = Dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine(" You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine(" You rolled doubles! +2 bonus to total!");
        total += 2;
    }
    Console.WriteLine($"Your total including the bonus: {total}");
}
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}
