using System;

public class ejercicioUno{
    public static void Main(string[] args){
        Console.WriteLine("\n\t**********************************************************");
        Console.WriteLine("\t* EJERCICIO 1- PEDIR AL USUARIO EL NOMBRE *");            
        Console.WriteLine("\t**********************************************************");
        Console.WriteLine("\t* Si ingresa David, le dira Hola, David, lo contrario No te conozco *\n");  
       
        Console.Write("\t* Introduce tu nombre: ");
        string nombre = Console.ReadLine();
        //Si confirma que se llama David mostrara Hola, David
        if (nombre == "David"){
            Console.WriteLine("\n\t*******************");
            Console.WriteLine("\t* ¡Hola, David!");
            Console.WriteLine("\t*******************");
        }else{
        //Si teclea un nombre opuesto a David mostrara No te conozco
            Console.WriteLine("\n\t*******************");
            Console.WriteLine("\t* No te conozco");
            Console.WriteLine("\t*******************\n");  
        }
    }
}