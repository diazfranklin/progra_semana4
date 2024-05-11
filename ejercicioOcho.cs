using System;

public class ejercicioOcho{
    public static void Main(string[] args){
        Console.WriteLine("\n\t**********************************************************");
        Console.WriteLine("\t* EJERCICIO 8- NÚMERO POSITIVO O NEGATIVO *");            
        Console.WriteLine("\t**********************************************************");
        Console.WriteLine("\t* Programa de identificación de números positivos y negativos *\n");         
        
        bool continuar = true;
        while (continuar) {
            Console.Write("\n\t* Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());
        
            if (numero > 0) {
                 Console.WriteLine("\n\t******* NÚMERO INGRESADO ES POSITIVO *******\n");
            } else if (numero < 0) {
                Console.WriteLine("\n\t******* NÚMERO INGRESADO ES NEGATIVO *******\n");
            } else{
                Console.WriteLine("\n\t******* EL NÚMERO INGRESADO ES CERO *******\n");
            }
            Console.Write("\t* ¿Desea ingresar otro numero? (s/n) ");
            string repuesta = Console.ReadLine();

            if (repuesta.ToLower() != "s"){
                continuar = false;
            }
        }
    }
}