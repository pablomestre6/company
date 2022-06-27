using company.Debugging;

namespace company
{
    public class companyConsts
    {
        public const string LocalizationSourceName = "company";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "e9949e7d45324d66a37d24d559d065cb";
    }
}
