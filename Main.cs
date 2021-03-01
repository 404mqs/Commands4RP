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
        public string AnonFormat { get; private set; }
        public string AnonIcon { get; private set; }
        public string EMSFormat { get; private set; }
        public string EMSIcon { get; private set; }
        public string MeFormat { get; private set; }
        public string MeIcon { get; private set; }
        public string OOCFormat { get; private set; }
        public string OOCIcon { get; private set; }
        public string PoliceFormat { get; private set; }
        public string PoliceIcon { get; private set; }
        public string SOSFormat { get; private set; }
        public string SOSIcon { get; private set; }
        public string StaffFormat { get; private set; }
        public string StaffIcon { get; private set; }
        public string TaxiFormat { get; private set; }
        public string TaxiIcon { get; private set; }
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
