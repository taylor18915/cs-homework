using System;//i

namespace cs_intro1
{
    class Program
    {//this  is our main class
        // this is our main method  class
        
        static void Main(string[] args)
        {  //string variable
            string sunshine = "this is the main string";
        int num1 = 75;
        float num2 = 65f;
            float num3 = 32425f;
            double num4 = 77;

            //string variable

            // multiple two float
            float multi = num2 * num3 ;
             

            //boolean variable
            bool boolean = true;


            //concetenate


            const int num5 = 55;
            const bool tall = true; 
            string concat = "sunshine" + "  " + "boolean";

            // string interpplation

            Console.WriteLine("{0}{1}{2}", sunshine , num5 ,tall );




            Console.WriteLine(sunshine);
            Console.WriteLine(num2);
            Console.WriteLine(concat);
            Console.WriteLine(multi);
            Console.WriteLine(tall);









            ;


        }
    }
}
