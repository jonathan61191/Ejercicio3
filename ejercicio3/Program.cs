using System;

//Un vendedor recibe un sueldo base más un 10% extra por comisión de sus ventas, el vendedor desea saber cuánto
//dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes y el total que recibirá
//en el mes tomando en cuenta su sueldo base y comisiones

namespace Ejercicio3
{
    public class Program
    {
        static void Main(string[] args)
        {
                //Declaracion de variables

                decimal sueldoBase, venta1, venta2, venta3, salarioTotal, comision;

                const decimal PORCENTAGECOMISION= 10;

                //solicitar variables por pantalla

                Console.WriteLine("Ingrese su sueldo Base: ");
                sueldoBase = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Ingrese su Venta1: ");
                venta1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Ingrese su Venta2: ");
                venta2 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Ingrese su Venta3: ");
                venta3 = Convert.ToDecimal(Console.ReadLine());

                //Procedimiento

                comision = (venta1 + venta2 + venta3) * (PORCENTAGECOMISION / 100);

                salarioTotal = comision + sueldoBase;

                //Imprimir resultado

                Console.WriteLine($"El salario total recibido es: ${salarioTotal}");
                Console.WriteLine($"La Comision total recibida es: $ {comision}");

        }
    }
}

