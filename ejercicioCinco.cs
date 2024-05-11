using System;

public class ejercicioCinco{
    public static void Main(string[] args){
        Console.WriteLine("\n\t**********************************************************");
        Console.WriteLine("\t* EJERCICIO 5- TABLA DE MULTIPLICAR *");            
        Console.WriteLine("\t**********************************************************");
        Console.WriteLine("\t* De un número entre 0 y 10 *\n");  
       
        Console.Write("\t* Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());
        
        if (numero >= 0){
            Console.WriteLine($"\n\t* Tabla de multiplicar del número [{numero}]  \n");

            for (int i = 1; i <= 10; i++) {
                int resultado = numero * i;
                Console.WriteLine($"\t {numero} x {i} = {resultado} \n");
            }
        } 
    }
}
