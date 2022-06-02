using MyProjectImpulso.Debugging;

namespace MyProjectImpulso
{
    public class MyProjectImpulsoConsts
    {
        public const string LocalizationSourceName = "MyProjectImpulso";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "87a8559aa9cf482eb14ba2f21da9a307";
    }
}
