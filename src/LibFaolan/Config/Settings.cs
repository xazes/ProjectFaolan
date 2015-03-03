using System;

namespace LibFaolan.Config
{
    public sealed class Settings
    {
        private static Ini _ini;
        public static string UniverseAgentAddress;
        public static ushort UniverseAgentPort;
        public static string PlayerAgentAddress;
        public static ushort PlayerAgentPort;
        public static string CSPlayerAgentAddress;
        public static ushort CSPlayerAgentPort;
        public static string AgentServerAddress;
        public static ushort AgentServerPort;
        public static string GameServerAddress;
        public static ushort GameServerPort;
        public static uint CharacterSlots;
        public static string MySqlAddress;
        public static ushort MySqlPort;
        public static string MySqlDatabase;
        public static string MySqlUsername;
        public static string MySqlPassword;

        public static bool Load(string path)
        {
            try
            {
                _ini = new Ini(path);
                _ini.Load();

                UniverseAgentAddress = _ini.GetValue("UniverseAgentAddress");
                UniverseAgentPort = UInt16.Parse(_ini.GetValue("UniverseAgentPort"));

                PlayerAgentAddress = _ini.GetValue("PlayerAgentAddress");
                PlayerAgentPort = UInt16.Parse(_ini.GetValue("PlayerAgentPort"));

                CSPlayerAgentAddress = _ini.GetValue("CSPlayerAgentAddress");
                CSPlayerAgentPort = UInt16.Parse(_ini.GetValue("CSPlayerAgentPort"));

                AgentServerAddress = _ini.GetValue("AgentServerAddress");
                AgentServerPort = UInt16.Parse(_ini.GetValue("AgentServerPort"));

                GameServerAddress = _ini.GetValue("GameServerAddress");
                GameServerPort = UInt16.Parse(_ini.GetValue("GameServerPort"));

                CharacterSlots = UInt32.Parse(_ini.GetValue("CharacterSlots"));

                MySqlAddress = _ini.GetValue("MySqlAddress");
                MySqlPort = UInt16.Parse(_ini.GetValue("MySqlPort"));
                MySqlDatabase = _ini.GetValue("MySqlDatabase");
                MySqlUsername = _ini.GetValue("MySqlUsername");
                MySqlPassword = _ini.GetValue("MySqlPassword");

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Save()
        {
            try
            {
                _ini.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}