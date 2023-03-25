
using System;

void adivinar()  //Metodo, no esta llamando nada
{
    const int oportunidades = 4;
    int NumeroCPU, NumeroUser;
    byte Intentos, BanderaControl;
    string Linea;
    //Generar numeros de 1 al 20 unicamente.
    Random random = new Random();

    do
    {
        
        NumeroCPU = Convert.ToInt32(random.Next(100)); 
        Console.WriteLine(NumeroCPU);
    }   while (!(((NumeroCPU >= 1) & (NumeroCPU <= 20))));
        
    NumeroCPU = random.Next(1, 21);

    //Proceso
    Intentos = 1;
    BanderaControl = 0;

    do
    {
        Console.WriteLine("\nEstoy pensando en un numero cual sera?");
        Linea = Console.ReadLine();
        NumeroUser = Convert.ToInt32(Linea);
        if (NumeroCPU == NumeroUser)
        {
            Console.WriteLine("\nAdivinaste!!!");
            BanderaControl = 1;
        }
        else
        {
            if ((NumeroUser > NumeroCPU))
            {
                Console.WriteLine("\nTe excediste el numero ingresdo es mas grande que el numero a adivinar");
            }
            else
            {
                Console.WriteLine("\nIngresaste un numero mas pequenio que el numero a adivinar");
            }
            Intentos++;
        }
    } while ((Intentos <= oportunidades) & (BanderaControl == 0)); //0 = apagado, 1 = encendido si esta encendido sale del ciclo
    if (BanderaControl == 0)
    {
        Console.WriteLine($"El Numero a adivinar es: {NumeroCPU}");
    }
}



void mayor_menor()
{
    int mayor = 0;
    int numero = 0;
    int menor = 10;
    Random random = new Random();
    for (int i = 0; i < 5; i++)
    {
        numero = random.Next(10);
        Console.WriteLine(numero);
        if (numero > mayor)
        {
            mayor = numero;
        }
        if (numero < menor)
        {
            menor = numero;
        }


    }
    Console.WriteLine("El mayor es = " + mayor);
    Console.WriteLine("El menor es = " + menor);
}

void catcher()
{
    int cantidad = 0;
    Console.WriteLine("Ingrese unca cantidad");
    try
    {
        cantidad = int.Parse(Console.ReadLine());
        cantidad = cantidad / 0;

    }
    catch (FormatException fex)
    {
        Console.WriteLine("Ingreso mal el numero " + fex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Hay un error de otro tipo: " + ex.Message);
    }
    if (cantidad > 0)
    {
        Console.WriteLine("cantidad ingresada = " + cantidad);
    }
}

void arreglos ()
{
    int[] notas = new int[15]; 
    Random rnd = new Random();
    Console.WriteLine("cargando informacion");
    for (int i = 0; i < notas.Length; i++); 
}

void nombres()
{
    string[] nombres = new string[11];
    nombres[0] = "Jairo";
    nombres[1] = "Brandon";
    nombres[2] = "Hector";
    nombres[3] = "Yeimi";
    nombres[4] = "Fatima";
    nombres[5] = "Carlos";
    nombres[6] = "Eduardo";
    nombres[7] = "Jose";
    nombres[8] = "Gustavo";
    nombres[9] = "Omar";
    nombres[10] = "Antony";

    int CanGana = 2;
    List<string> ganadores = new List<string>();
    Random random = new Random();

    while (ganadores.Count < CanGana)
    {
        int indiceGana = random.Next(nombres.Length);
        string ganador = nombres[indiceGana];
        if (!ganadores.Contains(ganador))
        {
            ganadores.Add(ganador);
        }
    }

    Console.WriteLine("Los ganadores son:");
    foreach (string ganador in ganadores)
    {
        Console.WriteLine(ganador);
    }
}
nombres(); 
