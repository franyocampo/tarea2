// See https://aka.ms/new-console-template for more information

int[,] matriz1 = new int[3, 3];
int contador = 1;
int diagonal1 = 0;
int Centro = 0;
int esquinas= 0;


for (int f = 0; f < 3; f++)//filas
{
    for (int c = 0; c < 3; c++)//columnas
    {

        if (f == c)
        {
            diagonal1 = diagonal1 + contador;
        }
    
        if (c == 1)
        {
            Centro= Centro + contador;
        }
        if(f==0 && c==0)
        {
            esquinas= esquinas + contador;
        }
        if (f==2 && c==2)
        {
            esquinas = esquinas + contador;
        }
        if (f==0 && c==2) {
            esquinas = esquinas + contador;
        }
        if (f==2 && c==0)
        {
            esquinas = esquinas + contador; 
        }

        Console.Write($"   {matriz1[f, c] + contador++}");  //contador de 2 en 2 : contador+=2

       
    }

    Console.WriteLine();

}

Console.WriteLine($"la suma de las diagonal es de: {diagonal1}");
Console.WriteLine($"La suma de la columna del centro es de: {Centro}");
Console.WriteLine($"La suma de las esquinas es de: {esquinas}");


