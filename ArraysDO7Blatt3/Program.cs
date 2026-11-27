namespace ArraysDO7Blatt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wieviele Teilnehmer sind in der Klasse");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] klasse = new string[n];
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Gib einen Namen für Teilnehmer {i + 1} ein");
                klasse[i] = Console.ReadLine();
            }
            foreach (string s in klasse)
                Console.Write(s);
            //Varinate 2
            //bool sollWeiter = true;
            string[] klasse2 = new string[0];
            //while(sollWeiter)
            while (SollWeiter())
            {
                //Array.Resize(ref klasse2, klasse2.Length + 1);
                string[] temp = new string[klasse2.Length + 1];
                for (int i = 0; i < klasse2.Length; i++)
                    temp[i] = klasse2[i];
                klasse2 = temp;

                Console.WriteLine("Gib einen Namen ein");
                klasse2[klasse2.Length - 1] = Console.ReadLine();

                //    Console.WriteLine("Kommt da noch was?(j/n)");
                //    string key = Console.ReadLine();
                //    if (key.ToLower() == "n")
                //    {
                //        sollWeiter = false;
                //    }//Ende if>

            }//ende While


            //Aufgabe2
            Console.WriteLine("Text hier: ");
            string text = Console.ReadLine();
            int count = 0;
            foreach (char x in text)
                if (x == 'a' || x == 'A')
                    count++;
            Console.WriteLine(count);


            //Aufgabe 3
            int[] zahlen = { 0, 9, 2, 3, 5, 7, 8, 9, 8, 7, 5, 6, 2, 4, 9, 6 };
            int doppelte = 0;

            for (int i = 0; i < zahlen.Length; i++)
            {
                int t = zahlen[i];
                for (int y = 0; y < i; y++)
                {
                    if (t == zahlen[y])
                    {
                        doppelte++;
                        break;//damit eine doppelte nicht mehrfach gezählt wird
                    }
                }
            }
            int[] tempZ = new int[zahlen.Length - doppelte];
            for (int i = 0; i < tempZ.Length; i++)
            {
                for (int y = 0; y < zahlen.Length; y++)
                {
                    bool isVorhanden = false;
                    for (int j = 0; j <= i; j++)
                    {
                        if (zahlen[y] == tempZ[j])
                        {
                            isVorhanden = true;
                        }
                    }
                    if (!isVorhanden)
                    {
                        tempZ[i] = zahlen[y];
                    }
                }

            }//ende temp belegen
            foreach (int z in tempZ)
                Console.Write(z + " ");

            //Aufgabe04
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "ä", "ö", "ü" };
            string gesucht = "Bahnhof";
            char[] gefunden = new char[gesucht.Length];
            for (int i = 0; i < gefunden.Length; i++)
            {
                gefunden[i] = '_';
            }
            bool isEnde = false;
            int versuche = 11;
            while (!isEnde)
            {
                versuche--;
                Console.Clear();
                Console.WriteLine(gefunden);
                Console.WriteLine($"Verbleibende Versuche: {versuche}");
                Console.WriteLine($"Gib einen Buchstaben ein: ");
                char buchstabe = Console.ReadLine()[0];
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (alphabet[i] == buchstabe.ToString().ToLower())
                    {
                        alphabet[i] = "";
                    }
                }
                for (int i = 0; i < gesucht.Length; i++)
                {
                    if (gesucht[i] == buchstabe)
                    {
                        gefunden[i] = gesucht[i];
                        versuche++;
                    }
                }

                if (isEqual(new string(gefunden), gesucht))
                {
                    isEnde = true;
                }
                else if (versuche < 1)
                {
                    isEnde = true;
                }
            }//Game
            Console.WriteLine("Ende: " + gesucht);


        }//ende Main
        static bool SollWeiter()
        {
            Console.WriteLine("Kommt da noch was?(j/n)");
            string key = Console.ReadLine();
            if (key.ToLower() == "n")
            {
                return false;
            }//Ende if
            return true;
        }
        static bool isEqual(string a, string b)
        {
            if (a.Length == b.Length)
                for (int i = 0; i < a.Length; i++)
                    if (a[i] != b[i])
                        return false;

            return true;
        }
    }
}
