using System;
using System.Collections.Generic;

namespace IsraeliHebrewNames
{
    public static class IsraeliDataGenerator
    {
        private static List<string> firstNames = new List<string>
            {
                "יעקב", "משה", "דוד", "אברהם", "אהרון", "נחמן", "צבי", "יונתן", "שלמה", "בנימין",
                "יצחק", "רחל", "שרה", "רבקה", "לאה", "חנה", "מרים", "אלישבע", "טובה", "מרדכי",
                "דורית", "איתי", "נעמה", "כרמל", "יוסי", "גדעון", "מרטין", "קרן", "נתן", "רינת",
                "שירלי", "דניאלה", "רוי", "יובל", "דורון", "אור", "מיכאל", "נטע", "רוני", "אלעד",
                "אביב", "ליאם", "נטלי", "שחר", "אלון", "נועה", "שיר", "נעם", "אור", "טלי",
                "עומר", "שירן", "דני", "טום", "אורי", "טל", "עמית", "רותם", "נועם", "אילן",
                "גל", "שאול", "טליה", "יעל", "לירן", "גיל", "אורית", "אורן", "רונה", "יואב",
                "טובי", "יוסף", "מאיה", "מוריה", "רומן", "קלודי", "אורלי", "קרמלה", "נעה", "עדן",
                "עדי", "יונה", "גיתה", "דנה", "סמדר", "ליאור", "עמרי", "סהר", "אביבה", "מתן",
                "אוריה", "גלעד", "מיכל", "מילכה", "רחלי", "ירדן", "רז", "אביתר", "אביגיל", "טובה"
            };

        private static List<string> lastNames = new List<string>
            {
                "כהן", "לוי", "מזרחי", "פרץ", "ביטון", "אברהם", "ששון", "כץ", "גולן", "גרוס",
                "ברק", "כספי", "דורון", "פלג", "אלקבץ", "זמיר", "ברנשטיין", "לב", "שלמה", "גבאי",
                "אלבז", "גלבוע", "קורן", "מור", "זיו", "מלכה", "גורן", "ברנד", "זקן", "פריד",
                "קציר", "כהנא", "רוזנטל", "כרמי", "פלד", "רוזנבלום", "כהן-קדוש", "משה", "דויטש",
                "חורב", "דנינו", "פייבלמן", "מולכו", "נחמיאס", "סטיינברג", "מרגלית", "פרח", "ביטולסקי",
                "זרעי", "נגרי", "חזותאלי", "גרין", "שניידר", "קורנפלד", "שוסטר", "קאופמן", "מזריטסקי",
                "פרס", "זוהר", "פרדס", "חן", "צור", "טוביה", "אזולאי", "כהן-וינרברג", "שמיר", "שטרן",
                "צימרמן", "טויטו", "אינברום", "נחום", "ברוך", "דניאל", "פרנק", "אשכנזי", "סנדלר", "סומך",
                "אביטן", "בוחבוט", "רוזמן", "שטיימן", "ברזילי", "גוטליב", "אוחיון", "גורדון", "שורץ", "צדוק",
            };

        private static List<string> cities = new List<string>
            {
                "תל אביב", "ירושלים", "חיפה", "באר שבע", "ראשון לציון", "נתניה", "הרצליה", "רעננה", "אשדוד", "אשקלון",
                "חדרה", "חולון", "קריית אונו", "הוד השרון", "כפר סבא", "נצרת", "רחובות", "גבעתיים", "ביתר עילית", "קריית מוצקין",
                "פתח תקווה", "כפר יונה", "עכו", "כפר ורדים", "טבריה", "אור יהודה", "רמת השרון", "נשר", "טייבה", "קריית ביאליק",
                "קריית גת", "נוף הגליל", "דימונה", "גבעת שמואל", "קריית שמונה", "אריאל", "מעלה אדומים", "בני ברק", "אופקים", "סכנין",
                "מגדל העמק", "מעיליא", "גדרה", "יבנה", "צפת", "כפר יעבץ", "בית שאן", "רמת גן", "זכרון יעקב", "גן יבנה",
                "כפר קאסם", "כפר תבור", "כרמיאל", "מודיעין-מכבים-רעות", "ספטה", "סתריה", "קדומים", "ראמה", "רמלה", "רעות",
                "שפרעם", "תמרת", "נהריה", "גבעת זאב", "נס ציונה", "נווה שאנן", "אילת", "בת ים", "גבעולים", "אור עקיבא"
            };

        private static List<string> streets = new List<string>
            {
                "הרצל", "יגאל אלון", "דרך חיפה", "שדרות רוטשילד", "דרך בן גוריון", "רחוב המלך דוד", "שדרות ויצמן", "רחוב רמב'ם", "רחוב שאול המלך", "שדרות גולדה מאיר",
                "גבעתיים", "דיזנגוף", "ביאליק", "פרישמן", "מלכי ישראל", "אלנבי", "הנשיא", "החשמונאים", "ככר המדינה", "שדרות הרצל",
                "אלוף קלמן מגן", "מנחם בגין", "ברזילי", "גורדון", "טרומפלדור", "הרברט סמואל", "נחלת בנימין", "ז'בוטינסקי", "קרן היסוד", "שמגר",
                "אחד העם", "הגליל", "שאול המלך", "בן יהודה", "גושן", "דרך מנחם בגין", "שדרות יצחק רבין", "יהודה המכבי", "מרכז העיר", "סוקולוב",
                "קיבוץ גלויות", "שדרות יגאל אלון", "שדרות הגליל", "הירקון", "טשרניחובסקי", "כיכר המדע", "שדרות עזרא", "מרכז אורט", "שדרות מנחם בגין", "דרך רוקח"
            };

        private static List<string> packageNames = new List<string>
            {
                "חבילת זהב", "חבילת כסף", "חבילת ברונזה", "חבילת פלטינה", "חבילת יהלום", "חבילת פרימיום", "חבילת יסוד", "חבילת עילית", "חבילת אינטרנט", "חבילת טלוויזיה"
            };


        public static string GenerateIsraeliIDNumber()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 100000000); // generate a random number between 1 and 99,999,999
            string idNumber = randomNumber.ToString("D8"); // convert to string and pad with zeros to 8 digits
            int[] factors = { 1, 2, 1, 2, 1, 2, 1, 2, 1 }; // the factors used to calculate the check digit
            int sum = 0;
            for (int i = 0; i < idNumber.Length; i++)
            {
                int digit = int.Parse(idNumber[i].ToString());
                int factor = factors[i];
                int product = digit * factor;
                if (product > 9)
                {
                    product -= 9;
                }
                sum += product;
            }
            int checkDigit = (10 - (sum % 10)) % 10;
            return idNumber + checkDigit.ToString();
        }

        public static bool IsValidIsraeliID(string id)
        {
            id = id.Trim();
            if (id.Length > 9 || id.Length < 5 || !int.TryParse(id, out int result))
            {
                return false;
            }

            // Pad string with zeros up to 9 digits
            id = id.PadLeft(9, '0');

            int sum = 0;
            for (int i = 0; i < id.Length; i++)
            {
                int digit = int.Parse(id[i].ToString());
                int factor = (i % 2) + 1;
                int product = digit * factor;
                if (product > 9)
                {
                    product -= 9;
                }
                sum += product;
            }

            return (sum % 10) == 0;
        }

        public static string GetRandomFirstName()
        {
            return firstNames[new Random().Next(firstNames.Count)];
        }

        public static string GetRandomLastName()
        {
            return lastNames[new Random().Next(lastNames.Count)];
        }

        public static string GetRandomCity()
        {
            return cities[new Random().Next(cities.Count)];
        }

        public static string GetRandomStreet()
        {
            return streets[new Random().Next(streets.Count)];
        }
        public static string GetRandomPackageName()
        {
            return packageNames[new Random().Next(packageNames.Count)];
        }
        public static string GenerateIsraeliZipCode()
        {
            Random rnd = new Random();
            int zipCode = rnd.Next(1000000, 9999999);
            return zipCode.ToString().Substring(0, 7);
        }
        public static string GenerateHouseNumber()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 150);

            // 10% chance of adding a Hebrew letter to the house number
            if (rnd.Next(1, 11) <= 1)
            {
                char letter = (char)rnd.Next('א', 'ב' + 1);
                return num.ToString() + letter;
            }
            else
            {
                return num.ToString();
            }
        }
    }
}

