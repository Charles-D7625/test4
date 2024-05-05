namespace test4;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine()) + 1;

        string[,] table = new string[number, number];

        table[0, 0] = " ";

        for (int i = 1; i < number; i++) {
            table[i, 0] = Convert.ToString(i);
        }

        for (int j = 1; j < number; j++) {
            table[0, j] = Convert.ToString(j);
        }

        for (int i = 1; i < number; i++) {

            for(int j = 1; j < number; j++) {

                table[i, j] = Convert.ToString(i * j);

            } 

        }

        for (int i = 0; i < number; i++) {

            for(int j = 0; j < number; j++) {

                Console.Write("{0,3}", table[i, j]);
            }

            Console.WriteLine();
        }

    }
}
