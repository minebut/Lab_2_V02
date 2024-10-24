/*1) Сформувати список із дійсних чисел. Знайти індекс першого входження від'ємного
значення у списку чисел.
2) Створіть додаток, який розділить вихідний список із цілих чисел на два списки:
список додатних чисел і список від'ємних чисел.*/

using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Butok
{
    public class Program
    {
        static Random rand = new Random();
        public static void Main(string[] args)
        {
            Console.WriteLine("enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> Intnums = new List<int>(n);

            for (int i = 0; i < n; i++)
            {
                Intnums.Add(rand.Next(-50, 50));
                Console.Write($"{Intnums[i]}, ");


            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                if (Intnums[i] < 0)
                {
                    Console.WriteLine($"First negative element: {Intnums[i]}, index {i + 1}");
                    break;
                }

                //-----------------------------------------2---------------------------------------                
            }
            List<int> NegativeIntNum = new List<int>();
            List<int> PositiveIntNum = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (Intnums[i] < 0)
                {
                    NegativeIntNum.Add(Intnums[i]);
                }
                else if (Intnums[i] >= 0)

                    PositiveIntNum.Add(Intnums[i]);
            }

            Console.WriteLine("Positive numbers:");
            for (int i = 0; i < PositiveIntNum.Count; i++)
            {
                Console.Write($"{PositiveIntNum[i]}  ");
            }

            Console.WriteLine();

            Console.WriteLine("Negative numbers:");
            for (int i = 0; i < NegativeIntNum.Count; i++)
            {
                Console.Write($"{NegativeIntNum[i]}  ");
            }
        }
    }
}