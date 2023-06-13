using System;

public class Exercise1
{
    public static void Main()
    {
        bool continuaAdaugareArray = true;

        while (continuaAdaugareArray)
        {
            int[] arr = new int[3];
            Console.WriteLine("Citirea si afisarea elementelor unui array:");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Introduceti 3 elemente in array:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Element - {i}: ");
                if (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Intrare invalida. Va rugam introduceti un numar intreg.");
                    i--;
                }
            }

            Console.Write("Elementele din array sunt: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            int suma = 0;
            for (int i = 0; i < 3; i++)
            {
                suma += arr[i];
            }
            Console.WriteLine("Suma elementelor din array este: " + suma);

            int maxim = arr[0];
            int minim = arr[0];
            for (int i = 1; i < 3; i++)
            {
                if (arr[i] > maxim)
                    maxim = arr[i];
                if (arr[i] < minim)
                    minim = arr[i];
            }
            Console.WriteLine("Valoarea maxima din array este: " + maxim);
            Console.WriteLine("Valoarea minima din array este: " + minim);

            double medie = (double)suma / arr.Length;
            Console.WriteLine("Media elementelor din array este: " + medie);

            bool toatePare = true;
            bool toateImpare = true;
            for (int i = 0; i < 3; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    toateImpare = false;
                }
                else
                {
                    toatePare = false;
                }
            }
            if (toatePare)
            {
                Console.WriteLine("Toate elementele din array sunt pare.");
            }
            else if (toateImpare)
            {
                Console.WriteLine("Toate elementele din array sunt impare.");
            }
            else
            {
                Console.WriteLine("Elementele din array sunt o combinatie de pare si impare.");
            }

            bool areDuplicate = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        areDuplicate = true;
                        Console.WriteLine("Valoarea duplicata gasita: " + arr[i]);
                    }
                }
            }
            if (!areDuplicate)
            {
                Console.WriteLine("Nu au fost gasite valori duplicate in array.");
            }

            Console.Write("Introduceti o valoare pentru cautare: ");
            int valoareCautata = Convert.ToInt32(Console.ReadLine());
            bool gasit = false;
            int indexGasit = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valoareCautata)
                {
                    gasit = true;
                    indexGasit = i;
                    break;
                }
            }
            if (gasit)
            {
                Console.WriteLine($"Valoarea cautata a fost gasita in array la indexul {indexGasit}.");
            }
            else
            {
                Console.WriteLine("Valoarea cautata nu a fost gasita in array.");
            }

            int produs = 1;
            for (int i = 0; i < 3; i++)
            {
                produs *= arr[i];
            }
            Console.WriteLine("Produsul elementelor din array este: " + produs);

            Console.WriteLine("Doriti sa adaugati un alt array? (D/N)");
            string userInput = Console.ReadLine();
            if (userInput.ToUpper() != "D")
            {
                continuaAdaugareArray = false;
            }
        }
    }
}
