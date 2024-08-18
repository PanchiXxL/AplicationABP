using Example.Debugging;

namespace Example
{
    public class ExampleConsts
    {
        public const string LocalizationSourceName = "Example";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "060a77f765dc475a8a7c6a1e1f4b1880";
    }
}
