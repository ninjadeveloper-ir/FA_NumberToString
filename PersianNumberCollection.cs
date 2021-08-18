using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class PersianNumberCollection
    {
        private static readonly string[] _Level_A = {
            "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه",
                 "ده", "یازده", "دوازده", "سیزده", "چهارده", "پانزده", "شانزده", "هفده", "هجده", "نوزده"
        };
        private static readonly string[] _Level_B = {
             "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود"
        };
        private static readonly string[] _Level_C = {
            "یکصد", "دویست", "سیصد", "چهارصد", "پانصد", "ششصد", "هفتصد", "هشتصد", "نهصد"
        };
        private static readonly string[] _Level_D = {
            "هزار", "میلیون", "میلیارد", "بیلیون", "بیلیارد", "تریلیون", "تریلیارد"
        };

        public static string GetString(string level, int index)
        {
            string result = "";
            if (index < 0)
                return "";
            switch (level)
            {
                case "A":
                    {
                        result = _Level_A[index];
                        break;
                    }
                case "B":
                    {
                        result = _Level_B[index];
                        break;
                    }
                case "C":
                    {
                        result = _Level_C[index];
                        break;
                    }
                case "D":
                    {
                        result = _Level_D[index];
                        break;
                    }
            }
            return result;
        }
    }
}
