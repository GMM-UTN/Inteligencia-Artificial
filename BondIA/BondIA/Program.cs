using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondIA
{
    public class Program
    {
        static void Main(string[] args)
        {
            Int32[] Rosario = { 2, 3, 4, 5, 6 };
            Int32[] Cordoba = { 3 };
            Int32[] Formosa = { };
            Int32[] VillaConstitucion = { 5, 6 };
            Int32[] Junin = { 6 };
            Int32[] LaPlata = { };
            Console.WriteLine("Las ciudades existentes son:");
            Console.WriteLine("1- Rosario");
            Console.WriteLine("2- Córdoba");
            Console.WriteLine("3- Formosa");
            Console.WriteLine("4- Villa Constitución");
            Console.WriteLine("5- Junín");
            Console.WriteLine("6- La Plata");
            Console.Write("Ingrese la ciudad de partida: ");
            Int32 partida = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la ciudad de destino: ");
            Int32 destino = Convert.ToInt32(Console.ReadLine());
            Int32 bandera = 0;
            if (partida == 3 || partida == 6) {
                bandera = 0;
            }
            else
            {
                switch (partida)
                {
                    case 1:
                        for (int i = 0; i < Rosario.Length; i++)
                        {
                            if (destino == Rosario[i])
                            {
                                bandera = 1;
                            }
                        }
                        break;

                    case 2:
                        for (int i = 0; i < Cordoba.Length; i++)
                        {
                            if (destino == Cordoba[i])
                            {
                                bandera = 1;
                            }
                        }
                        break;

                    case 4:
                        for (int i = 0; i < VillaConstitucion.Length; i++)
                        {
                            if (destino == VillaConstitucion[i])
                            {
                                bandera = 1;
                            }
                        }
                        break;

                    case 5:
                        for (int i = 0; i < Junin.Length; i++)
                        {
                            if (destino == Junin[i])
                            {
                                bandera = 1;
                            }
                        }
                        break;
                }
            }

            if (bandera == 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadKey();
        }
    }
}