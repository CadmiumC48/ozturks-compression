using System;
using System.IO;
using System.IO.Compression;

namespace CadmiumC4.IO.Compression
{
    partial class Compote
    {
          public partial DirectoryInfo TemporaryDirectory
          {
          }
          ///<summary>
          ///Compresses a file.
          ///</summary>
          public void Compress(FileInfo file, string finalPath)
          {
                FragmentFile(file);
                ZipFile.CreateFromDirectory($@"{TemporaryDirectory.FullPath}\{file.Name}",$@"{Path.ChangeExtension(finalPath,"cpot")}");
          }
    }
}
