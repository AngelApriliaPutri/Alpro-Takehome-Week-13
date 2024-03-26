internal class Program
{
    private static void Main(string[] args)
    {
        int a = 0;
        int input = 0;
        int upper2 = 0;
        int lower2 = 0;
        int angka2 = 0;
        int character2 = 0;
        string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lower = "abcdefghijklmnopqrstuvwxyz";
        string angka = "0123456789";
        string character = "~`!@#$%^&*()_-+={}[]|:;\"\'</>,.?";
        List<char> password = new List<char>();
        Random pass = new Random();

        while (a == 0)
        {
            Console.Write("Masukkan input : ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input < 8)
            {
                Console.WriteLine("Input Tidak Sesuai");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                a = 1;
            }
        }
        while (upper2 < 1 || lower2 < 1 || angka2 < 1 || character2 < 1)
        {
            password.Clear();
            for (int i = 0; i < input; i++)
            {
                int r = pass.Next(1, 5);
                if (r == 1)
                {
                    password.Add(upper[pass.Next(0, upper.Length)]);
                    upper2++;
                }
                if (r == 2)
                {
                    password.Add(lower[pass.Next(0, lower.Length)]);
                    lower2++;
                }
                if (r == 3)
                {
                    password.Add(angka[pass.Next(0, angka.Length)]);
                    angka2++;
                }
                if (r == 4)
                {
                    password.Add(character[pass.Next(0, character.Length)]);
                    character2++;
                }

            }
        }
        for (int i = 0; i < password.Count; i++)
        {
            Console.Write(password[i]);
        }
    }
}
