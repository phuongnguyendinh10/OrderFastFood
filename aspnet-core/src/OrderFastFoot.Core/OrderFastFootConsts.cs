using OrderFastFoot.Debugging;

namespace OrderFastFoot
{
    public class OrderFastFootConsts
    {
        public const string LocalizationSourceName = "OrderFastFoot";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "6c4261818c91400abb648432c1fb30d3";
    }
}
