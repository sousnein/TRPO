using System;

namespace Variant_01
{
    public class Calc
    {
        private int[] numbers;

        public Calc()
        {
            Random random = new Random();
            int size = 3;
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next();
            }
        }
        public Calc(int[] number)
        {
            numbers = number;
        }

        public int sum()
        {
            int summ = 0;
            foreach (var number in numbers)
            {
                summ += number;
            }
            return summ;
        }

        public int multiplication()
        {
            int multi = 0;
            foreach (var number in numbers)
            {
                multi *= number;
            }
            return multi;
        }
    }
}