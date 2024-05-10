using System;

public class ejercicioCuatro{
    public static void Main(string[] args){
        Console.WriteLine("\n\t**********************************************************");
        Console.WriteLine("\t* EJERCICIO 4- NÚMEROS IMPARES ENTRE EL 0 Y EL 100 *");            
        Console.WriteLine("\t**********************************************************");
        Console.WriteLine("\t* Mostrar los números impares entre el 0 y el 100 *\n");  
       
        for (int i = 0; i <= 100; i++) {
            if (i % 2 != 0) {
                Console.WriteLine("\t " + i);
            }
        }
    }
}