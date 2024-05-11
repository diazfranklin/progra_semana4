using System;

public class ejercicioNueve{
    public static void Main(string[] args){
        Console.WriteLine("\n\t**********************************************************");
        Console.WriteLine("\t* EJERCICIO 9- NÚMERO PAR O IMPAR *");            
        Console.WriteLine("\t**********************************************************");
        Console.WriteLine("\t* Programa de identificación de números par o impar *");         
        
        bool continuar = true;
        while (continuar) {
            Console.Write("\n\t* Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());
        
            if (numero % 2 == 0) {
                 Console.WriteLine("\n\t******* NÚMERO INGRESADO ES PAR *******\n");
            } else {
                Console.WriteLine("\n\t******* EL NÚMERO INGRESADO ES IMPAR *******\n");
            }
            Console.Write("\t* ¿Desea ingresar otro numero? (s/n) ");
            string repuesta = Console.ReadLine();

            if (repuesta.ToLower() != "s"){
                continuar = false;
            }
        }
    }
}