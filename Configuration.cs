﻿using Rocket.API;

namespace FakeInfo
{
    public class Configuration : IRocketPluginConfiguration
    {
        public bool Logging;

        public bool InvisibleRocket;
        public bool HidePlugins;
        public bool MessPlugins;
        public string[] Plugins;

        public bool HideWorkshop;
        public bool MessWorkshop;
        public string[] Workshop;

        public bool MessGamemode;
        public string Gamemode;

        public bool HideConfig;
        public bool MessConfig;
        public bool IsPVP;
        public bool HasCheats;
        public string Difficulty;
        public string CameraMode;
        public bool GoldOnly;
        public bool HasBattleye;
        public bool IsVanilla;

        public void LoadDefaults()
        {
            Logging = true;
            InvisibleRocket = false;
            HidePlugins = false;
            MessPlugins = false;
            Plugins = new string[]
            {
                "Plugins removed by",
                "FakeInfo",
                "AtiLion is gay"
            };

            HideWorkshop = true;
            MessWorkshop = false;
            Workshop = new string[]
            {
                "936182532",
                "1112690830"
            };

            MessGamemode = false;
            Gamemode = "Nothing you have ever seen before";

            HideConfig = true;
            MessConfig = false;
            IsPVP = true;
            HasCheats = false;
            Difficulty = "NRM";
            CameraMode = "2Pp";
            GoldOnly = false;
            HasBattleye = true;
            IsVanilla = false;
        }
    }
}
