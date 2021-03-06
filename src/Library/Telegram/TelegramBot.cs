
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace Library
{
    public class TelegramBot
    {

        private const string TELEGRAM_BOT_TOKEN = "2121492551:AAFIkWzYEa9uZdCLkd73TZ9AFSjoPDXTvOU";
        private static TelegramBot instance;
        private ITelegramBotClient bot;

        private TelegramBot()
        {
            this.bot = new TelegramBotClient(TELEGRAM_BOT_TOKEN);
        }

        public ITelegramBotClient Client
        {
            get
            {
                return this.bot;
            }
        }

        private User BotInfo
        {
            get
            {
                return this.Client.GetMeAsync().Result;
            }
        }

        public int BotId
        {
            get
            {
                return this.BotInfo.Id;
            }
        }

        public string BotName
        {
            get
            {
                return this.BotInfo.FirstName;
            }
        }

        public static TelegramBot Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TelegramBot();
                }
                return instance;
            }
        }
    }
}
