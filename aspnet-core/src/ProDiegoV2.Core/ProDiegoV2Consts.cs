using ProDiegoV2.Debugging;

namespace ProDiegoV2
{
    public class ProDiegoV2Consts
    {
        public const string LocalizationSourceName = "ProDiegoV2";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = false;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "800e7c7c096c458aa725c65eb25ce421";
    }
}
