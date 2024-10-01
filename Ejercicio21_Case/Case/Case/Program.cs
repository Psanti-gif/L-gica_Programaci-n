internal class Program
{
    private static void Main(string[] args)
    {

        double num1, num2;
        int opcion;
        double resultado = 0;
        bool continuar = true;
        string salir = null;

        do
        {
            Console.WriteLine("Ingrese la operación que desea realizar");
            Console.WriteLine("--- 1.Sumar                         ---");
            Console.WriteLine("--- 2.Restar                        ---");
            Console.WriteLine("--- 3.Multiplicar                   ---");
            Console.WriteLine("--- 4.Dividir                       ---");
            Console.WriteLine("--- 0.Salir                         ---");
            Console.WriteLine("---------------------------------------");
            opcion = int.Parse(Console.ReadLine());

            if (opcion >= 6)
            {
                Console.WriteLine("No existe esta operación");
                continuar = false;
                break;
            }
            if (opcion != 0) ;
            {
                Console.Write("Ingrese el Primer Número: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el Segundo Número: ");
                num2 = double.Parse(Console.ReadLine());

            switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Te has salido del programa! Adios");
                        continuar = false;
                        break;

                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine($"Suma: {num1} + {num2} = {resultado}");
                        break;

                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"Resta: {num1} - {num2} = {resultado}");
                        break;

                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"Multiplicación: {num1} * {num2} = {resultado}");
                        break;

                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"División: {num1} / {num2} = {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Error no se puede dividir por cero");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                
            }
            
            if (continuar)
            {
                Console.WriteLine("Desea realizar otra operación: (S/N)");
                salir = Console.ReadLine().ToUpper();

                if (salir == "N")
                {
                    Console.WriteLine("Te has salido del programa! Adios");
                    continuar=false;
                }
            }

        }

        while (continuar);
    }
}