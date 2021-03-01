using Rocket.API;
using Rocket.API.Collections;
using Rocket.Core.Commands;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;

namespace CommandsRP
{
    public class MQSPlugin : RocketPlugin<Config>

    {
        public static MQSPlugin Instance;

        public UnityEngine.Color MessageColor { get; private set; }
        public string TweetFormat { get; private set; }
        public string TweetIcon { get; private set; }
        protected override void Load()
        {
            {
                MQSPlugin.Instance = this;
                MessageColor = UnturnedChat.GetColorFromName(Configuration.Instance.MessageColor, UnityEngine.Color.white);
                Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
                Logger.LogWarning($"[{Name}] has been loaded! ");
                Logger.LogWarning("Dev: MQS#7816");
                Logger.LogWarning("Join this Discord for Support: https://discord.gg/Ssbpd9cvgp");
                Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");

            }
        }

        protected override void Unload()
        {
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            Logger.LogWarning($"[{Name}] has been unloaded! ");
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");

        }


    }

}
