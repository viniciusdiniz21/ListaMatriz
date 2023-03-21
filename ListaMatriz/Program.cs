using System;

void Exercicio1()
{
    int[,] matriz = new int[3, 3];
    int maior = int.MinValue;
    int soma = 0;
    int primo = 0;

    void GerarMatriz()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Digite um valor inteiro para célula [{i},{j}]");
                matriz[i, j] = Int32.Parse(Console.ReadLine());
            };
        };
    }

    void CalculosMatriz()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                    soma += matriz[i, j];
                    if(VerificaPrimo(matriz[i, j]))
                    {
                        primo++;
                    } 
                }
            };
        };
    }

    bool VerificaPrimo(int numero)
    {
        for (int i = 2; i <= (numero / 2); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;

    }

    void ImprimirDados()
    {
        Console.WriteLine($"Maior: {maior}");
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Nmr de primos: {primo}");
    }

    GerarMatriz();
    CalculosMatriz();
    ImprimirDados();
}

void Exercicio2()
{
    int[,] matriz = new int[3, 3];
    int soma = 0;
    double media = 0;
    double[] medias = new double[3];

    void GerarMatriz()
    {
        int i;
        int j;
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
            {
                Console.WriteLine($"Digite um valor inteiro para célula [{i},{j}]");
                matriz[i, j] = Int32.Parse(Console.ReadLine());
            };
        };
    }
    void CalcularMediaMatriz()
    {
        int i;
        int j;
        for (i = 0; i < 3; i++)
        {
            soma = 0;
            for (j = 0; j < 3; j++)
            {
                soma += matriz[i, j];
            };  
            media = soma / 3;
            medias[i] = media;
        };
        Console.WriteLine(medias);
    }
    GerarMatriz();
    CalcularMediaMatriz();
}

void Exercicio3()
{
    int[,] matriz = new int[3, 3];
    int aux;
    
    void GerarMatriz()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Digite um valor inteiro para célula [{i},{j}]");
                matriz[i, j] = Int32.Parse(Console.ReadLine());
            };
        };
    }

    void TransporMatriz()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                aux = matriz[i, j];
                matriz[i, j] = matriz[j, i];
                matriz[j, i] = aux;
            }
        }
        Console.WriteLine(matriz);
    }

    GerarMatriz();
    TransporMatriz();
}

void Exercicio4()
{
    int[,] matriz1 = new int[3, 3];
    int[,] matriz2 = new int[3, 3];
    int[,] matrizSoma = new int[3, 3];

    void GerarMatriz()
    {
        int i;
        int j;
        for ( i = 0; i < 3; i++)
        {
            for ( j = 0; j < 3; j++)
            {
                Console.WriteLine($"Digite um valor inteiro para célula da primeira matriz [{i},{j}]");
                matriz1[i, j] = Int32.Parse(Console.ReadLine());
            };
        };
        for ( i = 0; i < 3; i++)
        {
            for ( j = 0; j < 3; j++)
            {
                Console.WriteLine($"Digite um valor inteiro para célula da segunda matriz [{i},{j}]");
                matriz2[i, j] = Int32.Parse(Console.ReadLine());
            };
        };
    }

    void CalcularSomaMatriz()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrizSoma[i, j] = matriz1[i, j] + matriz2[i, j];
            };
        };
        Console.WriteLine(matrizSoma);
    }

    GerarMatriz();
    CalcularSomaMatriz();
}

void Exercicio5()
{
    char[,] tabuleiro = new char[3, 3]
    {
        { ' ', ' ', ' ' },
        { ' ', ' ', ' ' },
        { ' ', ' ', ' ' }
    };
    int option = 0;
    int rodada = 1;
    bool vezDoX = true;

    void Menu()
    {
        Console.WriteLine("1 - Iniciar novo jogo Humano vs Humano");
        Console.WriteLine("1 - Iniciar novo jogo Humano vs Máquina");
        Console.WriteLine("3 - Sair");
        option = int.Parse(Console.ReadLine());
    }

    while(option != 3)
    {
        Menu();
        Console.Clear();
        switch (option)
        {
            case 1:
                JogarContraHumano();
                break;
            case 2:
                break;
            default: 
                Console.WriteLine("Valor Inválido!");
                break;
        }
    }

    void ImprimirTabuleiro(char[,] tabuleiro)
    {
        Console.WriteLine("   1  2  3");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"{i + 1} ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($" {tabuleiro[i, j]} ");
                if (j != 2)
                {
                    Console.Write("|");
                }
            }
            Console.WriteLine();
            if (i != 2)
            {
                Console.WriteLine("  -----------");
            }
        }
    }

    void JogarContraHumano()
    {
        char vencedor = ' ';
        
        while (rodada <= 9)
        {           
            if (rodada > 4)
            {
                vencedor = VerificarVencedor(tabuleiro);
                if(vencedor != ' ')
                {
                    Console.Clear();
                    Console.WriteLine($"O Vencedor foi o jogador {vencedor}");
                    break;
                }
            }
            JogarRodada();
        }
        if(vencedor == ' ')
        {
            Console.Clear();
            Console.WriteLine("Deu velha!");
        } else
        {
            Console.Clear();
            Console.WriteLine($"O Vencedor foi o jogador {vencedor}");
        }
        
    }

    void JogarRodada()
    {
        ImprimirTabuleiro(tabuleiro);
        var jogador = vezDoX ? 'X' : 'O';
        Console.WriteLine($"Vez do jogador {jogador}");
        Console.WriteLine("Digite qual a linha que deseja marcar");
        int linha = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("Digite qual a coluna que deseja marcar");
        int coluna = int.Parse(Console.ReadLine()) - 1;
        Console.Clear();
        VerificarSquare(linha, coluna);
    }

    void VerificarSquare(int x, int y)
    {
        if(x > 3 || y > 3)
        {
            Console.WriteLine("Não existe essa célula!");
            JogarRodada();
        }
        if(tabuleiro[x, y] == ' ')
        {
            MarcarSquare(x, y);
        } else
        {
            Console.WriteLine("Esta célula já está marcada!");
            JogarRodada();
        }
    }

    void MarcarSquare(int x, int y)
    {
        char marcacao =  vezDoX ? marcacao = 'X' : marcacao = 'O';
        tabuleiro[x, y] = marcacao;
        vezDoX = !vezDoX;
        rodada++;
    }

    char VerificarVencedor(char[,] tabuleiro)
    {
        // linhas
        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[i, 0] != ' ' && tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2])
            {
                return tabuleiro[i, 0];
            }
        }

        // colunas
        for (int j = 0; j < 3; j++)
        {
            if (tabuleiro[0, j] != ' ' && tabuleiro[0, j] == tabuleiro[1, j] && tabuleiro[1, j] == tabuleiro[2, j])
            {
                return tabuleiro[0, j];
            }
        }

        // diagonais
        if (tabuleiro[0, 0] != ' ' && tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2])
        {
            return tabuleiro[0, 0];
        }
        if (tabuleiro[0, 2] != ' ' && tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
        {
            return tabuleiro[0, 2];
        }

        return ' ';
    }
}

void Exercicio6()
{
    string[,] tabuleiro = new string[6,6];
    List<string> palavras = new List<string>{
        "Carro",
        "Moto",
        "Arvore",
        "Triceratops",
        "Bicho-preguiça",
        "Fusível",
        "Radiação",
        "Fogo",
        "Fruta",
        "T-rex",
        "Boing 747",
        "Neymar",
        "Cadeia",
        "Formula1",
        "Palavra",
        "Acabou",
        "Criatividade",
        "Ultima"
    };

    Random rand = new Random();

    int paresRestantes = (6 * 6)/2;

    while (paresRestantes > 0)
    {
        string palavra = palavras[paresRestantes - 1];
        int linha1 = rand.Next(6);
        int coluna1 = rand.Next(6);
        int linha2 = rand.Next(6);
        int coluna2 = rand.Next(6);

        if (tabuleiro[linha1, coluna1] == null && tabuleiro[linha2, coluna2] == null && (linha1 != linha2 || coluna1 != coluna2))
        {
            tabuleiro[linha1, coluna1] = palavra;
            tabuleiro[linha2, coluna2] = palavra;
            paresRestantes--;
        }
    }


    void ImprimirTabuleiro()
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write($"| {tabuleiro[i, j]} |");
            }
            Console.WriteLine();
        }
    }

    void Jogar()
    {
        Console.WriteLine("Digite a linha e coluna");
        Console.WriteLine("Linha palavra 1: ");
        int linha1 = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("Coluna palavra 1: ");
        int coluna1 = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine(tabuleiro[linha1, coluna1]);
        Console.WriteLine("Linha palavra 2: ");
        int linha2 = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("Coluna palavra 2: ");
        int coluna2 = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine(tabuleiro[linha2, coluna2]);
        verificarAcerto(linha1, coluna1, linha2, coluna2);
    }

    void verificarAcerto(int lin1, int col1, int lin2, int col2)
    {
        if (lin1 > 6 || col1 > 6 || lin2 > 6 || col2 > 6)
        {
            Console.WriteLine("Não existe essa célula!");
            Jogar();
        }
        if (tabuleiro[lin1, col1] == tabuleiro[lin2, col2])
        {
            Console.WriteLine($"Parabéns, encontrou a palavra {tabuleiro[lin1, col1]}");
            Console.ReadKey();
            ImprimirTabuleiro();
        } else
        {
            Console.WriteLine($"Primeira Palavra {tabuleiro[lin1, col1]}");
            Console.WriteLine($"Segunda Palavra {tabuleiro[lin2, col2]}");
            Console.ReadKey();
            Jogar();
        }
    }

    Jogar();
}




