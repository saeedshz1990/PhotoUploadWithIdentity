namespace PhotoUploadWithIdentity.Infrastructure {
    public static class Tools {
        private static readonly string[] Pn = { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };
        private static readonly string[] En = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public static string GetTime(this DateTime date) {
            return $"_{date.Hour:00}_{date.Minute:00}_{date.Second:00}";
        }

        public static string ToEnglishNumber(this string strNum) {
            var cash = strNum;
            for (var i = 0; i < 10; i++)
                cash = cash.Replace(Pn[i], En[i]);
            return cash;
        }

        public static string ToFileName(this DateTime date) {
            return $"{date.Year:0000}-{date.Month:00}-{date.Day:00}-{date.Hour:00}-{date.Minute:00}-{date.Second:00}";
        }
    }
}