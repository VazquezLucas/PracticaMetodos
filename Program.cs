using System;

namespace Practica_Metodos
{
    class program
    {
        static void Main(string[] args)
        {
            //mensajeEnPantalla();
            //Console.WriteLine("Mensaje desde el main");          
            //Console.WriteLine(sumaNumeros(7,9));

            Console.WriteLine(divideNumeros(18, 7));
        }
        /*
        //creacion de mi propio metodo

        static void mensajeEnPantalla()
        {

            Console.WriteLine("Mensaje desde el método mensajeEnPantalla");


        }
        
        //Método que suma dos numeros

        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine($"La suma de los números es: {num1+num2}");
        }
        

        //Métodos con return

        static int sumaNumeros(int num1, int num2)
        {
            return num1 + num2;
        }
        

        //Método para dividir
        static double divideNumeros(double num1, int num2)
        {
            return num1 / num2;
        }
        */
        //forma de declarar metodos que son de una sola linea de codigo
        static double divideNumerosC(double num1, int num2) => num1 / num2;
    }
}
