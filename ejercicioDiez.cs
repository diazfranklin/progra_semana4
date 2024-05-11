using System;

public class ejercicioDiez{
    public static void Main(string[] args){
        Console.WriteLine("\n\t**********************************************************");
        Console.WriteLine("\t* EJERCICIO 10- CALCULAR LA EDAD PROMEDIO ESTUDIANTE *");            
        Console.WriteLine("\t**********************************************************");
        Console.WriteLine("\t* Edad promedio de un grupo de 15 estudiantes *\n");         
        
        int totalEstudiantes = 15;
        int sumaEdades = 0;

        for (int i = 1; i <= totalEstudiantes; i++){
            Console.Write($"\t* Ingrese la edad del estudiante {i}: ");
            int edad = int.Parse(Console.ReadLine());

            sumaEdades += edad;
        }

        double promedioEdades = (double)sumaEdades / totalEstudiantes;

        Console.WriteLine($"\n\t* La edad promedio de los {totalEstudiantes} estudiantes es: {promedioEdades}\n");
    }
}