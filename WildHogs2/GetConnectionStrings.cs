using System.Runtime.Versioning;

using Microsoft.Win32;

namespace WildHogs2
{
    public class GetConnectionStrings
    {
        [SupportedOSPlatform("windows")]
        public string GetConnectionString(string name) => Registry.LocalMachine.OpenSubKey("System")!.OpenSubKey("CurrentControlSet")!.OpenSubKey("Control")!.OpenSubKey("Session Manager")!.OpenSubKey("Environment")!.GetValue($"ConnectionStrings__{name}")?.ToString() ?? "";
    }
}
