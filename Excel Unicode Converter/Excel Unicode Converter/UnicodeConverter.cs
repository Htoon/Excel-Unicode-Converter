using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Excel_Unicode_Converter
{
    class UnicodeConverter
    {
        public static string ConvertFromZawGyi(string input)
        {
            //===========================================================================
            //===========================================================================
            string str = "";
            str = input.Substring(0);
            string str2 = "ါ";
            string str3 = "ိ";
            string replacement = "ု";
            string str5 = "ူ";
            string str6 = "ံ";
            string str7 = "့";
            string str8 = "္";
            string str9 = "်";
            string str10 = "ျ";
            string str11 = "ြ";
            string str12 = "ွ";
            string str13 = "ှ";
            string str14 = "၀";

            return Process(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(str, "[ာိီုဳူဴ့ံး][ၤၥၦၧၨၬၭၰၱၲၳၴၵၶၷၸၹၺၻၼႅႋႌႍႎ]", new MatchEvaluator(UnicodeConverter.PatSintSequence)), "ၪ", "ဉ"), "ၫ", "ည"), "႐", "ရ"), "၀", str14), "ႏ", "န"), "ဒ", "ဒ"), "ဓ", "ဓ"), "[ွႇ]", str13), "ြ", str12), "[ျၾၿႀႁႂႃႄ]", str11), "[်ၽ]", str10), str13 + str10, str10 + str13), "ႊ", str12 + str13), "ၚ", str2 + str9), "ႎ", str3 + str6), "ဳ", replacement), "ဴ", str5), "ႈ", str13 + replacement), "ႉ", str13 + str5), "္", "်"), "(?<E>ေ)?(?<R>ြ)?(?<con>[က-အ])ၤ", "ၤ${E}${R}${con}"), "(?<E>ေ)?(?<R>ြ)?(?<con>[က-အ])ႋ", "ၤ${E}${R}${con}ိ"), "(?<E>ေ)?(?<R>ြ)?(?<con>[က-အ])ႌ", "ၤ${E}${R}${con}ီ"), "(?<E>ေ)?(?<R>ြ)?(?<con>[က-အ])ႍ", "ၤ${E}${R}${con}ံ"), "ၤ", "င်္"), "ၠ", str8 + 'က'), "ၡ", str8 + 'ခ'), "ၢ", str8 + 'ဂ'), "ၣ", str8 + 'ဃ'), "ၥ", str8 + 'စ'), "[ၦၧ]", str8 + 'ဆ'), "ၨ", str8 + 'ဇ'), "ၩ", str8 + 'ဈ'), "ၬ", str8 + 'ဋ'), "ၰ", str8 + 'ဏ'), "[ၱၲ]", str8 + 'တ'), "[ၳၴ]", str8 + 'ထ'), "ၵ", str8 + 'ဒ'), "ၶ", str8 + 'ဓ'), "ၷ", str8 + 'န'), "ၸ", str8 + 'ပ'), "ၹ", str8 + 'ဖ'), "ၺ", str8 + 'ဗ'), "ၻ", str8 + 'ဘ'), "ၼ", str8 + 'မ'), "ႅ", str8 + 'လ'), "ၭ", str8 + 'ဌ'), "႑", 'ဏ' + str8 + 'ဍ'), "႒", 'ဋ' + str8 + 'ဌ'), "႗", 'ဋ' + str8 + 'ဋ'), "ၯ", 'ဎ' + str8 + 'ဍ'), "ၮ", 'ဍ' + str8 + 'ဍ'), "[႔႕]", str7), "၎", "၎င်း"), "ႆ", "ဿ"), "(?<R>ြ)(?<con>[က-အ])(?<scon>္[က-အ])?", "${con}${scon}${R}"), "(?<=(?<Mm>[က-လသ-ဪာီ-ဿ၌-႟ ]))(?<z>၀)|(?<z>၀)(?=(?<Mm>[က-လသ-ဪာီ-ဿ၌-႟ ]))", "ဝ"), "(?<=(?<Mm>[က-လသ-ဪာီ-ဿ၌-႟ ]))(?<z>၀)|(?<z>၇)(?=(?<Mm>[က-လသ-ဪာီ-ဿ၌-႟ ]))", "ရ"), "(?<E>ေ)?(?<con>[က-အ])(?<scon>္[က-အ])?(?<upper>[ိီဲ])?(?<DVs>[ံ့း]{0,2})(?<M>[ျ-ှ]*)(?<lower>[ုူ])?(?<upper>[ိီဲ])?", "${con}${scon}${M}${E}${upper}${lower}${DVs}")).Replace("့်", "့်");
            //===========================================================================
        }

        private static string FixError(string input)
        {
            //===========================================================================
            // Fix Aut-Myit-Athat to Athat-Aut-Myint
            //===========================================================================
            input = input.Replace("့်", "့်");
            return input;
            //===========================================================================
        }

        private static string PatSintSequence(Match m)
        {
            //===========================================================================
            //===========================================================================
            string str = "";
            if (m.Value.Length > 1)
            {
                str = m.Value.Substring(1, 1) + m.Value.Substring(0, 1);
            }
            return str;
            //===========================================================================
        }

        private static string Process(string input)
        {
            //===========================================================================
            // Convert Non-Unicode-Compatible Zawgyi Charaters to Unicode
            //===========================================================================
            string[] strArray = new string[] {
            "က", "ခ", "ဂ", "ဃ", "င", "စ", "ဆ", "ဇ", "ဈ", "ဉ", "ည", "ဋ", "ဌ", "ဍ", "ဎ", "ဏ",
            "တ", "ထ", "ဒ", "ဓ", "န", "ပ", "ဖ", "ဗ", "ဘ", "မ", "ယ", "ရ", "လ", "ဝ", "သ", "ဟ",
            "ဠ", "အ"
         };
            string[] strArray2 = new string[] { "ျ", "ြ", "ွ", "ှ" };
            string[] strArray3 = new string[] { "ါ", "ာ", "ိ", "ီ", "ု", "ူ", "ေ", "ဲ", "ံ" };
            string[] strArray4 = new string[] { "ဣ", "ဤ", "ဥ", "ဦ", "ဧ", "ဩ", "ဪ", "၎" };
            string[] strArray5 = new string[] { "့", "း", "်", "္" };
            string[] strArray6 = new string[] { "၀", "၁", "၂", "၃", "၄", "၅", "၆", "၇", "၈", "၉" };
            string str = null;
            str = input;
            string pattern = "ိ+|ီ+|ွ+|ှ+|ဲ+|့+|ံ+|်+";
            return Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(str, pattern, new MatchEvaluator(UnicodeConverter.RemoveChild)), strArray[5] + strArray2[0], strArray[8]), strArray[30] + strArray2[1], strArray4[5]), strArray[30] + strArray2[1] + strArray3[6] + strArray3[1] + strArray5[2], strArray4[6]), strArray4[5] + strArray3[6] + strArray3[1] + strArray5[2], strArray4[6]), strArray4[2] + strArray3[3], strArray4[3]), strArray4[2] + strArray5[3], strArray[9] + strArray5[3]), strArray4[2] + strArray5[2], strArray[9] + strArray5[2]), strArray4[2] + strArray3[1], strArray[9] + strArray3[1]), strArray6[4] + strArray[4] + strArray5[2] + strArray5[1], strArray4[7] + strArray[4] + strArray5[2] + strArray5[1]), strArray5[0] + strArray5[2], strArray5[2] + strArray5[0]), strArray5[1] + strArray5[2], strArray5[2] + strArray5[1]), strArray2[3] + strArray2[0], strArray2[0] + strArray2[3]), strArray2[3] + strArray2[1], strArray2[1] + strArray2[3]), strArray2[3] + strArray2[2], strArray2[2] + strArray2[3]), strArray2[2] + strArray2[0], strArray2[0] + strArray2[2]), strArray2[2] + strArray2[1], strArray2[1] + strArray2[2]), strArray2[3] + strArray2[2] + strArray2[1] + "|" + strArray2[3] + strArray2[1] + strArray2[2] + "|" + strArray2[2] + strArray2[3] + strArray2[1] + "|" + strArray2[2] + strArray2[1] + strArray2[3] + "|" + strArray2[1] + strArray2[3] + strArray2[2], strArray2[1] + strArray2[2] + strArray2[3]), strArray2[3] + strArray2[2] + strArray2[0] + "|" + strArray2[3] + strArray2[0] + strArray2[2] + "|" + strArray2[2] + strArray2[3] + strArray2[0] + "|" + strArray2[2] + strArray2[0] + strArray2[3] + "|" + strArray2[0] + strArray2[3] + strArray2[2], strArray2[0] + strArray2[2] + strArray2[3]), strArray3[8] + strArray3[4], strArray3[4] + strArray3[8]), strArray3[4] + strArray3[2], strArray3[2] + strArray3[4]), strArray3[8] + strArray3[2], strArray3[2] + strArray3[8]), strArray5[0] + strArray3[4], strArray3[4] + strArray5[0]), strArray5[0] + strArray3[7], strArray3[7] + strArray5[0]), strArray5[0] + strArray3[8], strArray3[8] + strArray5[0]), strArray[0x1a] + strArray3[6] + strArray3[1] + strArray[0] + strArray2[0] + strArray5[2] + strArray3[1], strArray[0x1a] + strArray3[6] + strArray3[1] + strArray[0] + strArray5[2] + strArray2[0] + strArray3[1]), strArray[20] + strArray3[4] + strArray5[2], strArray[20] + strArray5[2] + strArray3[4]), "််", "်"), strArray6[0] + strArray5[2], strArray[0x1d] + strArray5[2]), strArray6[7] + strArray5[2], strArray[0x1b] + strArray5[2]), strArray6[8] + strArray5[2], strArray[2] + strArray5[2]), strArray6[0] + strArray5[3], strArray[0x1d] + strArray5[3]), strArray6[7] + strArray5[3], strArray[0x1b] + strArray5[3]), strArray6[8] + strArray5[3], strArray[2] + strArray5[3]), strArray6[0] + "(?<vowel>[" + strArray3[0] + "-" + strArray3[8] + "])", strArray[0x1d] + "${vowel}"), strArray6[7] + "(?<vowel>[" + strArray3[0] + "-" + strArray3[8] + "])", strArray[0x1b] + "${vowel}"), strArray6[8] + "(?<vowel>[" + strArray3[0] + "-" + strArray3[8] + "])", strArray[2] + "${vowel}"), strArray6[0] + "(?<medial>[" + strArray2[0] + "-" + strArray2[3] + "])", strArray[0x1d] + "${medial}"), strArray6[7] + "(?<medial>[" + strArray2[0] + "-" + strArray2[3] + "])", strArray[0x1b] + "${medial}"), strArray6[8] + "(?<medial>[" + strArray2[0] + "-" + strArray2[3] + "])", strArray[2] + "${medial}"), strArray6[0] + "(?<finale>([က-ေ][္-်]))", strArray[0x1d] + "${finale}"), strArray6[7] + "(?<finale>([က-ေ][္-်]))", strArray[0x1b] + "${finale}"), strArray6[8] + "(?<finale>([က-ေ][္-်]))", strArray[2] + "${finale}"), "(?<upper>[ိီံဲ])(?<M>[ျ-ှ]+)", "${M}${upper}"), "(?<DVs>[ံ့း]+)(?<lower>[ုူ])", "${lower}${DVs}").Replace("့်", "့်");
            //===========================================================================
        }

        private static string RemoveChild(Match m)
        {
            //===========================================================================
            //===========================================================================
            string str = m.Value;
            if (str.Length > 1)
            {
                str = str.Remove(1);
            }
            return str;
            //===========================================================================
        }
    }
}
