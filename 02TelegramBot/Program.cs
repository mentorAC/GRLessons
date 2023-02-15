using _02TelegramBot;

string token = "6175168448:AAHER4Cnr0DQkwUIwOsRonJgqrDtlZE8QEw";

SenderBot sender = new SenderBot(token);
sender.GetStatus();
sender.Start();

Console.ReadLine();