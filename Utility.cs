using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Utility
    {
        private static string[] SplitNumber(string num)
        {
            List<string> numbers = new List<string>();
            int counter = 0;
            string split = "";
            for (int i = num.Length - 1; i >= 0; i--)
            {
                split = split + num.Substring(i, 1);
                counter++;
                if (counter == 3 || (counter == num.Length) || (i == 0))
                {
                    counter = 0;
                    numbers.Add(Reverse(split));
                    split = "";
                }
            }
            return numbers.ToArray();
        }

        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static int[] GetNumbersInArray(string num)
        {
            int[] result = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                result[i] = int.Parse(num.Substring(i, 1));
            }
            return result;
        }

        public static string ConvertNumberToString(string num)
        {
            string[] numbers = Utility.SplitNumber(num);
            string[] Strings = new string[numbers.Length];

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                var number = numbers[i];
                var NumbersInArray = Utility.GetNumbersInArray(number);
                Strings[i] = Utility.GetString(NumbersInArray, int.Parse(number), i);
            }
            string joingString = "";
            for (int i = Strings.Length - 1; i >= 0; i--)
            {
                string str = Strings[i];
                string strA = PersianNumberCollection.GetString("D", i - 1);

                if (joingString != "" && str != "")
                {
                    joingString = joingString + " و " + str;
                }
                else
                    joingString = joingString + str + " " + strA;
            }
            return joingString;
        }
        private static string GetString(int[] numbers, int number, int levelID)
        {
            string result = "";
            switch (numbers.Length)
            {
                case 1:
                    {
                        result = PersianNumberCollection.GetString("A", number - 1);
                        break;
                    }
                case 2:
                    {
                        if (number < 20)
                        {
                            result = PersianNumberCollection.GetString("A", number - 1);
                        }
                        else
                        {
                            int num1 = numbers[0];
                            int num2 = numbers[1];
                            string Num1String = PersianNumberCollection.GetString("B", num1 - 2);
                            string Num2String = PersianNumberCollection.GetString("A", num2 - 1);
                            result = Num1String;
                            if (!string.IsNullOrWhiteSpace(Num2String))
                                result = Num1String + " و " + Num2String;
                        }
                        break;
                    }
                case 3:
                    {
                        int num1 = numbers[0];
                        int num2 = numbers[1];
                        int num3 = numbers[2];
                        string Num1String = PersianNumberCollection.GetString("C", num1 - 1);

                        int[] num2Array = { num2, num3 };
                        string num2String = num2.ToString() + num3.ToString();
                        string Num2String = GetString(num2Array, int.Parse(num2String), -1);

                        result = Num1String;
                        if (!string.IsNullOrWhiteSpace(Num2String))
                            result = Num1String + " و " + Num2String;

                        break;
                    }
            }
            return result;
        }
    }
}
