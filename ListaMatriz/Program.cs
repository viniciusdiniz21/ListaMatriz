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




