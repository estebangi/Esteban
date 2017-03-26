using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa de consola que permita ingresar el nombre y apellido por separado, 
             * con estos datos debe imprimir un mensaje con el nombre completo.*/
            
            Console.WriteLine("INGRESE EL NOMBRE");
            string name = Console.ReadLine();

            Console.WriteLine("INGRESE EL APELLIDO");
            string lastname = Console.ReadLine();

            Console.WriteLine("Nombre: " + name + " Apellido: " + lastname);
            Console.WriteLine();
            Console.WriteLine();
            

            /*Realizar un programa de consola que permita ingresar el nombre y la edad, 
             * con estos datos debe imprimir un mensaje diciendo si es mayor de edad o no.*/

            
            Console.WriteLine("INGRESE LA EDAD");
            int age = Convert.ToInt16(Console.ReadLine());

            if (age >= 18)
                Console.WriteLine("Es mayor de edad");
            else
                Console.WriteLine("Es menor de edad");
            

            /*Realizar un programa de consola que permita ingresar un numero y 
             * calcule la suma de todos los numeros enteros anteriores*/
            
            int number = Convert.ToInt16(Console.ReadLine());

            int sum = 0;

            for(int i = 0; i < number; i++)
            {
                sum += i;
            }

            Console.WriteLine($"La suma es: {sum}");
            

            /*Realizar un programa de consola que permita 
             * ingresar 2 valores y encuentre el maximo comun divisor*/
            
            int numberOne = Convert.ToInt16(Console.ReadLine());
            int numberTwo = Convert.ToInt16(Console.ReadLine());

            int number1 = 0;

            if (numberOne > numberTwo)
                number1 = numberTwo;
            else
                number1 = numberOne;

            
            int mcd = 0;
            for(int i = 1; i <= number; i++)
            {
                if((numberOne%i == 0) && (numberTwo%i == 0))
                    mcd = i;
            }

            Console.WriteLine($"El máximo común divisor es: {mcd}");
            


            /*Realizar un programa de consola que permita ingresar numeros y que termine de pedir
            numeros cuando se ingresa 0 y calcule el promedio de todos los ingresados*/

            int input = 0; 
            int count = 0;
            int sum1 = 0;

            input = Convert.ToInt16(Console.ReadLine());
  
            while( input != 0)
            {
                sum1 += input;
                count++;

                input = Convert.ToInt16(Console.ReadLine());
            }
            Double average = 0;

            if (count == 0)
                average = 0;
            else
                average = sum1 / count;

            Console.WriteLine($"El promedio de los numeros ingresados es: {average}");



            Console.ReadLine();
        }
    }
}
