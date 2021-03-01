using Rocket.API;


namespace CommandsRP
{

    public class Config : IRocketPluginConfiguration

    {
        public string MessageColor { get; set; }
        public string AnonFormat;
        public string AnonIcon;
        public string EMSFormat;
        public string EMSIcon;
        public string MeFormat;
        public string MeIcon;
        public string OOCFormat;
        public string OOCIcon;
        public string PoliceFormat;
        public string PoliceIcon;
        public string SOSFormat;
        public string SOSIcon;
        public string StaffFormat;
        public string StaffIcon;
        public string TaxiFormat;
        public string TaxiIcon;
        public string TweetFormat;
        public string TweetIcon;

        public void LoadDefaults()
        {
            MessageColor = "white";
            AnonFormat = "{color=#00acee}{b}AnonTweet: {/b}{/color}{color=#E6E6E6}{i} ";
            AnonIcon = "URL";
            EMSFormat = "{color=#FF5A5A}[EMS Voice]:{/color}";
            EMSIcon = "URL";
            MeFormat = "{color=#E94EFF}[ME] -- !playerName! {/color}: ";
            MeIcon = "URL";
            OOCFormat = "{color=#D5D5D5}[OOC] -- !playerName!: {i} ";
            OOCIcon = "URL";
            PoliceFormat = "{color=blue}[Police Voice]{/color} ";
            PoliceIcon = "URL";
            SOSFormat = "{color=#A9AFAE}[{/color}{color=red}SOS{/color}{color=#A9AFAE}]{/color} " + "!playerName! SEND A SOS SIGNAL. HELP HIM!";
            SOSIcon = "URL";
            StaffFormat = "{color=#9224C2}[Server Staff]{/color} ";
            StaffIcon = "URL";
            TaxiFormat = "{color=yellow}[Taxi]{/color} -- {color=#00FFFB} !playerName!{/color}: ";
            TaxiIcon = "URL";
            TweetFormat = "{color=#00C5FF}[Tweet]{/color}{color=white} @!playerName!:{/color} ";
            TweetIcon = "URL";

        }
    }
}


