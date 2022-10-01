using Microsoft.AspNetCore.Mvc;
using SimpleWebChat.Models;

namespace SimpleWebChat.Controllers
{
    public class ChatController : Controller
    {
        private static List<KeyValuePair<string, string>> Messages = new List<KeyValuePair<string, string>>();

        public IActionResult Show()
        {
            if (Messages.Count() < 1)
            {
                return View(new ChatViewModel());
            }

            var chatModel = new ChatViewModel()
            {
                Messages = Messages.Select(m => new MessageViewModel()
                {
                    Sender = m.Key,
                    MessageText = m.Value
                }).ToList()
            };

            return View(chatModel);
        }

        [HttpPost]
        public IActionResult Send(ChatViewModel chat)
        {
            var newMessages = chat.CurrentMessage;

            Messages.Add(new KeyValuePair<string, string>(newMessages.Sender, newMessages.MessageText));

            return RedirectToAction("Show");
        }
    }
}
