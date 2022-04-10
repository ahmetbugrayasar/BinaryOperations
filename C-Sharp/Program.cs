using System;

namespace BinaryOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            String exampleBinary = "01101010011001";
            String exampleNegative = "01101010011001";
            String examplePositive = "11101010011001";
            String number = "2562432";

            //string number = BinarytoDecimal(exampleBinary);
            Console.WriteLine(BinarytoDecimal(exampleBinary));
            Console.WriteLine(DecimaltoBinary(number));
            Console.WriteLine(SignedBinarytoDecimal(exampleNegative));
            Console.WriteLine(SignedBinarytoDecimal(examplePositive));

        }

        //Converts >=0 base10 integers to Binary
        static string DecimaltoBinary(String number)
        {
            string binary = "";
            int number_int = Convert.ToInt32(number);
            int temp = number_int;
            while (temp > 0)
            {
                binary = binary + Convert.ToString(temp % 2);
                temp = temp / 2;
            }
            string reverse = "";
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                reverse = reverse + binary[i];
            }
            Console.Write("Decimal {0} to binary: ", number);
            return reverse;
        }

        //Converts unsigned binary numbers to Base10 integers
        static int BinarytoDecimal(string binary)
        {

            int i = binary.Length-1;
            int number = 0;
            foreach(char c in binary)
            {
                if(c == '1')
                {
                    number += (int)Math.Pow(2, i);
                }
                i--;
            }
            Console.Write("Binary {0} to Decimal: ",binary);
            return number;
        }

        
        static int SignedBinarytoDecimal(string binary)
        {
            //int i = binary.Length - 1;
            int number = 0;
            for(int i = binary.Length-1;i>0;i--)
            {
                if(binary[i] == '1')
                {
                    number += (int)Math.Pow(2, i-1);
                }
            }
            if(binary[0] == '1')
            {
                number *= -1;
            }
            Console.Write("Binary {0} to Decimal: ", binary);
            return number;
        }
        static string BinarySummary(string binary1, string binary2)
        {
            string sum = "";
            char carry = '0';
            for(int i = binary1.Length-1;i>-1;i--)
            {
                for(int j = binary2.Length-1;i>-1;i--)
                {

                }
            }
            return sum;
        }
    }
}
