// Decompiled with JetBrains decompiler
// Type: A.c6b77ba122628e02788f74fe0f89197d9
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using System;
using System.IO;

namespace A
{
  internal class c6b77ba122628e02788f74fe0f89197d9 : cc6dede17deea63b67c3e0eb84bf12bb3
  {
    private readonly byte[] cca0368413620d167a85cf05a116fa446;

    public c6b77ba122628e02788f74fe0f89197d9(cba6aa8f767d2e8dfbca2d43d7148c173 c36dd98eb0c08ea087627a40c6663c9a8)
    {
      byte[] numArray = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7495));
      int cecb96267e559a56c4f543488b117e4fc = 7499;
      cb85779efa5f9c78fa841b92dceca9094.c4139b678b1d9d2901dd7edcf69793526((Array) numArray, cecb96267e559a56c4f543488b117e4fc);
      this.cca0368413620d167a85cf05a116fa446 = numArray;
      // ISSUE: explicit constructor call
      base.\u002Ector(c36dd98eb0c08ea087627a40c6663c9a8, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6107), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6120));
    }

    protected override string cbd49da1b139537c117237fef73cb00a6()
    {
      return Path.Combine(this.c04b4e6eaf974f76e23c9533b68fbee41, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6071));
    }

    protected override string cb85dafae1f67c1dc25305f1961a9680a()
    {
      return Path.Combine(this.c24e473def534920571d33a53d489a74c, this.c36dd98eb0c08ea087627a40c6663c9a8.c0f5bf28fdcef3397fbbb3ca192f34d08(), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6092));
    }

    protected override void c066333ce3593d90c58c8de0f5232ec28()
    {
      if (!File.Exists(this.cb85dafae1f67c1dc25305f1961a9680a()))
      {
label_1:
        switch (1)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c6b77ba122628e02788f74fe0f89197d9.c066333ce3593d90c58c8de0f5232ec28);
            }
            this.c04cfcac61652be3faa2a62c8ddeabf3d();
            BinaryReader binaryReader = new BinaryReader((Stream) File.Open(this.c55a5d8ae0323b4832e546dcec3994ea5(), (FileMode) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7447)));
            try
            {
              FileStream fileStream = File.Create(this.cb85dafae1f67c1dc25305f1961a9680a());
              try
              {
                cc6dede17deea63b67c3e0eb84bf12bb3.c154fcb89e592cf024eb397302d3d5069(binaryReader.BaseStream, this.cca0368413620d167a85cf05a116fa446);
                binaryReader.BaseStream.Seek((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7451), (SeekOrigin) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7455));
                byte[] buffer = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4(cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7459));
                binaryReader.Read(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7463), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7467));
                Array.Reverse((Array) buffer);
                long num = (long) ((int) BitConverter.ToUInt16(buffer, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7471)) * cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7475));
                binaryReader.BaseStream.Seek((long) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7479), (SeekOrigin) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7483));
                byte[] numArray = cf6c44ce1629f394b5ef11499eb386125.c27c941905305b0ff3e7324bc79625bf4((int) checked ((IntPtr) num));
                binaryReader.Read(numArray, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7487), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(numArray));
                fileStream.Write(numArray, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7491), (int) c66a1c83bdee03fa41a70c643b5176698.c572aba370be49804cbdb0b35312bea94(numArray));
                break;
              }
              finally
              {
                if (fileStream != null)
                {
label_8:
                  switch (3)
                  {
                    case 0:
                      goto label_8;
                    default:
                      fileStream.Dispose();
                      break;
                  }
                }
              }
            }
            finally
            {
              if (binaryReader != null)
              {
label_12:
                switch (5)
                {
                  case 0:
                    goto label_12;
                  default:
                    binaryReader.Dispose();
                    break;
                }
              }
            }
        }
      }
      this.ccf65faa6e27f93aff8feac8d628ba99a();
    }
  }
}
