using System;


namespace FindeMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MinMax = new int[] { 1, 2, 3, 4, 5 };

            var kleiner = MinMax[0];
            var groesser = MinMax[0];

            for (int i = 0; i < MinMax.Length; i++)
            {
                if (kleiner > MinMax[i])
                    kleiner = MinMax[i];

                if (groesser < MinMax[i])
                    groesser = MinMax[i];
                
            }
            //Console.WriteLine($" Die größte Zahl ist: {groesser} ");
            //Console.WriteLine($" Die kleinste Zahl ist: {kleiner} ");

            int[] erstesArray = new int[] { 1, 2, 3, 4, 5, 99 };
            int[] zweitesArray = new int[] { 6, 7, 8, 9, 10 };
            int[] drittesArray = new int[] { 6, 7, 8, 9, 10, 534, 554,3,45,34,53,4,53,5,345 };

            var concat = new Concatenieren();
                
            var ergebnis = concat.Concateniere(concat.Concateniere(erstesArray, zweitesArray), drittesArray);
            Console.WriteLine(ergebnis);

        }
       
    }
}
