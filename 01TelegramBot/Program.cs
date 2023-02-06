using Telegram.Bot;
using Telegram.Bot.Types;

string token = "6175168448:AAHER4Cnr0DQkwUIwOsRonJgqrDtlZE8QEw";

var client = new TelegramBotClient(token);

var user = await client.GetMeAsync();

Console.WriteLine($"@{user.Id} User name: {user.Username}\nName:{user.FirstName}");

client.StartReceiving(
    updateHandler: UpdateHandler,
    pollingErrorHandler:ErrorHandler);


Console.ReadLine();


Task UpdateHandler(ITelegramBotClient bot,
                   Update update,
                   CancellationToken cls)
{
    var text = update.Message.Text;
    var user = update.Message.From;
    Console.WriteLine($"User: {user.FirstName} text: {text}");

    return Task.CompletedTask;
}

Task ErrorHandler(ITelegramBotClient bot,
                  Exception ex,
                  CancellationToken cls)
{
    Console.WriteLine("Error");
    return Task.CompletedTask;
}