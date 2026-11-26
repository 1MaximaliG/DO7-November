using System.Text;

namespace ArrayDO7Blatt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Direkte Wertzuweisung
            int[] zahlen = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Bei einer einzelnen Anweisung in einer Schleife können wir den Scope weg lassen
            foreach (int z in zahlen) Console.Write(z + " "); //Wir können auch in eine Zeile schreiben

            Console.WriteLine(); //nur für den Zeilenumbruch nach der schleife

            //A
            for (int i = 0; i < 10; i++)
            {
                zahlen[i]++;
            }
            foreach (int z in zahlen) Console.Write(z + " ");
            Console.WriteLine();

            //B
            for (int i = 9; i >= 0; i--)
                Console.Write(zahlen[i] + " ");
            Console.WriteLine();

            //C
            int y = 10;
            //es ist möglich mehrere zähler in der forschleife iterieren
            for (int i = 0; i < 10; i++, y--)
            {
                zahlen[i] = y;
                //y--;
            }
            foreach (int z in zahlen) Console.Write(z + " ");
            Console.WriteLine();

            //D //Kopie von B
            for (int i = 9; i >= 0; i--)
                Console.Write(zahlen[i] + " ");
            Console.WriteLine();

            //E
            for (int i = 0; i < 10; i++)
            {
                //Statische aufrufvariante von Random
                zahlen[i] = Random.Shared.Next(1, 10);
            }
            foreach (int z in zahlen) Console.Write(z + " ");
            Console.WriteLine();

            int[] karray = new int[6];
            for (int i = 0; i < karray.Length; i++)
            {
                karray[i] = Random.Shared.Next(1, 7);
                Thread.Sleep(5);
            }
            //Aufgabe 2
            //A 
            int summe = 0;
            for (int i = 0; i < 6; i++)
            {
                summe += karray[i];
            }
            Console.WriteLine(summe);

            //B
            Console.WriteLine(summe / karray.Length);
            Console.WriteLine(karray.Average());

            //C
            Console.WriteLine(karray.Min());
            int kleinste = karray[0];
            //variante 2
            for (int i = 1; i < karray.Length; i++)
            {
                if (karray[i] < kleinste)
                {
                    kleinste = karray[i];
                }
            }
            Console.WriteLine(kleinste);

            //D
            int gross = karray[0];
            foreach (int z in karray)
                gross = z > gross ? z : gross;

            Console.WriteLine(gross);

            // Aufgabe 3
            int[] aufgabe3 = { 5, 4, 3, 2, 1, 9, 8, 7, 6, 0 };
            //A
            for (int a = 0; a < 10; a++)
            {
                for (int i = 0; i < aufgabe3.Length - 1; i++)
                {
                    if (aufgabe3[i] < aufgabe3[i + 1])
                    {
                        int temp = aufgabe3[i];
                        aufgabe3[i] = aufgabe3[i + 1];
                        aufgabe3[i + 1] = temp;
                        //(aufgabe3[i], aufgabe3[i + 1]) = (aufgabe3[i + 1], aufgabe3[i]);
                    }
                }
            }
            foreach (var z in aufgabe3) Console.Write(" " + z);
            //Was können wir optimieren

            string huhnS = "Mohrhuhn4Ever";
            char[] huhn = huhnS.ToCharArray();
            for (int i = 0; i < huhn.Length; i++)
                for (int j = 0; j < huhn.Length - 1; j++)
                    if (huhn[j] > huhn[j + 1])
                    {
                        char temp = huhn[j];
                        huhn[j] = huhn[j + 1];
                        huhn[j + 1] = temp;
                    }
            Console.WriteLine(huhn);
            
        }
    }
}
