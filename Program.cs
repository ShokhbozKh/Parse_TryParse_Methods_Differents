using System;

namespace Pares_TryParse_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Try method
            var input = "12"; //ex=>"12s" bo'lsa xatolik bo'ladi 
            var resultParse = int.Parse(input);
            // Parse qila olsa int type lik son qaytaradi
            // qila olmasa exciption bo'ladi
            Console.WriteLine(resultParse);

            // TryParse
            var inputTryParse = "123a";
            // qaysi toifaga parse qilishini va qaysi uzgaruvchiga qiymat sifatida 
            //yuklashimizni kursatamiz
            int resultTryParseInput; // default qiymati 0 ga teng

            // TryParse -> parse qilishga harakat qiladi , qila olsa resultParsega inputTryParse qiymati uzlashtiriladi
            // qila olmasa parse qilishga harakat qilgan toifani default qiymati uzlashtiriladi. int da -> 0;
            //TryParse methodi  parse qilsa true qiymat qaytaradi, qila olmasa false qaytaradi
            bool result = int.TryParse(inputTryParse, out resultTryParseInput);

            // Exciption xolatga yul qo'ymaydi.  WoW this method very well
            Console.WriteLine(resultTryParseInput); // Parse number or default number
            Console.WriteLine(result); // true or false

        }
    }
}
