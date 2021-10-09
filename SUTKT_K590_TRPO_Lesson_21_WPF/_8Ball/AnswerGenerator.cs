using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Ball
{
    public class AnswerGenerator
    {
        private static string[] variants = {"да", "нет", "возможно", "а если подумать?"};
        private static Random random = new Random();

        public static string GetRandomAnswer()
        {
            return variants[random.Next(0, variants.Length)];
        }
        
    }
    
}