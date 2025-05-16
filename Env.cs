using System.Collections;

namespace BoostLib
{
    public static class Env
    {
        public static IEnumerable<string> GetVariableNames()
        {
            return Environment.GetEnvironmentVariables().Keys.Cast<string>();
        }

        public static Dictionary<string, string?> GetVariables()
        {
            return Environment.GetEnvironmentVariables().Cast<DictionaryEntry>().ToDictionary(kv => (string)kv.Key, kv => (string?)kv.Value);
        }

        public static string? GetVariableValue(string variableName)
        {
            return Environment.GetEnvironmentVariable(variableName);
        }
    }
}
