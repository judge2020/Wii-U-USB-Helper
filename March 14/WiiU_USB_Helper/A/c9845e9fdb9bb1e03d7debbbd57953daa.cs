// Decompiled with JetBrains decompiler
// Type: A.c9845e9fdb9bb1e03d7debbbd57953daa
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;

namespace A
{
  internal static class c9845e9fdb9bb1e03d7debbbd57953daa
  {
    internal static string RootUrl { get; set; }

    public static byte[] c74f27cd3e598cfee27465b79a3868b62(cba6aa8f767d2e8dfbca2d43d7148c173 c3cab5319dc016deb050deb101e927b2f)
    {
      string cca76947157f6ec86b4babf9451d03287 = c9845e9fdb9bb1e03d7debbbd57953daa.cfeefbcc194b85abe883ed4cb8d8befc3(c3cab5319dc016deb050deb101e927b2f);
      return c1d5d0d4f9464e1d296ba85cf189ecad6.cfbf162b4311a1d065e7071c4a8cd2925(cad8c01cdf4965a5f4a2feed04bb30913.c1df95097ffa57d753c5fe1353cf65e86(c3cab5319dc016deb050deb101e927b2f.TitleId), cca76947157f6ec86b4babf9451d03287, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7580), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7584) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7588) != 0);
    }

    public static string c75849a5e059fc931e933ac3fe0633876()
    {
      return string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6305), (object) c9845e9fdb9bb1e03d7debbbd57953daa.RootUrl);
    }

    public static string ca83128d40ffa17be7a4361e67e85365c(cba6aa8f767d2e8dfbca2d43d7148c173 c3cab5319dc016deb050deb101e927b2f, string c6137549fa9273d62aada9a197f891199)
    {
      return string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6332), (object) c9845e9fdb9bb1e03d7debbbd57953daa.RootUrl, (object) c3cab5319dc016deb050deb101e927b2f.TitleId, (object) c6137549fa9273d62aada9a197f891199);
    }

    public static string cb7d0da9171f9af8ce4271b196826eed3(cba6aa8f767d2e8dfbca2d43d7148c173 c3cab5319dc016deb050deb101e927b2f)
    {
      return string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6367), (object) c9845e9fdb9bb1e03d7debbbd57953daa.RootUrl, (object) c3cab5319dc016deb050deb101e927b2f.TitleId);
    }

    public static c0c29f108584f137c614f55b15004c742 cd74abe33c12cc4ac56c5e7e6b56b1f30(cce1cf1e0b6971ed6f7ef86a83b0959b6 c3cab5319dc016deb050deb101e927b2f)
    {
      return JsonConvert.DeserializeObject<c649fdcff08232d6e9696cb839e1b6022>(new c1787c51468b07dafcfbe2abfbc5bb04b().c8bcd354e13406e1beb37ee2eb32909c0(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6404), (object) c9845e9fdb9bb1e03d7debbbd57953daa.RootUrl, (object) c3cab5319dc016deb050deb101e927b2f.TitleId))).Title;
    }

    private static string cfeefbcc194b85abe883ed4cb8d8befc3(cba6aa8f767d2e8dfbca2d43d7148c173 c3cab5319dc016deb050deb101e927b2f)
    {
      return new c1787c51468b07dafcfbe2abfbc5bb04b().c8bcd354e13406e1beb37ee2eb32909c0(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6471), (object) c9845e9fdb9bb1e03d7debbbd57953daa.RootUrl, (object) c3cab5319dc016deb050deb101e927b2f.TitleId));
    }
  }
}
