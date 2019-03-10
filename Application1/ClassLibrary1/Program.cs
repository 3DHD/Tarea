using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            do
            {
                Console.WriteLine("guia de ejercicios, lenguaje C# ");
                Console.WriteLine("*************************************************");
                Console.WriteLine("Del 1  al 15 (BASICOS)");
                Console.WriteLine("Del 16 al 31 (TOMA DE DECICIONES)");
                Console.WriteLine("Del 32 al 35 (SELECCION DE CASOS)");
                Console.WriteLine("Del 36 al 46 (CICLOS REPETITIVOS FOR)");
                Console.WriteLine("Del 47 al 55 (CICLOS REPETITIVOS WHILE)");
                Console.WriteLine("Del 56 al 58 (CICLOS REPETITIVOS DO-WHILE)");
                Console.WriteLine("Del 59 al 69 (VECTORES)");
                Console.WriteLine("Del 70 al 78 (MATRICES)");
                Console.WriteLine("**************************************************");
                Console.WriteLine("Ingrese un numero para ejecutar ");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("\n Usted a elejido el ejercicio 1 ( Sumar)\n ");
                        ejercicio1 obj1 = new ejercicio1();
                        obj1.Sumar();
                        break;

                    case 2:
                        Console.WriteLine("\n usted a seleccionado el ejercicio 2 (Multiplicacion)\n ");
                        ejercicio2 obj2 = new ejercicio2();
                        obj2.multi();
                        break;

                    case 3:
                        Console.WriteLine("\n Usted a elejido el ejercicio 3 (Dividir)\n");
                        Dividir obj3 = new Dividir();
                        obj3.divi();
                        break;

                    case 4:
                        Console.WriteLine("\n Usted a elejido el ejercicio 4\n ");
                        Ejercicio4 obj4 = new Ejercicio4();
                        obj4.distancia();
                        break;

                    case 5:
                        Console.WriteLine("\n Usted a elejido el ejercicio 5\n ");
                        ejercicio5 obj5 = new ejercicio5();
                        obj5.Caledad();
                        break;
                    case 6:
                        Console.WriteLine("\n Usted a elejido el ejercicio 6\n");
                        ejer6 obj6 = new ejer6();
                        obj6.calcular();
                        break;
                    case 7:
                        Console.WriteLine("\n Usted a elejido el ejercicio 7\n");
                        ejer7 obj7 = new ejer7();
                        obj7.calcu2();
                        break;
                    case 8:
                        Console.WriteLine("\nUsted a elejido el ejercicio 8\n");
                        ejer8 obj8 = new ejer8();
                        obj8.area();
                        break;
                    case 9:
                        Console.WriteLine("Usted a elejido el ejercicio 9\n");
                        ejer9 obj9 = new ejer9();
                        obj9.prome();
                        break;
                    case 10:
                        Console.WriteLine("\nUsted a elejido el ejercicio 10\n ");
                        ejer10 obj10 = new ejer10();
                        obj10.tienda();
                        break;
                    case 11:
                        Console.WriteLine("\nUsted a elejido el ejercicio 11\n");
                        ejer11 obj11 = new ejer11();
                        obj11.salario();
                        break;
                    case 12:
                        Console.WriteLine("\n Usted a elejido el ejercicio 12\n");
                        ejer12 obj12 = new ejer12();
                        obj12.cuadrado2();
                        break;
                    case 13:
                        Console.WriteLine("\nUsted a elejido el ejercicio 13\n");
                        ejer13 obj13 = new ejer13();
                        obj13.numeros();
                        break;
                    case 14:
                        Console.WriteLine("\n Usted a elejido el ejercicio 14\n ");
                        ejer14 obj14 = new ejer14();
                        obj14.cuatro();
                        break;
                    case 15:
                        Console.WriteLine("\n Usted a elejido el ejercicio 15\n ");
                        ejer15 obj15 = new ejer15();
                        obj15.compra();
                        break;
                    case 16:
                        Console.WriteLine("\n Usted a elejido el ejercicio 16\n ");
                        ejer16 obj16 = new ejer16();
                        obj16.invento();
                        break;
                    case 17:
                        Console.WriteLine("\nUsted a elejido el ejercicio 17\n ");
                        ejer17 obj17 = new ejer17();
                        obj17.lecto();
                        break;
                    case 18:
                        Console.WriteLine("\n Usted a alejido el ejercicio 18\n ");
                        ejer18 obj18 = new ejer18();
                        obj18.mayor();
                        break;
                    case 19:
                        Console.WriteLine("\n Usted a elejido el ejercicio 19\n ");
                        ejer19 obj19 = new ejer19();
                        obj19.refrigerio();
                        break;
                    case 20:
                        Console.WriteLine("\n Usted a elejido el ejercicio 20\n");
                        ejer20 obj20 = new ejer20();
                        obj20.mitad();
                        break;
                }

                Console.WriteLine("desea continuar? si(1)/no(2)");
                valor = Convert.ToInt32(Console.ReadLine());

            } while (valor == 1);
        }
    }

}


