// Decompiled with JetBrains decompiler
// Type: Updater.FileToDownload
// Assembly: Updater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7FC3B5C5-5FF7-42B2-B7F0-8C213AAF0FEC
// Assembly location: C:\Users\hunte\Documents\DECompiles\Updater.exe

namespace Updater
{
  internal sealed class FileToDownload
  {
    public string Hash { get; }

    public string Name { get; }

    public long Size { get; }

    public FileToDownload(string name, string hash, long size)
    {
      this.Name = name;
      this.Hash = hash;
      this.Size = size;
    }
  }
}
