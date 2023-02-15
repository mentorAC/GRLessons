using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace _03TelegramBot
{
    internal static class Constants
    {
        //Buttons
        public static string START_BUTTON { get; } = "/start";
        public static string BOLT_BUTTON { get; } = "Bolt😎";
        public static string ITALIC_BUTTON { get; } = "Italic🫠";
        public static string UNDERLINE_BUTTON { get; } = "Underline😑";
        public static string STRIKE_BUTTON { get; } = "Strike🤐";
        public static string SPOILER_BUTTON { get; } = "Spoiler😶‍🌫️";
        public static KeyboardButton LINK_BUTTON { get; } = "Link";
    }
}
