// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Crea un bucle que vaya desde el 1 al 255

for (int i = 1; i <= 255 ; i++)
{
    Console.WriteLine(i);
}


// Crea un nuevo bucle que imprima todos los valores de 1 a 100 que sean divisibles por 3 o 5, pero no ambos

for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 ||  i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}


// Modifica el bucle anterior para imprimir "Fizz" para múltiplos de 3, "Buzz" para múltiplos de 5 y "FizzBuzz" para números que son múltiplos de 3 y 5.

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 &&  i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }

    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }

    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else 
    {
        Console.WriteLine(i);
    }
}

// (Opcional) Si usa bucles "for" para su solución, intente hacer lo mismo con los bucles "while". ¡Viceversa si usaste bucles "while"!

int rango = 1;
while (rango <= 100)
{
    if (rango % 3 == 0 &&  rango % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }

    else if (rango % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }

    else if (rango % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else 
    {
        Console.WriteLine(rango);
    }
    rango += 1;
}