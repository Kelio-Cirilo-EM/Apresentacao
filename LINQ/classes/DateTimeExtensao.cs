using System.Globalization;

namespace LINQ.classes
{
    public static class DateTimeExtensao
    {
        public static string DataAnoMesDia(this DateTime data)
        {
            string formato = "dd/MM/yyyy";
            return data.ToString(formato);
        }
        public static string DataExtensa(this DateTime data)
        {
            string formato = "dddd, dd 'de' MMMM 'de' yyyy";
            CultureInfo culture = new("pt-br");
            return data.ToString(formato, culture);
        }
    }
}
