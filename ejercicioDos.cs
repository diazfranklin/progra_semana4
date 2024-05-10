using System;

public class ejercicioDos{
    public static void Main(string[] args){
        Console.WriteLine("\n\t**********************************************************");
        Console.WriteLine("\t* EJERCICIO 2- SUMA DE NÚMEROS POSITIVOS *");            
        Console.WriteLine("\t**********************************************************");
        Console.WriteLine("\t* Al ingresar número negativo o el cero el programa se detiene *\n");

        int numero;
        int suma = 0;

        do {
            Console.Write("\nIngrese un número positivo: ");
            numero = int.Parse(Console.ReadLine());               
            if (numero > 0) {
            suma += numero; 
            Console.Write($"\nLa suma de los números ingresados es: [{suma}]\n"); 
            } else if (numero < 0) {
            Console.Write("\nHas ingresado un número negativo. Saliendo del programa.... \n");
            } else {
            Console.Write("\nHas ingresado 0. Saliendo del programa.... \n");
            }
        } while (numero > 0);
    }
}