using System;

public class ejercicioSeis{
    public static void Main(string[] args){
        Console.WriteLine("\n\t**********************************************************");
        Console.WriteLine("\t* EJERCICIO 6- MOSTRAR PROMEDIO DE 5 NÚMEROS *");            
        Console.WriteLine("\t**********************************************************");
        Console.WriteLine("\t* Ingresa 5 números y se presentara su promedio *\n");         
       
        double[] numeros = new double[5];
        double suma = 0;
               
        for (int i = 0; i < 5; i++) {
            Console.Write("\n\t* Ingresa el número " + (i + 1) + ": ");
            numeros[i] = Convert.ToDouble(Console.ReadLine());
        }
        foreach (double num in numeros) {
            suma += num;
        }
                
        double promedio = suma / 5;
        
        Console.WriteLine("\n\t* El promedio de los 5 numeros ingresados es: " + promedio + "\n");
    }
}