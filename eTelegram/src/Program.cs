namespace src;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
class Program
{    
    static async Task Main(string[] args)
    {
        var botClient = new TelegramBotClient("CHAVE DO SEU BOT");
        var chatId = ""; //Id da conversa
        var message = "Data:" + DateTime.Now;

        await botClient.SendTextMessageAsync(chatId, message);
    }
}