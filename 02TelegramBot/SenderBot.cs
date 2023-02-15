using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace _02TelegramBot
{
    internal class SenderBot
    {
        private TelegramBotClient client;

        public SenderBot(string token)
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
            Console.WriteLine("Error");
            return Task.CompletedTask;
        }

        private async Task UpdateHandler(ITelegramBotClient bot, Update update, CancellationToken ct)
        {
            if (isFirstStart)
            {
                Console.WriteLine($"Id\t\tUsername\tDate");
                isFirstStart = false;
            }
            //Hello
            //hello
            //heLLo
            // /start
            var user = update.Message.From;
            var text = update.Message.Text;
            Console.WriteLine($"{user.Id}\t{user.Username}\t{DateTime.UtcNow.AddHours(2)}");
        }
        #endregion

        #region -- Private Propertis
        private bool isFirstStart = true;
        #endregion

    }
}
