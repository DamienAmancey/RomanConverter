using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanConverter
    {
    public static class RomanConverter
        {
        /// <summary>
        /// Convertisseur vers chiffres romains
        /// </summary>
        /// <param name="Source">Nombre à convertir (1 à 4000)</param>
        /// <returns>La valeur en nombre romaine</returns>
        /// <exception cref="ArgumentException"></exception>
        public static string ToRoman(this int Source)
            {
            // Contrôle 
            if ((Source < 1) || (Source > 4000))
                throw new ArgumentException("La valeur doit être comprise entre 1 et 4000");

            StringBuilder result = new StringBuilder();
            string[] RomanChars = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] RomanValues = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            // Balaye le tableau des valeurs du plus grand au plus petit
            // A chaque fois qu'on peut retrancher la valeur correpondante, on le fait et on ajoute la valeur correspondante au résultat
            for (var i = 0; i < RomanChars.Length; i++)
                {
                while (Source >= RomanValues[i])
                    {
                    result.Append(RomanChars[i]);
                    Source -= RomanValues[i];
                    }
                }

            return result.ToString();
            }
        }
    }
