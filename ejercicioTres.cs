using System;

public class ejercicioTres{
    public static void Main(string[] args){
        Console.WriteLine("\n\t**********************************************************");
        Console.WriteLine("\t* EJERCICIO 3- OPERARIOS Y SUS SUELDOS *");            
        Console.WriteLine("\t**********************************************************");
        Console.WriteLine("\t* Cargar 5 operarios y sus respectivos sueldos. Mostrar el nombre del operario que gana mas *\n");  
       
        string[] nombre = new string[5];
        double[] sueldo = new double[5];

        for (int i = 0; i < 5; i++){
            Console.Write("\n\t* Digita el nombre del operario " + (i + 1) + ": ");
            nombre[i] = Console.ReadLine();
            Console.Write("\t* Digita el sueldo del operario " + (i + 1) + ": ");
            sueldo[i] = Convert.ToDouble(Console.ReadLine());
        }        
        double sueldoMayor = sueldo[0];
        int indiceSueldoMayor = 0;

        for (int i = 1; i < 5; i++){
            if (sueldo[i] > sueldoMayor){
                sueldoMayor = sueldo[i];
                indiceSueldoMayor = i;
            }
        }        
        Console.WriteLine("\n\t* El sueldo mayor es de " + sueldoMayor + " y le pertenece a " + nombre[indiceSueldoMayor]);
    }
}