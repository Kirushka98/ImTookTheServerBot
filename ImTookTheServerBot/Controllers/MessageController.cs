using System.Threading.Tasks;
using System.Web.Http.Results;
using Telegram.Bot.Types;
using ImTookTheServerBot.Models;
using System.Web.Mvc;
using System.Web.Http;

namespace ImTookTheServerBot.Controllers
{
    public class MessageController : ApiController
    {
        [System.Web.Http.Route(@"api/message/update")] //webhook url part
        public async Task<OkResult> Update([FromBody] Update update)
        {
            var commands = Bot.Commands;
            var message = update.Message;
            var client = await Bot.Get();

            foreach (var command in commands)
            {
                if (command.Contains(message.Text))
                {
                    await command.Execute(message, client);
                    break;
                }
            }

            return Ok();
        }
    }
}