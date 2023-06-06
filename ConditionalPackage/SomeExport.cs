using JetBrains.Annotations;

namespace ConditionalPackage;

[PublicAPI]
public class SomeExport
{
    public static bool Bool() =>
#if NET6_0
        true;
#else
        false;
#endif
    
    public static string String() =>
#if NET6_0
        "net6.0";
#else
        "net7.0";
#endif
}
