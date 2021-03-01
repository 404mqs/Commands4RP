using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;

namespace CommandsRP.Commands
{
    public class SOS : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "sos";

        public string Help => "";

        public string Syntax => throw new NotImplementedException();

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "rpchat.sos" };

        public void Execute(IRocketPlayer caller, string[] args)
        {
            var player = (UnturnedPlayer)caller;
            var name = player.DisplayName;
            var playername = "!playerName!";
            var papa1 = string.Join(" ", args);
            string iconURL = "";
            ChatManager.serverSendMessage(MQSPlugin.Instance.Configuration.Instance.SOSFormat.Replace('{', '<').Replace('}', '>').Replace(playername, name) + papa1, MQSPlugin.Instance.MessageColor, null, null, EChatMode.GLOBAL, iconURL, true);


        }
    }
}

