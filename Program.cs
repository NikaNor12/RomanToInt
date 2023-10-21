namespace RomanToInt
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> convert = new();

            convert.Add("I", 1);
            convert.Add("V", 5);
            convert.Add("X", 10);
            convert.Add("L", 50);
            convert.Add("C", 100);
            convert.Add("D", 500);
            convert.Add("M", 1000);

            Console.WriteLine("Write your Roman numeral");
            string input = Console.ReadLine().ToUpper();

            Roman roman = new Roman(input, convert);
            int result = roman.romanToInt();

            Console.WriteLine($"The integer value of {input} is {result}");
        }
    }

    public class Roman
    {
        public string RomanName { get; set; }
        //public int RomanID { get; set; }

        private Dictionary<string, int> RomanDictionary { get; }

        public Roman(string x, Dictionary<string, int> romanDictionary)
        {
            RomanName = x;         
            RomanDictionary = romanDictionary;
        }

        public int romanToInt()
        {
            int result = 0;

            for (int i = 0; i < RomanName.Length; i++)
            {
                if (i < RomanName.Length - 1 && RomanDictionary[RomanName[i].ToString()] < RomanDictionary[RomanName[i + 1].ToString()])
                {
                    result -= RomanDictionary[RomanName[i].ToString()];
                }
                else
                {
                    result += RomanDictionary[RomanName[i].ToString()];
                }
            }
            return result;
        }
    }
}

