using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateApiIonic.Helpers
{
    public class DateTimeHelper
    {
        public static DateTime GetDateTimeMexicoCity()
        {
            return GetDateTimeMexicoCity(DateTime.UtcNow);
        }

        public static DateTime GetDateTimeMexicoCity(DateTime time)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(time, TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time (Mexico)"));
        }
    }
}
