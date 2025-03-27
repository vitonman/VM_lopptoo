using System.Linq.Expressions;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LopptooMaksimovTiTge24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, choose what yo want to do: ");
            Console.WriteLine("1. Count and SUM method");
            Console.WriteLine("2. writeFile, if-else");
            Console.WriteLine("3. Pyramide");
            Console.WriteLine("4. Other - Exit.");

            int case_number = Int32.Parse(Console.ReadLine());
            switch (case_number)
            {
                case 1:
                    Console.WriteLine("Sum and Count");
                    Methods.CountAdnSum();
                    break;

                case 2:
                    Console.WriteLine("FILEWRITER");
                    writeFile();
                    break;

                case 3:
                    Console.WriteLine("PYRAMIDE");
                    Console.WriteLine("Sisesta pyramid kõrgus: ");
                    int korgus = Int32.Parse(Console.ReadLine());
                    Pyramide(korgus);
                    break;

                default:  
                    Console.WriteLine("EXIT");
                    break;//
            }

        }


        public static void writeFile()
        {
            // C:\Users\opilane\Desktop\text.txt

            Console.WriteLine("Sisesta text:");
            string text = Console.ReadLine();
            Console.WriteLine("Sisesta kaust path:");
            string filePath = Console.ReadLine();

            string kaust = Path.GetDirectoryName(filePath);

            if (Directory.Exists(kaust))
            {
                try
                {
                    File.WriteAllText(filePath, text);
                    Console.WriteLine("Tekst salvestatud edukalt!");
                }catch (Exception ex)
                {
                    Console.WriteLine("Tekkis viga.");
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {

                Console.WriteLine("Viga: kaust ei ole.");
                Console.WriteLine("Ei saa salvestada.");
            }

        }

        public static void Pyramide(int korgus)
        {

            for (int i = 1; i <= korgus; i++)
            {
                for(int s = 0; s < korgus - i; s++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

    }
    

}
