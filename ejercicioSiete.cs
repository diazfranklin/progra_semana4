using System;

public class ejercicioSiete{
    public static void Main(string[] args){
        Console.WriteLine("\n\t**********************************************************");
        Console.WriteLine("\t* EJERCICIO 7- MOSTRAR EL CUADRADO DEL MISMO *");            
        Console.WriteLine("\t**********************************************************");
        Console.WriteLine("\t* El número debe ser mayor que cero, en caso contrario saldra error *\n");         
       
        double numero;
        bool valido = false;

        do{
            Console.Write("\n\t* Ingresar un número: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out numero)){
                if (numero > 0){
                    valido = true;
                } else {
                    Console.WriteLine("\n\t* ERROR. Reingresar número.");
                }
            } else {
                Console.WriteLine("\n\t* ERROR. Reingresar número.");
            }
        } while (!valido);

        double cuadrado = numero * numero;
        Console.WriteLine("\n\t* El cuadrado de " + numero + " es: " + cuadrado);
    }
}