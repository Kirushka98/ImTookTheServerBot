using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImTookTheServerBot.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; }  = "https://telegrambotapp.azurewebsites.net:443/{0}";

        public static string Name { get; set; } = "ImTookTheServerBot";

        public static string Key { get; set; }  = "1519508964:AAG8BYDI1C5sL7ftIf8kA7FNB3c_1_X9Y60";

    }
}