using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanConverter;

namespace RomanConverterConsole
	{
	class Program
		{
		static void Main(string[] args)
            {
            String str;
            do
                {
                Console.Write("Entrer le nombre à convertir (entre 1 et 4000, Entrée pour quitter) : ");
                str = Console.ReadLine();

                // Chaine vide, on quitte
                if (String.IsNullOrEmpty(str)) break;

                // Conversion de la valeur en entier
                if (int.TryParse(str, out int val))
                    {
                    if ((val >= 1) && (val <= 4000)) Console.WriteLine($"Roman : {val.ToRoman()}");
                    else Console.WriteLine("La valeur doit être comprise entre 1 et 4000");
                    }
                else
                    {
                    // Echec de conversion
                    Console.WriteLine("Entrée incorrecte");
                    }
                }
            while(true);
			}

		}
	}
