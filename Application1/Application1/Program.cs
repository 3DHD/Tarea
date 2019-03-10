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
                    case 21:
                        Console.WriteLine("\n Usted a elejido el ejercicio 21\n");
                        ejer21 obj21 = new ejer21();
                        obj21.numero();
                        break;
                    case 22:
                        Console.WriteLine("\n Usted aelejido el ejercicio 22\n");
                        ejer22 obj22 = new ejer22();
                        obj22.estudiante();
                        break;
                    case 23:
                        Console.WriteLine("\n Usted a elejido el ejercicio 23\n");
                        ejer23 obj23 = new ejer23();
                        obj23.almacen();
                        break;
                    case 24:
                        Console.WriteLine("\n Usted a elejido el ejercicio 24\n");
                        ejer24 obj24 = new ejer24();
                        obj24.numeros();
                        break;
                    case 25:
                        Console.WriteLine("\n Usted a elejido el ejercicio 25\n");
                        ejer25 obj25 = new ejer25();
                        obj25.notas();
                        break;
                    case 26:
                        Console.WriteLine("\n Usted a elejido el ejercicio 26\n");
                        ejer26 obj26 = new ejer26();
                        obj26.numeros();
                        break;
                    case 27:
                        Console.WriteLine("\n Usted a elejido el ejercicio 27\n");
                        ejer27 obj27 = new ejer27();
                        obj27.compras();
                        break;
                    case 28:
                        Console.WriteLine("\n Usted a elejido el ejercicio 28\n");
                        ejer28 obj28 = new ejer28();
                        obj28.numero();
                        break;
                    case 29:
                        Console.WriteLine("\n Usted a elejido el ejercicio 29\n");
                        ejer29 obj29 = new ejer29();
                        obj29.temperatura();
                        break;
                    case 30:
                        Console.WriteLine("\n Usted a elejido el ejercicio 30 \n");
                        ejer30 obj30 = new ejer30();
                        obj30.superTienda();
                        break;
                    case 31:
                        Console.WriteLine("\n Usted a elejido el ejercicio 31\n");
                        break;
                    case 32:
                        Console.WriteLine("\n Usted a elejido el ejercicio 32\n");
                        ejer32 obj32 = new ejer32();
                        obj32.vocal();
                        break;
                    case 33:
                        Console.WriteLine("\n usted a elejido el ejercicio 33\n");
                        ejer33 obj33 = new ejer33();
                        obj33.rectilineo();
                        break;
                    case 34:
                        Console.WriteLine("\n Usted a elejido el ejercicio 34\n");
                        ejer34 obj34 = new ejer34();
                        obj34.numcual();
                        break;
                    case 35:
                        Console.WriteLine("\n Usted a elejido el ejercicio 35\n");
                        ejer35 obj35 = new ejer35();
                        obj35.Menu();
                        break;
                    case 36:
                        Console.WriteLine("\n Usted a elejido el ejercicio 36\n");
                        ejer36 obj36 = new ejer36();
                        obj36.naturales();
                        break;
                    case 37:
                        Console.WriteLine("\n Usted a elejido el ejercicio 37\n");
                        ejer37 obj37 = new ejer37();
                        obj37.Pares();
                        break;
                    case 38:
                        Console.WriteLine("\n Usted a elejido el ejercicio 38\n");
                        ejer38 obj38 = new ejer38();
                        obj38.Impares();
                        break;
                    case 39:
                        Console.WriteLine("\n Usted a elejido el ejercicio 39\n");
                        ejer39 obj39 = new ejer39();
                        obj39.Estudiantes();
                        break;

                    default:
                        break;
                }

                Console.WriteLine("desea continuar? si(1)/no(2)");
                valor = Convert.ToInt32(Console.ReadLine());

            } while (valor == 1);
        }
    }

}


