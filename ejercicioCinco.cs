using System;

public class ejercicioCinco{
    public static void Main(string[] args){
        Console.WriteLine("\n\t**********************************************************");
        Console.WriteLine("\t* EJERCICIO 5- TABLA DE MULTIPLICAR *");            
        Console.WriteLine("\t**********************************************************");
        Console.WriteLine("\t* Entre 0 y 10 *\n");  
       
        Console.Write("\t* Ingrese un número entre 0 y 10: ");
        int numero = int.Parse(Console.ReadLine());
        
        if (numero >= 0 && numero <= 10){
            Console.WriteLine("\n\t* Tabla de multiplicar del número " + numero + ": \n");

            for (int i = 1; i <= 10; i++) {
                int resultado = numero * i;
                Console.WriteLine("\t " + numero + " x " + i + " = " + resultado);
            }
        } else {
            Console.WriteLine("El número ingresado está fuera del rango permitido.");
        }
    }
}