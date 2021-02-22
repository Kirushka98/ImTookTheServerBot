using Telegram.Bot.Types;
using Telegram.Bot;
using System.Threading.Tasks;

namespace ImTookTheServerBot.Models.Commands
{
    public abstract class Command
    {
        public abstract string Name { get; }

        public abstract Task Execute(Message message, TelegramBotClient client);

        public bool Contains(string command)
        {
            return command.Contains(this.Name) && command.Contains(AppSettings.Name);
        }

    }
}