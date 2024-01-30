bool playAgain = true;
string jogador;
string jokenpo;
string novoJogo;

Random random = new Random();

while (playAgain)
{
    jogador = "";
    jokenpo = "";

    while (jogador != "pedra" && jogador != "papel" && jogador != "tesoura")
    {
        Console.Write ("Escolha pedra, papel ou tesoura: ");
        jogador = Console.ReadLine().ToLower();
    }    
    
    switch (random.Next(1,4))
    {
        case 1:
            jokenpo = "pedra";
            break;

        case 2:
            jokenpo = "papel";
            break;

        case 3:
            jokenpo = "tesoura";
            break;
    }

    Console.WriteLine();
    Console.WriteLine($"Você escolheu: {jogador}");
    Console.WriteLine($"A máquina escolheu {jokenpo}");

    switch (jogador)
    {
        case "pedra":
            if (jokenpo == "pedra")
            {
                Console.WriteLine("\nÉ um empate!");
            }
            else if (jokenpo == "papel")
            {
                Console.WriteLine("\nVocê perdeu!");
            }
            else
            {
                Console.WriteLine("\nVocê ganhou!");
            }
            break;

        case "papel":
            if (jokenpo == "papel")
            {
                Console.WriteLine("\nÉ um empate!");
            }
            else if (jokenpo == "tesoura")
            {
                Console.WriteLine("\nVocê perdeu!");
            }
            else
            {
                Console.WriteLine("\nVocê ganhou!");
            }
            break;

        case "tesoura":
            if (jokenpo == "tesoura")
            {
                Console.WriteLine("\nÉ um empate!");
            }
            else if (jokenpo == "pedra")
            {
                Console.WriteLine("\nVocê perdeu!");
            }
            else
            {
                Console.WriteLine("\nVocê ganhou!");
            }
            break; 
    }

    Console.WriteLine("\nDeseja jogar novamente? S/N");
    novoJogo = Console.ReadLine().ToUpper();

    if (novoJogo == "N")
    {
        playAgain = false;
    }
}

Console.WriteLine("Obrigado por jogar!");