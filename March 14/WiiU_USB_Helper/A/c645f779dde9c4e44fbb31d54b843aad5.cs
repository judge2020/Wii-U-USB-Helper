// Decompiled with JetBrains decompiler
// Type: A.c645f779dde9c4e44fbb31d54b843aad5
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53F3B763-91AD-42E2-A50A-799F56CC72D8
// Assembly location: C:\Users\hunte\Documents\DECompiles\WiiU_USB_Helper.exe

using Newtonsoft.Json;
using NusHelper;
using NusHelper.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A
{
  internal class c645f779dde9c4e44fbb31d54b843aad5
  {
    private readonly string ca4e8d54e24ab482226b960f36bba63b8;
    private readonly string cdc49f4b2c030c098ac328d90fe1b4ea8;
    private readonly string c386b7675029f1e76df8f6889c2a41427;
    private readonly string cf3a55d9f54934e53ef13de82529e0760;

    public c645f779dde9c4e44fbb31d54b843aad5(string cbf84ff2fbce63c6a66f25ffd74a04a4f, string c51fcfb6e483ce18666a5e8fa296f18ec, string cc9d4416fd669e1b2f05387726df9a715, string c3531e4173c1d73d4b06813464a3417fb)
    {
      this.cf3a55d9f54934e53ef13de82529e0760 = cbf84ff2fbce63c6a66f25ffd74a04a4f;
      this.cdc49f4b2c030c098ac328d90fe1b4ea8 = cc9d4416fd669e1b2f05387726df9a715;
      this.c386b7675029f1e76df8f6889c2a41427 = c51fcfb6e483ce18666a5e8fa296f18ec;
      this.ca4e8d54e24ab482226b960f36bba63b8 = c3531e4173c1d73d4b06813464a3417fb;
    }

    public List<c645f779dde9c4e44fbb31d54b843aad5.c1ab5887247831e89bcc558f19ea04e29> ce70868564ef0283832d43a43c40c6d08()
    {
      if (cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(this.cdc49f4b2c030c098ac328d90fe1b4ea8, ""))
      {
label_1:
        switch (4)
        {
          case 0:
            goto label_1;
          default:
            if (1 == 0)
            {
              // ISSUE: method reference
              RuntimeMethodHandle runtimeMethodHandle = __methodref (c645f779dde9c4e44fbb31d54b843aad5.ce70868564ef0283832d43a43c40c6d08);
            }
            return new List<c645f779dde9c4e44fbb31d54b843aad5.c1ab5887247831e89bcc558f19ea04e29>();
        }
      }
      else
      {
        List<c645f779dde9c4e44fbb31d54b843aad5.c1ab5887247831e89bcc558f19ea04e29> source = JsonConvert.DeserializeObject<List<c645f779dde9c4e44fbb31d54b843aad5.c1ab5887247831e89bcc558f19ea04e29>>(this.cdc49f4b2c030c098ac328d90fe1b4ea8);
        // ISSUE: reference to a compiler-generated field
        Func<c645f779dde9c4e44fbb31d54b843aad5.c1ab5887247831e89bcc558f19ea04e29, bool> predicate = c645f779dde9c4e44fbb31d54b843aad5.\u003C\u003Ec.c56ecc1d647404f5e2c4554f0ef3b419f;
        if (predicate == null)
        {
label_6:
          switch (5)
          {
            case 0:
              goto label_6;
            default:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              predicate = c645f779dde9c4e44fbb31d54b843aad5.\u003C\u003Ec.c56ecc1d647404f5e2c4554f0ef3b419f = new Func<c645f779dde9c4e44fbb31d54b843aad5.c1ab5887247831e89bcc558f19ea04e29, bool>(c645f779dde9c4e44fbb31d54b843aad5.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.cb32ceca59bdd0fec8c596a4a08ab41ab);
              break;
          }
        }
        return source.Where<c645f779dde9c4e44fbb31d54b843aad5.c1ab5887247831e89bcc558f19ea04e29>(predicate).ToList<c645f779dde9c4e44fbb31d54b843aad5.c1ab5887247831e89bcc558f19ea04e29>();
      }
    }

    public void c23e041dd9fccdd9676ced356f8de2fa3()
    {
      using (List<c645f779dde9c4e44fbb31d54b843aad5.c1ab5887247831e89bcc558f19ea04e29>.Enumerator enumerator = this.ce70868564ef0283832d43a43c40c6d08().GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          c645f779dde9c4e44fbb31d54b843aad5.c1ab5887247831e89bcc558f19ea04e29 current = enumerator.Current;
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          c645f779dde9c4e44fbb31d54b843aad5.c1474db5bac8efb6483f0e7fe84116e85 c1474db5bac8efb6483f0e7fe84116e85 = new c645f779dde9c4e44fbb31d54b843aad5.c1474db5bac8efb6483f0e7fe84116e85();
          TitleId index = new TitleId(current.titleID.Trim());
          if (!((IEnumerable<string>) ca377ebace9a9e1ffac7b0c5a9158e838.cbf364c1610ec92ddca93281741d52e4e).Contains<string>(cad8c01cdf4965a5f4a2feed04bb30913.c1df95097ffa57d753c5fe1353cf65e86(index)))
          {
label_3:
            switch (1)
            {
              case 0:
                goto label_3;
              default:
                if (1 == 0)
                {
                  // ISSUE: method reference
                  RuntimeMethodHandle runtimeMethodHandle = __methodref (c645f779dde9c4e44fbb31d54b843aad5.c23e041dd9fccdd9676ced356f8de2fa3);
                }
                string cca76947157f6ec86b4babf9451d03287 = current.titleKey.Trim();
                // ISSUE: reference to a compiler-generated field
                c1474db5bac8efb6483f0e7fe84116e85.ca07972acde10926c077adb10e0e60439 = HttpUtility.HtmlDecode(current.name.Trim()).Replace(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6958), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6961));
                // ISSUE: reference to a compiler-generated field
                c1474db5bac8efb6483f0e7fe84116e85.cd47a8862dc253a9ef4c1baa0b8cbdb0a = current.region.Trim();
                if (ca377ebace9a9e1ffac7b0c5a9158e838.c6cb7f1dc1e8dcf6340fd2d8879ea2986.ContainsKey(index.FullGame))
                {
label_7:
                  switch (7)
                  {
                    case 0:
                      goto label_7;
                    default:
                      DbRow dbRow = ca377ebace9a9e1ffac7b0c5a9158e838.c6cb7f1dc1e8dcf6340fd2d8879ea2986[index.FullGame];
                      cfcd12ee63ba7d661f4ab310574290bf9 idType = index.IdType;
                      if (idType != (cfcd12ee63ba7d661f4ab310574290bf9) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7632))
                      {
label_9:
                        switch (6)
                        {
                          case 0:
                            goto label_9;
                          default:
                            if (idType != (cfcd12ee63ba7d661f4ab310574290bf9) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7636))
                            {
label_11:
                              switch (5)
                              {
                                case 0:
                                  goto label_11;
                                default:
                                  continue;
                              }
                            }
                            else if (ca377ebace9a9e1ffac7b0c5a9158e838.c9b242add560e8c892442a59369df92f3.ContainsKey(index))
                            {
label_21:
                              switch (2)
                              {
                                case 0:
                                  goto label_21;
                                default:
                                  byte[] c9d02e186a6ec2baccf2d2d1ffb9a59dc = c1d5d0d4f9464e1d296ba85cf189ecad6.cfbf162b4311a1d065e7071c4a8cd2925(cad8c01cdf4965a5f4a2feed04bb30913.c1df95097ffa57d753c5fe1353cf65e86(index), cca76947157f6ec86b4babf9451d03287, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7668), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7672) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7676) != 0);
                                  // ISSUE: reference to a compiler-generated field
                                  // ISSUE: reference to a compiler-generated field
                                  cc0c47a7e733f93eb16513fe84807edf3 cc0c47a7e733f93eb16513fe84807edf3_1 = new cc0c47a7e733f93eb16513fe84807edf3(c1474db5bac8efb6483f0e7fe84116e85.ca07972acde10926c077adb10e0e60439, index, c1474db5bac8efb6483f0e7fe84116e85.cd47a8862dc253a9ef4c1baa0b8cbdb0a, c9d02e186a6ec2baccf2d2d1ffb9a59dc, ca377ebace9a9e1ffac7b0c5a9158e838.c9b242add560e8c892442a59369df92f3[index].c64ccfce653a8bd2c7c7ffb6b8d91766f, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(897), (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7680));
                                  int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7684);
                                  cc0c47a7e733f93eb16513fe84807edf3_1.CfwOnly = num != 0;
                                  cc0c47a7e733f93eb16513fe84807edf3 cc0c47a7e733f93eb16513fe84807edf3_2 = cc0c47a7e733f93eb16513fe84807edf3_1;
                                  ca377ebace9a9e1ffac7b0c5a9158e838.cfcd2346750159168147ab2ac51bfd758.Add(cc0c47a7e733f93eb16513fe84807edf3_2);
                                  continue;
                              }
                            }
                            else
                              continue;
                        }
                      }
                      else
                      {
                        List<ce64fe4baff0b285aaecd02e2cae2ea2c> c1c0fd38914d2630ff1a82119e1950d3c = new List<ce64fe4baff0b285aaecd02e2cae2ea2c>();
                        if (ca377ebace9a9e1ffac7b0c5a9158e838.ccbd3e6874a919fd5f984581edad55574.ContainsKey(new TitleId(cad8c01cdf4965a5f4a2feed04bb30913.c1df95097ffa57d753c5fe1353cf65e86(index.FullUpdate))))
                        {
label_13:
                          switch (4)
                          {
                            case 0:
                              goto label_13;
                            default:
                              // ISSUE: reference to a compiler-generated method
                              c1c0fd38914d2630ff1a82119e1950d3c.AddRange(ca377ebace9a9e1ffac7b0c5a9158e838.ccbd3e6874a919fd5f984581edad55574[index.FullUpdate].Select<c2e2f19e8cde9983e4129b4a047c9f5c6.cc8cce23c9cabc8c74f6621804b209224, ce64fe4baff0b285aaecd02e2cae2ea2c>(new Func<c2e2f19e8cde9983e4129b4a047c9f5c6.cc8cce23c9cabc8c74f6621804b209224, ce64fe4baff0b285aaecd02e2cae2ea2c>(c1474db5bac8efb6483f0e7fe84116e85.c7d7858efe139a46abd59d23a14d5c3e5)));
                              break;
                          }
                        }
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        cce1cf1e0b6971ed6f7ef86a83b0959b6 cce1cf1e0b6971ed6f7ef86a83b0959b6 = new cce1cf1e0b6971ed6f7ef86a83b0959b6(c1474db5bac8efb6483f0e7fe84116e85.ca07972acde10926c077adb10e0e60439, index, c1474db5bac8efb6483f0e7fe84116e85.cd47a8862dc253a9ef4c1baa0b8cbdb0a, (byte[]) null, dbRow.Size, c1c0fd38914d2630ff1a82119e1950d3c, dbRow.EshopId, dbRow.ProductCode, dbRow.IconUrl, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(897), dbRow.Platform, (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7640));
                        if (cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(current.ticket, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6964)))
                        {
label_16:
                          switch (5)
                          {
                            case 0:
                              goto label_16;
                            default:
                              string str = c0cf183ec36b835fa0e1414bdd4cd1822.c1df95097ffa57d753c5fe1353cf65e86(string.Format(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6967), (object) this.cf3a55d9f54934e53ef13de82529e0760), current.titleID, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6990));
                              cce1cf1e0b6971ed6f7ef86a83b0959b6.c01b0607eff3104877812c454678313d9 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7644) != 0;
                              cce1cf1e0b6971ed6f7ef86a83b0959b6.c3e44ecba2cc05a921770e798b38b0d77 = str;
                              break;
                          }
                        }
                        else
                        {
                          byte[] numArray = c1d5d0d4f9464e1d296ba85cf189ecad6.cfbf162b4311a1d065e7071c4a8cd2925(index.IdRaw, cca76947157f6ec86b4babf9451d03287, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7648), cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7652) != 0, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7656) != 0);
                          cce1cf1e0b6971ed6f7ef86a83b0959b6.CfwOnly = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7660) != 0;
                          cce1cf1e0b6971ed6f7ef86a83b0959b6.TicketArray = numArray;
                          cce1cf1e0b6971ed6f7ef86a83b0959b6.Ticket = c1d5d0d4f9464e1d296ba85cf189ecad6.cb5009c1058eaad54842d9bead8e530a2(cce1cf1e0b6971ed6f7ef86a83b0959b6.TicketArray, (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7664));
                        }
                        ca377ebace9a9e1ffac7b0c5a9158e838.ca32b8c3bef10c492a2adefe52dea03d4.Add(index, cce1cf1e0b6971ed6f7ef86a83b0959b6);
                        continue;
                      }
                  }
                }
                else
                  continue;
            }
          }
        }
label_24:
        switch (6)
        {
          case 0:
            goto label_24;
        }
      }
      if (cb388f9b4f7541407d5276f457649446d.c1df95097ffa57d753c5fe1353cf65e86(this.ca4e8d54e24ab482226b960f36bba63b8, ""))
      {
label_27:
        switch (4)
        {
          case 0:
            goto label_27;
        }
      }
      else
      {
        List<c645f779dde9c4e44fbb31d54b843aad5.cf023ebea540659240f7ec1cb4b26f218> cf023ebea540659240f7ec1cb4b26f218List = JsonConvert.DeserializeObject<List<c645f779dde9c4e44fbb31d54b843aad5.cf023ebea540659240f7ec1cb4b26f218>>(this.ca4e8d54e24ab482226b960f36bba63b8);
        List<c645f779dde9c4e44fbb31d54b843aad5.cf023ebea540659240f7ec1cb4b26f218> source1 = cf023ebea540659240f7ec1cb4b26f218List;
        // ISSUE: reference to a compiler-generated field
        Func<c645f779dde9c4e44fbb31d54b843aad5.cf023ebea540659240f7ec1cb4b26f218, bool> predicate1 = c645f779dde9c4e44fbb31d54b843aad5.\u003C\u003Ec.ce4fba04837d29717df1c1b88514a2b08;
        if (predicate1 == null)
        {
label_30:
          switch (4)
          {
            case 0:
              goto label_30;
            default:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              predicate1 = c645f779dde9c4e44fbb31d54b843aad5.\u003C\u003Ec.ce4fba04837d29717df1c1b88514a2b08 = new Func<c645f779dde9c4e44fbb31d54b843aad5.cf023ebea540659240f7ec1cb4b26f218, bool>(c645f779dde9c4e44fbb31d54b843aad5.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.cb13cf9c40f942a354c8874b1702e71a6);
              break;
          }
        }
        IEnumerator<c645f779dde9c4e44fbb31d54b843aad5.cf023ebea540659240f7ec1cb4b26f218> enumerator1 = source1.Where<c645f779dde9c4e44fbb31d54b843aad5.cf023ebea540659240f7ec1cb4b26f218>(predicate1).GetEnumerator();
        try
        {
          while (enumerator1.MoveNext())
          {
            c645f779dde9c4e44fbb31d54b843aad5.cf023ebea540659240f7ec1cb4b26f218 current = enumerator1.Current;
            TitleId key = new TitleId(current.titleID);
            if (ca377ebace9a9e1ffac7b0c5a9158e838.ccbd3e6874a919fd5f984581edad55574.ContainsKey(key))
            {
label_35:
              switch (1)
              {
                case 0:
                  goto label_35;
                default:
                  int index = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7688);
                  while (index < ca377ebace9a9e1ffac7b0c5a9158e838.ccbd3e6874a919fd5f984581edad55574[key].Count)
                  {
                    c2e2f19e8cde9983e4129b4a047c9f5c6.cc8cce23c9cabc8c74f6621804b209224 cc8cce23c9cabc8c74f6621804b209224 = ca377ebace9a9e1ffac7b0c5a9158e838.ccbd3e6874a919fd5f984581edad55574[key][index];
                    ca377ebace9a9e1ffac7b0c5a9158e838.ccbd3e6874a919fd5f984581edad55574[key][index] = new c2e2f19e8cde9983e4129b4a047c9f5c6.cc8cce23c9cabc8c74f6621804b209224()
                    {
                      c64ccfce653a8bd2c7c7ffb6b8d91766f = cc8cce23c9cabc8c74f6621804b209224.c64ccfce653a8bd2c7c7ffb6b8d91766f,
                      c27f5df1dc5d80dd0c87cd29e7cef11b8 = cc8cce23c9cabc8c74f6621804b209224.c27f5df1dc5d80dd0c87cd29e7cef11b8,
                      c907ca8ffa30661318a7e29e77519ea57 = cc8cce23c9cabc8c74f6621804b209224.c907ca8ffa30661318a7e29e77519ea57,
                      c80d617f05b7f95017df4cba82652d0dd = current.titleKey,
                      c330284c85ae4e7d7fee01a9e716b656b = current.encTitleKey
                    };
                    index += cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7692);
                  }
label_39:
                  switch (7)
                  {
                    case 0:
                      goto label_39;
                    default:
                      continue;
                  }
              }
            }
          }
label_41:
          switch (7)
          {
            case 0:
              goto label_41;
          }
        }
        finally
        {
          if (enumerator1 != null)
          {
label_43:
            switch (6)
            {
              case 0:
                goto label_43;
              default:
                enumerator1.Dispose();
                break;
            }
          }
        }
        List<c645f779dde9c4e44fbb31d54b843aad5.cf023ebea540659240f7ec1cb4b26f218> source2 = cf023ebea540659240f7ec1cb4b26f218List;
        // ISSUE: reference to a compiler-generated field
        Func<c645f779dde9c4e44fbb31d54b843aad5.cf023ebea540659240f7ec1cb4b26f218, bool> predicate2 = c645f779dde9c4e44fbb31d54b843aad5.\u003C\u003Ec.cbe161db3445796e0b6100b2091e01485;
        if (predicate2 == null)
        {
label_47:
          switch (6)
          {
            case 0:
              goto label_47;
            default:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              predicate2 = c645f779dde9c4e44fbb31d54b843aad5.\u003C\u003Ec.cbe161db3445796e0b6100b2091e01485 = new Func<c645f779dde9c4e44fbb31d54b843aad5.cf023ebea540659240f7ec1cb4b26f218, bool>(c645f779dde9c4e44fbb31d54b843aad5.\u003C\u003Ec.c77621037b5e8518f08b9304f2b861f38.cc0bb95d08de6722ed0524035a379c05d);
              break;
          }
        }
        IEnumerator<c645f779dde9c4e44fbb31d54b843aad5.cf023ebea540659240f7ec1cb4b26f218> enumerator2 = source2.Where<c645f779dde9c4e44fbb31d54b843aad5.cf023ebea540659240f7ec1cb4b26f218>(predicate2).GetEnumerator();
        try
        {
          while (enumerator2.MoveNext())
          {
            c645f779dde9c4e44fbb31d54b843aad5.cf023ebea540659240f7ec1cb4b26f218 current1 = enumerator2.Current;
            TitleId index = new TitleId(current1.titleID);
            if (index.IdType != (cfcd12ee63ba7d661f4ab310574290bf9) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7696))
            {
label_52:
              switch (4)
              {
                case 0:
                  goto label_52;
                default:
                  if (index.IdType == (cfcd12ee63ba7d661f4ab310574290bf9) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7700))
                  {
label_54:
                    switch (3)
                    {
                      case 0:
                        goto label_54;
                    }
                  }
                  else
                    continue;
              }
            }
            if (ca377ebace9a9e1ffac7b0c5a9158e838.c6cb7f1dc1e8dcf6340fd2d8879ea2986.ContainsKey(index))
            {
label_56:
              switch (3)
              {
                case 0:
                  goto label_56;
                default:
                  DbRow dbRow = ca377ebace9a9e1ffac7b0c5a9158e838.c6cb7f1dc1e8dcf6340fd2d8879ea2986[index];
                  string c407606821fe6034b43e547a4ca232678 = HttpUtility.HtmlDecode(current1.name.Trim()).Replace(c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6958), c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6961));
                  string cd47a8862dc253a9ef4c1baa0b8cbdb0a = current1.region.Trim();
                  List<ce64fe4baff0b285aaecd02e2cae2ea2c> c1c0fd38914d2630ff1a82119e1950d3c = new List<ce64fe4baff0b285aaecd02e2cae2ea2c>();
                  if (ca377ebace9a9e1ffac7b0c5a9158e838.ccbd3e6874a919fd5f984581edad55574.ContainsKey(new TitleId(cad8c01cdf4965a5f4a2feed04bb30913.c1df95097ffa57d753c5fe1353cf65e86(index.FullUpdate))))
                  {
label_58:
                    switch (1)
                    {
                      case 0:
                        goto label_58;
                      default:
                        using (List<c2e2f19e8cde9983e4129b4a047c9f5c6.cc8cce23c9cabc8c74f6621804b209224>.Enumerator enumerator3 = ca377ebace9a9e1ffac7b0c5a9158e838.ccbd3e6874a919fd5f984581edad55574[index.FullUpdate].GetEnumerator())
                        {
                          while (enumerator3.MoveNext())
                          {
                            c2e2f19e8cde9983e4129b4a047c9f5c6.cc8cce23c9cabc8c74f6621804b209224 current2 = enumerator3.Current;
                            if (current2.c80d617f05b7f95017df4cba82652d0dd != null)
                            {
label_62:
                              switch (5)
                              {
                                case 0:
                                  goto label_62;
                                default:
                                  if (current2.c330284c85ae4e7d7fee01a9e716b656b != null)
                                  {
label_64:
                                    switch (2)
                                    {
                                      case 0:
                                        goto label_64;
                                      default:
                                        ce64fe4baff0b285aaecd02e2cae2ea2c ce64fe4baff0b285aaecd02e2cae2ea2c1 = new ce64fe4baff0b285aaecd02e2cae2ea2c(c407606821fe6034b43e547a4ca232678, current2.c27f5df1dc5d80dd0c87cd29e7cef11b8, cd47a8862dc253a9ef4c1baa0b8cbdb0a, (byte[]) null, current2.c64ccfce653a8bd2c7c7ffb6b8d91766f, current2.c907ca8ffa30661318a7e29e77519ea57, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(897), (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7704));
                                        int num = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7708);
                                        ce64fe4baff0b285aaecd02e2cae2ea2c1.CfwOnly = num != 0;
                                        ce64fe4baff0b285aaecd02e2cae2ea2c ce64fe4baff0b285aaecd02e2cae2ea2c2 = ce64fe4baff0b285aaecd02e2cae2ea2c1;
                                        byte[] numArray = c1d5d0d4f9464e1d296ba85cf189ecad6.cd95d6179fbfbb8343ee6b7e86eddb263(cad8c01cdf4965a5f4a2feed04bb30913.c1df95097ffa57d753c5fe1353cf65e86(current2.c27f5df1dc5d80dd0c87cd29e7cef11b8), current2.c330284c85ae4e7d7fee01a9e716b656b, int.Parse(current2.c907ca8ffa30661318a7e29e77519ea57));
                                        ce64fe4baff0b285aaecd02e2cae2ea2c2.TicketArray = numArray;
                                        ce64fe4baff0b285aaecd02e2cae2ea2c2.c9536899c8db7d9fc10b867798a27bf8c = c1d5d0d4f9464e1d296ba85cf189ecad6.cae2e9bf4acb15138d7a2e5dcb60b24d7(current2.c80d617f05b7f95017df4cba82652d0dd);
                                        ce64fe4baff0b285aaecd02e2cae2ea2c2.Ticket = c1d5d0d4f9464e1d296ba85cf189ecad6.cb5009c1058eaad54842d9bead8e530a2(ce64fe4baff0b285aaecd02e2cae2ea2c2.TicketArray, (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7712));
                                        ce64fe4baff0b285aaecd02e2cae2ea2c2.Ticket.c80d617f05b7f95017df4cba82652d0dd = c1d5d0d4f9464e1d296ba85cf189ecad6.cae2e9bf4acb15138d7a2e5dcb60b24d7(current2.c80d617f05b7f95017df4cba82652d0dd);
                                        c1c0fd38914d2630ff1a82119e1950d3c.Add(ce64fe4baff0b285aaecd02e2cae2ea2c2);
                                        continue;
                                    }
                                  }
                                  else
                                    continue;
                              }
                            }
                          }
label_67:
                          switch (6)
                          {
                            case 0:
                              goto label_67;
                          }
                        }
                    }
                  }
                  cce1cf1e0b6971ed6f7ef86a83b0959b6 cce1cf1e0b6971ed6f7ef86a83b0959b6_1 = new cce1cf1e0b6971ed6f7ef86a83b0959b6(c407606821fe6034b43e547a4ca232678, index, dbRow.Region, (byte[]) null, dbRow.Size, c1c0fd38914d2630ff1a82119e1950d3c, dbRow.EshopId, dbRow.ProductCode, dbRow.IconUrl, c833fbfa18d441f3acb05d803efdf1eb8.c702a9e4555297107d7c7901aa91e5540(6999), dbRow.Platform, (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7716));
                  int num1 = cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7720);
                  cce1cf1e0b6971ed6f7ef86a83b0959b6_1.CfwOnly = num1 != 0;
                  cce1cf1e0b6971ed6f7ef86a83b0959b6 cce1cf1e0b6971ed6f7ef86a83b0959b6_2 = cce1cf1e0b6971ed6f7ef86a83b0959b6_1;
                  byte[] numArray1 = c1d5d0d4f9464e1d296ba85cf189ecad6.cd95d6179fbfbb8343ee6b7e86eddb263(index.IdRaw, current1.encTitleKey, cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7724));
                  cce1cf1e0b6971ed6f7ef86a83b0959b6_2.TicketArray = numArray1;
                  cce1cf1e0b6971ed6f7ef86a83b0959b6_2.c9536899c8db7d9fc10b867798a27bf8c = c1d5d0d4f9464e1d296ba85cf189ecad6.cae2e9bf4acb15138d7a2e5dcb60b24d7(current1.titleKey);
                  cce1cf1e0b6971ed6f7ef86a83b0959b6_2.Ticket = c1d5d0d4f9464e1d296ba85cf189ecad6.cb5009c1058eaad54842d9bead8e530a2(cce1cf1e0b6971ed6f7ef86a83b0959b6_2.TicketArray, (caff792dac5a5e2f17b0e81e59bba386d) cb85779efa5f9c78fa841b92dceca9094.c4f3ad310245f8f6e7d32122c50c48ab1(7728));
                  cce1cf1e0b6971ed6f7ef86a83b0959b6_2.Ticket.c80d617f05b7f95017df4cba82652d0dd = c1d5d0d4f9464e1d296ba85cf189ecad6.cae2e9bf4acb15138d7a2e5dcb60b24d7(current1.titleKey);
                  ca377ebace9a9e1ffac7b0c5a9158e838.ca32b8c3bef10c492a2adefe52dea03d4.Add(index, cce1cf1e0b6971ed6f7ef86a83b0959b6_2);
                  continue;
              }
            }
          }
label_71:
          switch (1)
          {
            case 0:
              goto label_71;
          }
        }
        finally
        {
          if (enumerator2 != null)
          {
label_74:
            switch (5)
            {
              case 0:
                goto label_74;
              default:
                enumerator2.Dispose();
                break;
            }
          }
        }
      }
    }

    internal class cf023ebea540659240f7ec1cb4b26f218
    {
      public string encTitleKey { get; set; }

      public string name { get; set; }

      public string region { get; set; }

      public string serial { get; set; }

      public object size { get; set; }

      public string titleID { get; set; }

      public string titleKey { get; set; }
    }

    internal class c1ab5887247831e89bcc558f19ea04e29
    {
      public string name { get; set; }

      public string region { get; set; }

      public string ticket { get; set; }

      public string titleID { get; set; }

      public string titleKey { get; set; }
    }
  }
}
