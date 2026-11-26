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
            for(int i = 0; i<10; i++)
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
            for(int i = 0; i < 10; i++, y--)
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
        }
    }
}
