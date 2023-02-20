using System;
using System.Xml.Schema;

namespace Practica_Metodos
{
    class program
    {
        
        int numero1 = 5;

        int numero2 = 7;

        
        static void Main(string[] args)
        {
            int valor1 = 7;

            double valor2 = 5.2;

            double valor3 = 8.3;

            mensajeEnPantalla();

            Console.WriteLine("Mensaje desde el main"); 
        
            //Console.WriteLine(sumaNumeros(7,9));

            Console.WriteLine(divideNumeros(18, 7));

            Console.WriteLine(Suma(7,5));

            Console.WriteLine(Suma(valor1, valor2, valor3));
        }
        
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

        static int sumaNumeros(int num1, int num2, int num3)
        {
            return num1 + num2;
        }
        

        //Método para dividir
        static double divideNumeros(double num1, int num2)
        {
            return num1 / num2;
        }
        
        //forma de declarar metodos que son de una sola linea de codigo
        static double divideNumerosC(double num1, int num2) => num1 / num2;
        

        void primerMetodo()
        {

            Console.WriteLine(numero1 + numero2);

        } 

        void segundoMetodo()
        {

            Console.WriteLine(numero1+numero2);

        }
      
        
        //sobrecarga de métodos

        static int Suma(int operador1, int operador2)=>operador1 + operador2;

        static int Suma(int numero1, int numero2, int numero3) => numero1 + numero2;

        static double Suma(int numero1, double numero2) => numero1 + numero2;

        static int Suma(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2;

        //decalarar un parametro opcional, no existe limite de parametros pero debe ir despues de las obligatorias.
        static double Suma(int num1, double num2, double num3 = 0)
        {
            return num1 + num2 + num3;
        }

        static double Suma(int num1, double num2, double num3=0, double num4=0)
        {
            return num1 + num2;
        }
        

    }
}
