using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menú de programas");
            Console.WriteLine("1. Programa 1: Hola Mundo");
            Console.WriteLine("2. Programa 2: Saludar");
            Console.WriteLine("3. Programa 3: Suma de dos números");
            Console.WriteLine("4. Programa 4: Área de un círculo");
            Console.WriteLine("5. Programa 5: Aumentar el salario");
            Console.WriteLine("6. Programa 6: Nùmero par o impar");
            Console.WriteLine("7. Programa 7: Mayor de tres números");
            Console.WriteLine("8. Salir");
            Console.WriteLine("Seleccione una opción: ");

            int opcion = Convert.ToInt32(Console.ReadLine());
     
            switch (opcion)
            {
                case 1:
                    Programa1();
                    break;
                case 2:
                    Programa2();
                    break;
                case 3:
                    Programa3();
                    break;
                case 4:
                    Programa4();
                    break;
                case 5:
                    Programa5();
                    break;
                case 6:
                    Programa6();
                    break;
                case 7:
                    Programa7();
                    break;
                case 8:
                    Console.WriteLine("Adiós!");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    Console.ReadKey();
                    break;


            }
        }
    }

    static void Programa1()
    {
        Console.WriteLine("Hola Mundo!");
        Console.ReadKey();
    }

    static void Programa2()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine($"Hola, {nombre}!");

        Console.ReadLine();
    }

    static void Programa3()
    {
        Console.Write("Ingrese el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int suma = num1 + num2;
        Console.WriteLine($"La suma es: {suma}");
        Console.ReadKey();
    }

    static void Programa4()
    {
        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        const double pi = 3.14159; // valor aproximado de pi

        double area = pi * Math.Pow(radio, 2);

        Console.WriteLine($"El área del círculo es: {area:F2}");

        Console.ReadLine(); // Se añadió el punto y coma
    }

    static void Programa5()
    {
        Console.Write("Ingrese el nombre del trabajador: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el cargo del trabajador: ");
        string cargo = Console.ReadLine();

        Console.Write("Ingrese el salario del trabajador: ");
        decimal salario = Convert.ToDecimal(Console.ReadLine());

        decimal aumento = salario * 0.10m;
        decimal nuevoSalario = salario + aumento;

        Console.WriteLine($"Datos del trabajador:");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"Salario actual: {salario:C2}");
        Console.WriteLine($"Aumento: {aumento:C2}");
        Console.WriteLine($"Nuevo salario: {nuevoSalario:C2}");

        Console.ReadLine();
    }

    static void Programa6()
    {
        Console.Write("Ingrese un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }

        Console.ReadKey();
    }

    static void Programa7()
    {
        Console.Write("Ingrese el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int mayor = num1;

        if (num2 > mayor)
        {
            mayor = num2;
        }

        if (num3 > mayor)
        {
            mayor = num3;
        }

        Console.WriteLine($"El número mayor es: {mayor}");

        Console.ReadKey();
    }

}




