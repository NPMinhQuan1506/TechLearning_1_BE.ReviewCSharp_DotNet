using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice.Exercise
{
    class Exercise1 : ExerciseTemplate
    {
        public override void Run()
        {
            Console.Clear();

            Console.Write("Nhập số chiều cao (m): ");
            double height = double.Parse(Console.ReadLine());       
            Console.Write("Nhập số cân năng (kg): ");
            double weight = double.Parse(Console.ReadLine());

            double Bmi = weight / Math.Pow(height, 2);

            Console.WriteLine($"Kết quả: {Bmi}");
            Console.WriteLine("-----------------------------------");

            while (true)
            {
                Console.Write("\nNhấn 'b' hoặc 'm' để quay về menu chính. ");
                var key = Console.ReadKey(true);

                if (key.KeyChar == 'b' || key.KeyChar == 'm')
                {
                    return;
                }
            }
        }
    }
}
