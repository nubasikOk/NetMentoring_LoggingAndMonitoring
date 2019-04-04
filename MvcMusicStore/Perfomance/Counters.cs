using PerformanceCounterHelper;
using System.Diagnostics;

namespace MvcMusicStore.Perfomance
{
    [PerformanceCounterCategory("MvcMusicStore", PerformanceCounterCategoryType.MultiInstance, "MvcMusicStore")]
    public enum Counters
    {
        [PerformanceCounter("Login", "Login number", PerformanceCounterType.NumberOfItems32)]
        Login,


        [PerformanceCounter("Registration", "Registration  number", PerformanceCounterType.NumberOfItems32)]
        Registration,

        [PerformanceCounter("Logoff", "Logoff  number", PerformanceCounterType.NumberOfItems32)]
        Logoff
    }
}