using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace _03TelegramBot
{
    internal class FormatedBot
    {
        private TelegramBotClient client;

        public FormatedBot(string token)
        {
            client = new TelegramBotClient(token);
        }

        #region -- Public Methods --
        public async void GetStatus()
        {
            var userInfo = await client.GetMeAsync();
            Console.WriteLine($"@{userInfo.Id} Username: {userInfo.Username}");
        }

        public void Start()
        {
            client.StartReceiving(updateHandler: UpdateHandler,
                                  pollingErrorHandler: ErrorHandler);
        }
        #endregion

        #region -- Private Methods --
        private Task ErrorHandler(ITelegramBotClient bot, Exception ex, CancellationToken ct)
        {
            Console.WriteLine(ex);
            return Task.CompletedTask;
        }

        private async Task UpdateHandler(ITelegramBotClient bot, Update update, CancellationToken ct)
        {


            if (update.Message == null)
            {
                return;
            }

            var id = update.Message.Chat.Id;
            var msg = update.Message.Text;

            if (action == string.Empty)
            {
                CheckMessage(msg, id);
            }
            else
            {
                ActionHandler(msg, id);
            }

            //<b></b> <strong></strong>
            //<i></i> <em></em>
            //<u></u> <ins></ins>
            //<s></s> <strike></strike> <del></del>
            //<tg-spoiler></tg-spoiler>
            string resultMsg= $"""
                Bolt:
                <b>{msg}</b>
                <strong>{msg}</strong>

                Italic:
                <i>{msg}</i>
                <em>{msg}</em>

                Underline:
                <u>{msg}</u>
                <ins>{msg}</ins>

                Strike:
                <s>{msg}</s>
                <strike>{msg}</strike>
                <del>{msg}</del>

                TG-spoiler:
                <tg-spoiler>{msg}</tg-spoiler>

                Link:
                come <a href="google.com">here</a>
                Look this<a href="tg://user?id=1728238356">user</a>
                """;
            //await client.SendTextMessageAsync(chatId: id,
            //                                  text: resultMsg,
            //                                  parseMode: ParseMode.Html,
            //                                  disableWebPagePreview: true);
        }

        private async void CheckMessage(string msg, long id)
        {
            if (msg == Constants.START_BUTTON)
            { 
                StartMessageHandler(id);
            }
            if(msg == Constants.BOLT_BUTTON)
            {
                action = Constants.BOLT_BUTTON;
            }
            if(msg == Constants.ITALIC_BUTTON)
            {
                action = Constants.ITALIC_BUTTON;
            }
            if (msg == Constants.UNDERLINE_BUTTON)
            {
                action = Constants.UNDERLINE_BUTTON;
            }
            await client.SendTextMessageAsync(chatId:id, 
                                              text:"Wait for your message!");
        }
        private void ActionHandler(string msg, long id)
        {
            if(action == Constants.BOLT_BUTTON)
            {
                SendFormatMessage(id, "b", msg);
            }
            if (action == Constants.ITALIC_BUTTON)
            {
                SendFormatMessage(id, "i", msg);
            }
            if (action == Constants.UNDERLINE_BUTTON)
            {
                SendFormatMessage(id, "u", msg);
            }

            action = string.Empty;
        }

        private async void SendFormatMessage(long id, string format, string msg)
        {
            await client.SendTextMessageAsync(chatId: id,
                                              text: $"<{format}>{msg}</{format}>",
                                              parseMode: ParseMode.Html);
        }

        private async void StartMessageHandler(long id)
        {
            KeyboardButton[][] keyboardButtons =
            {
                new KeyboardButton[]{Constants.BOLT_BUTTON, Constants.ITALIC_BUTTON},
                new KeyboardButton[]{ Constants.UNDERLINE_BUTTON,Constants.STRIKE_BUTTON ,Constants.SPOILER_BUTTON },
                new KeyboardButton[]{ Constants.LINK_BUTTON }
            };
            ReplyKeyboardMarkup markup = new(keyboardButtons)
            {
                ResizeKeyboard = true
            };

            await client.SendTextMessageAsync(chatId: id,
                                              text: "Choice button!",
                                              replyMarkup: markup);
        }

        private string action = string.Empty;
        #endregion
    }
}
