namespace ArraysDo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 1
            int[] array = new int[20];
            for(int i = 0; i< array.Length; i++)
            {
                array[i] = i;
            }
            foreach(var z in array)
            {
                Console.WriteLine(z);
            }

            //Aufgabe 2
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1 ;
            }
            foreach (var z in array)
            {
                Console.WriteLine(z);
            }

            //Aufgabe 3
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)Math.Pow(2,i);
            }
            foreach (var z in array)
            {
                Console.WriteLine(z);
            }

            //Aufgabe 4
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * i;
            }
            foreach (var z in array)
            {
                Console.WriteLine(z);
            }

            //Aufgabe 5
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1,21);
            }
            Array.Sort(array);
            foreach (var z in array)
            {
                Console.WriteLine(z);
            }
            Array.Reverse(array);
            foreach (var z in array)
            {
                Console.WriteLine(z);
            }

            //Aufgabe 6
            int sum = 0;
            foreach(int z in array)
            {
                sum += z;
            }
            Console.WriteLine(sum);
        }
    }
}
