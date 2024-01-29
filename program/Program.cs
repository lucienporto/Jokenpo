//string play = "";
string? readResult;
string jokenpo;
string selected = "";

Random random = new Random();
int dice = random.Next(1, 4);

if (dice == 1)
{
    jokenpo = "Pedra";
}
else if (dice == 2)
{
    jokenpo = "Papel";
}
else
{
    jokenpo = "Tesoura";
}

// Interação básica
Console.Clear();
    
Console.WriteLine("=============");
Console.WriteLine("| JO-KEN-PO |");
Console.WriteLine("=============");
Console.WriteLine("Escolha pedra, papel ou tesoura:");
Console.WriteLine("1. Pedra");
Console.WriteLine("2. Papel");
Console.WriteLine("3. Tesoura");
readResult = Console.ReadLine();
if (readResult != null)
{
    selected = readResult.ToLower();
}

switch (selected)
{
    case "1":
        Console.WriteLine("Você escolheu: Pedra");
        if (jokenpo == "Pedra")
        {
            Console.WriteLine("Empate!");
        }
        else if (jokenpo == "Tesoura")
        {
            Console.WriteLine("Você ganhou!");
        }
        else if (jokenpo == "Papel")
        {
            Console.WriteLine("Você perdeu!");
        }
        break;

    case "2":
        Console.WriteLine("Você escolheu: Papel");
        if (jokenpo == "Papel")
        {
            Console.WriteLine("Empate!");
        }
        else if (jokenpo == "Pedra")
        {
            Console.WriteLine("Você ganhou!");
        }
        else if (jokenpo == "Tesoura")
        {
            Console.WriteLine("Você perdeu!");
        }
        break;

    case "3":
        Console.WriteLine("Você escolheu: Tesoura");
        if (jokenpo == "Tesoura")
        {
            Console.WriteLine("Empate!");
        }
        else if (jokenpo == "Papel")
        {
            Console.WriteLine("Você ganhou!");
        }
        else if (jokenpo == "Pedra")
        {
            Console.WriteLine("Você perdeu!");
        }
        break;
}

Console.WriteLine("Obrigado por jogar!");