using System.IO.Compression;
using JetBrains.Annotations;

namespace BrotliPackage;

[PublicAPI]
public static class SomeExport
{
    public static bool Bool() => new BrotliStream(new MemoryStream(), (CompressionLevel) 11).CanWrite;
}
