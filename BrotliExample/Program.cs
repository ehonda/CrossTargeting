using System;
using System.IO;
using System.IO.Compression;

var brotli = new BrotliStream(new MemoryStream(), (CompressionLevel) 11);

Console.WriteLine($"{brotli.CanWrite}");
