// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Program
{
    public static void Main(string[] args)
    {

        const decimal precio_kilo = 5000;
        decimal descuento, preciobruto, preciodescuento, preciototal;

        Console.Write("Ingrese numero de Kilos de manzana comprados: ");
        decimal kilos = Convert.ToDecimal(Console.ReadLine());

        if (kilos >= 0 && kilos <= 2)
        {
            descuento = 0;
        }
        else if (kilos > 2 && kilos <= 5)
        {
            descuento = 10;
        }
        else if (kilos > 5 && kilos <= 10)
        {
            descuento = 15;
        }
        else
        {
            descuento = 20;
        }

        preciobruto = kilos * precio_kilo;
        preciodescuento = preciobruto * (descuento / 100);
        preciototal = preciobruto - preciodescuento;

        Console.WriteLine($"Tu descuento aplicado fue del {descuento}% para los kilos comprados");
        Console.WriteLine($"Por lo cual tu compra rebaja en total {preciodescuento:C0}");
        Console.WriteLine("El precio total a pagar por tu compra es de:{0}", preciototal);
       



    }
}
