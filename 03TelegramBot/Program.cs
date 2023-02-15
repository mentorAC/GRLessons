
using _03TelegramBot;

string token = "6175168448:AAHER4Cnr0DQkwUIwOsRonJgqrDtlZE8QEw";

FormatedBot bot = new FormatedBot(token);

bot.Start();
bot.GetStatus();
Console.ReadLine();