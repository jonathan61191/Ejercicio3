using System;

//Realizar un algoritmo con C# donde me permita calcular el perímetro/circunferencia y área de las siguientes
//figuras geométricas: cuadrado, rectángulo, triángulo y círculo. Mostrar en pantalla los valores calculados
//por cada figura geométrica 

namespace Ejercicio4
{
    public class Program
    {
        static void Main(string[] args)
        {
        //declaramos variables

        double baseRec, alturaRec, radioCir, ladoCua, lado1Tri, lado2Tri, lado3Tri, sAreaTri, areaCua, perCua, 
            areaRec, perRec, areacir, perCir, areaTri, pertri;

        
        //declaracion de constantes
        const double PI = Math.PI;


        //solicitar variables

            //cuadrado
        Console.Write("ingrese informacion del Cuadrado (lado): ");
            Console.Write("\n");
            Console.Write("Lado: ");
            ladoCua = Convert.ToDouble(Console.ReadLine());
            //rectanngulo
        Console.Write("ingrese informacion del Rectangulo (base, altura): ");
            Console.Write("\n");
            Console.Write("Base: ");
            baseRec = Convert.ToDouble(Console.ReadLine());
            Console.Write("Altura: ");
            alturaRec = Convert.ToDouble(Console.ReadLine());
            //circulo
        Console.Write("ingrese informacion del Circulo (radio): ");
            Console.Write("\n");
            Console.Write("Radio: ");
            radioCir = Convert.ToDouble(Console.ReadLine());
            //triangulo
        Console.Write("ingrese informacion del Triangulo (lado1, lado2, lado3): ");
            Console.Write("\n");
            Console.Write("Lado1: ");
            lado1Tri = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lado2: ");
            lado2Tri = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lado3: ");
            lado3Tri = Convert.ToDouble(Console.ReadLine());








        }
}
}

