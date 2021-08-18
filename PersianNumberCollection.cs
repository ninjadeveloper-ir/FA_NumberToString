using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA_NumberToString
{
    public class PersianNumberCollection
    {
        private static readonly string[] _Level_A = {
            "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه"
        };
        private static readonly string[] _Level_B = {
            "یازده", "دوازده", "سیزده", "چهارده", "پانزده", "شانزده", "هفده", "هجده", "نوزده"
        };
        private static readonly string[] _Level_C = {
            "ده", "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود"
        };
        private static readonly string[] _Level_D = {
            "یکصد", "دویست", "سیصد", "چهارصد", "پانصد", "ششصد", "هفتصد", "هشتصد", "نهصد"
        };
        private static readonly string[] _Level_E = {
            "هزار", "میلیون", "میلیارد", "بیلیون", "بیلیارد", "تریلیون", "تریلیارد"
        };
    }
}
