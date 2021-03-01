using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;

namespace CommandsRP.Commands
{
    public class EMS : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "ems";

        public string Help => "";

        public string Syntax => throw new NotImplementedException();

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "rpchat.ems" };

        public void Execute(IRocketPlayer caller, string[] args)
        {
            if (args.Length == 0) return;
            string iconURL = MQSPlugin.Instance.Configuration.Instance.EMSIcon;
            var papa1 = string.Join(" ", args);
            ChatManager.serverSendMessage(MQSPlugin.Instance.Configuration.Instance.EMSFormat.Replace('{', '<').Replace('}', '>') + papa1, MQSPlugin.Instance.MessageColor, null, null, EChatMode.GLOBAL, iconURL, true);


        }
    }
}
