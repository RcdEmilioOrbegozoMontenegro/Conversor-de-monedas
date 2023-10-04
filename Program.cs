using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Bienvenido al conversor de monedas");
        Console.WriteLine("Seleccione la moneda de origen:");
        Console.WriteLine("1. Soles (PEN)");
        Console.WriteLine("2. Dólares (USD)");
        Console.WriteLine("3. Euros (EUR)");
        Console.Write("Ingrese su elección: ");

        string monedaOrigen = Console.ReadLine();

        double tasaCambioSolesUSD = 3.75; // Tasa de cambio USD a PEN
        double tasaCambioSolesEUR = 4.20; // Tasa de cambio EUR a PEN

        double tasaCambioUSDSoles = 1 / tasaCambioSolesUSD; // Tasa de cambio PEN a USD
        double tasaCambioEURSoles = 1 / tasaCambioSolesEUR; // Tasa de cambio PEN a EUR

        double tasaCambioUSDEUR = tasaCambioSolesEUR / tasaCambioSolesUSD; // Tasa de cambio USD a EUR
        double tasaCambioEURUSD = tasaCambioSolesUSD / tasaCambioSolesEUR; // Tasa de cambio EUR a USD

        if (monedaOrigen == "1")
        {
            ConvertirDesdeSoles(tasaCambioUSDSoles, tasaCambioEURSoles);
        }
        else if (monedaOrigen == "2")
        {
            ConvertirDesdeDolares(tasaCambioSolesUSD, tasaCambioEURUSD);
        }
        else if (monedaOrigen == "3")
        {
            ConvertirDesdeEuros(tasaCambioSolesEUR, tasaCambioUSDEUR);
        }
        else
        {
            Console.WriteLine("Opción no válida. Seleccione una opción válida.");
        }
    }

    static void ConvertirDesdeSoles(double tasaUSD, double tasaEUR)
    {
        Console.Write("Ingrese la cantidad en soles (PEN): ");
        double soles = Convert.ToDouble(Console.ReadLine());

        double dolares = soles * tasaUSD;
        double euros = soles * tasaEUR;

        Console.WriteLine("Cantidad en dólares (USD): " + Math.Round(dolares,2));
        Console.WriteLine("Cantidad en euros (EUR): " + Math.Round(euros,2));
    }

    static void ConvertirDesdeDolares(double tasaPEN, double tasaEUR)
    {
        Console.Write("Ingrese la cantidad en dólares (USD): ");
        double dolares = Convert.ToDouble(Console.ReadLine());

        double soles = dolares * tasaPEN;
        double euros = dolares * tasaEUR;

        Console.WriteLine("Cantidad en soles (PEN): " + Math.Round(soles, 2));
        Console.WriteLine("Cantidad en euros (EUR): " + Math.Round(euros, 2));
    }

    static void ConvertirDesdeEuros(double tasaPEN, double tasaUSD)
    {
        Console.Write("Ingrese la cantidad en euros (EUR): ");
        double euros = Convert.ToDouble(Console.ReadLine());

        double soles = euros * tasaPEN;
        double dolares = euros * tasaUSD;

        Console.WriteLine("Cantidad en soles (PEN): " + Math.Round(soles,2));
        Console.WriteLine("Cantidad en dólares (USD): " + Math.Round(dolares,2));
    }
}

