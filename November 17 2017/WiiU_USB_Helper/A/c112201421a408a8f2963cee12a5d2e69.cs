using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace A
{
	// Token: 0x02000030 RID: 48
	internal class c112201421a408a8f2963cee12a5d2e69
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x0000A720 File Offset: 0x00008920
		static c112201421a408a8f2963cee12a5d2e69()
		{
			if (c112201421a408a8f2963cee12a5d2e69.c271a832e629a79991d9eda7a270cb125 == null)
			{
				for (;;)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c112201421a408a8f2963cee12a5d2e69..cctor()).MethodHandle;
				}
				string text = "V2lpVV9VU0JfSGVscGVyKg==";
				byte[] array = Convert.FromBase64String(text);
				text = Encoding.UTF8.GetString(array, 0, (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(array));
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
				c112201421a408a8f2963cee12a5d2e69.c271a832e629a79991d9eda7a270cb125 = c89d5f69592ed6ff3f4bcbdf0f7037053.c401a548304a40239ab7b93ba833c083c(97L, manifestResourceStream);
				c112201421a408a8f2963cee12a5d2e69.c38c4c8069b226b1e8dc3975f03305f77 = new Dictionary<int, int>();
				BinaryReader binaryReader = new BinaryReader(new MemoryStream(c112201421a408a8f2963cee12a5d2e69.c271a832e629a79991d9eda7a270cb125, false));
				try
				{
					int num = binaryReader.ReadInt32();
					for (int i = 0; i < num; i++)
					{
						int key = binaryReader.ReadInt32();
						int value = binaryReader.ReadInt32();
						c112201421a408a8f2963cee12a5d2e69.c38c4c8069b226b1e8dc3975f03305f77[key] = value;
					}
					for (;;)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				finally
				{
					if (binaryReader != null)
					{
						for (;;)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						((IDisposable)binaryReader).Dispose();
					}
				}
			}
			if (Type.GetTypeFromHandle(c4a1aacd249a6434edeb4d7ec318dadc3.cde4d1aeffe0e705b07e1b3d74e931465()) != null)
			{
				for (;;)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				c112201421a408a8f2963cee12a5d2e69.c5b2cbb035f512aa824f5593dd0096224 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000A864 File Offset: 0x00008A64
		internal static void c10af80cdad4c9dbe717681a9cd86af7a(int caf80c5c2bc19055f4eb1069181edd5e4, int c6b0ef7a04772650ed28a3de279ed2ed9, int cabf1aeb6e91698f7db067652c7916847)
		{
			Type typeFromHandle;
			MethodBase methodBase;
			try
			{
				typeFromHandle = Type.GetTypeFromHandle(c112201421a408a8f2963cee12a5d2e69.c5b2cbb035f512aa824f5593dd0096224.ResolveTypeHandle(caf80c5c2bc19055f4eb1069181edd5e4));
				object methodFromHandle = MethodBase.GetMethodFromHandle(c112201421a408a8f2963cee12a5d2e69.c5b2cbb035f512aa824f5593dd0096224.ResolveMethodHandle(c6b0ef7a04772650ed28a3de279ed2ed9), c112201421a408a8f2963cee12a5d2e69.c5b2cbb035f512aa824f5593dd0096224.ResolveTypeHandle(cabf1aeb6e91698f7db067652c7916847));
				methodBase = c19240ce50a3f99cf68eac460a5f219eb.cd24593c859565ebb8c9faabbc5c75bef(methodFromHandle);
			}
			catch (Exception)
			{
				throw;
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int i = 0; i < (int)ca6d7950a54c7ffb24dd0caad95a2614f.cfeb04651f165d0166e7c10ab1acf8b28(fields); i++)
			{
				FieldInfo fieldInfo = fields[i];
				try
				{
					DynamicMethod dynamicMethod = c1bb66ba0941923c66aa96bbf66e7ba95.cab55a050df275722227783d6686266c9;
					MethodBody methodBody = methodBase.GetMethodBody();
					Type[] parameterTypes = c112201421a408a8f2963cee12a5d2e69.c66499b087455255e2b006f8a7688f7b1(methodBase);
					string name = c009279a45243b14127222aa793e3eb2e.c8d9bd1b5f903cbc3ebfaf48b8b440c7a(methodBase.DeclaringType.FullName, ".", methodBase.Name, "_Encrypted$");
					Type returnType;
					if (c0d90fcf706c7ee22fef7d88368977990.c0b398ab350e72b0d64d512bae8520b85(methodBase) == null)
					{
						for (;;)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle runtimeMethodHandle = methodof(c112201421a408a8f2963cee12a5d2e69.c10af80cdad4c9dbe717681a9cd86af7a(int, int, int)).MethodHandle;
						}
						returnType = c2616c42177f749f99e07d405c040207f.cd24593c859565ebb8c9faabbc5c75bef(methodBase).ReturnType;
					}
					else
					{
						returnType = null;
					}
					dynamicMethod = new DynamicMethod(name, returnType, parameterTypes, methodBase.DeclaringType, true);
					int num;
					c112201421a408a8f2963cee12a5d2e69.c38c4c8069b226b1e8dc3975f03305f77.TryGetValue(caf80c5c2bc19055f4eb1069181edd5e4, out num);
					DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
					c112201421a408a8f2963cee12a5d2e69.c9caeb49525e24fdeaf8f5bc58177b94e(methodBody, dynamicILInfo);
					c112201421a408a8f2963cee12a5d2e69.c792380fd21eca6e08b9631600cc2d331(ref num, methodBase, dynamicILInfo);
					c112201421a408a8f2963cee12a5d2e69.c8619f80da50369e47fcfd41a1f31ff9b(ref num, dynamicILInfo);
					Delegate value = dynamicMethod.CreateDelegate(typeFromHandle);
					fieldInfo.SetValue(null, value);
				}
				catch (Exception)
				{
				}
			}
			for (;;)
			{
				switch (2)
				{
				case 0:
					continue;
				}
				break;
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000A9F4 File Offset: 0x00008BF4
		private static void c792380fd21eca6e08b9631600cc2d331(ref int ca0c61e7592f10963057a6d5e207fa679, MethodBase c349afe24756c2022fc84606a1e6d3419, DynamicILInfo c3c57c9acc0a08dbaa5fcc9490f2a3eac)
		{
			int maxStackSize = BitConverter.ToInt32(c112201421a408a8f2963cee12a5d2e69.c271a832e629a79991d9eda7a270cb125, ca0c61e7592f10963057a6d5e207fa679);
			ca0c61e7592f10963057a6d5e207fa679 += 4;
			int num = BitConverter.ToInt32(c112201421a408a8f2963cee12a5d2e69.c271a832e629a79991d9eda7a270cb125, ca0c61e7592f10963057a6d5e207fa679);
			ca0c61e7592f10963057a6d5e207fa679 += 4;
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(num);
			Buffer.BlockCopy(c112201421a408a8f2963cee12a5d2e69.c271a832e629a79991d9eda7a270cb125, ca0c61e7592f10963057a6d5e207fa679, array, 0, num);
			c112201421a408a8f2963cee12a5d2e69.ccc46268e89df4ba9fc0a02a649177e87 ccc46268e89df4ba9fc0a02a649177e = new c112201421a408a8f2963cee12a5d2e69.ccc46268e89df4ba9fc0a02a649177e87(c349afe24756c2022fc84606a1e6d3419, array, c3c57c9acc0a08dbaa5fcc9490f2a3eac);
			ccc46268e89df4ba9fc0a02a649177e.ce88c13cebaf30d6cda3a6382e8991b8d();
			c3c57c9acc0a08dbaa5fcc9490f2a3eac.SetCode(array, maxStackSize);
			ca0c61e7592f10963057a6d5e207fa679 += num;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000AA60 File Offset: 0x00008C60
		private static void c9caeb49525e24fdeaf8f5bc58177b94e(MethodBody cda702ac0b563445a1ac0a319f3ad44f9, DynamicILInfo c3c57c9acc0a08dbaa5fcc9490f2a3eac)
		{
			SignatureHelper localVarSigHelper = SignatureHelper.GetLocalVarSigHelper();
			IEnumerator<LocalVariableInfo> enumerator = cda702ac0b563445a1ac0a319f3ad44f9.LocalVariables.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					LocalVariableInfo localVariableInfo = enumerator.Current;
					localVarSigHelper.AddArgument(localVariableInfo.LocalType, localVariableInfo.IsPinned);
				}
				for (;;)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c112201421a408a8f2963cee12a5d2e69.c9caeb49525e24fdeaf8f5bc58177b94e(MethodBody, DynamicILInfo)).MethodHandle;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					for (;;)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					enumerator.Dispose();
				}
			}
			c3c57c9acc0a08dbaa5fcc9490f2a3eac.SetLocalSignature(localVarSigHelper.GetSignature());
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000AAF8 File Offset: 0x00008CF8
		private unsafe static void c8619f80da50369e47fcfd41a1f31ff9b(ref int ca0c61e7592f10963057a6d5e207fa679, DynamicILInfo c3c57c9acc0a08dbaa5fcc9490f2a3eac)
		{
			int num = BitConverter.ToInt32(c112201421a408a8f2963cee12a5d2e69.c271a832e629a79991d9eda7a270cb125, ca0c61e7592f10963057a6d5e207fa679);
			ca0c61e7592f10963057a6d5e207fa679 += 4;
			if (num == 0)
			{
				for (;;)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c112201421a408a8f2963cee12a5d2e69.c8619f80da50369e47fcfd41a1f31ff9b(int*, DynamicILInfo)).MethodHandle;
				}
				return;
			}
			byte[] array = c4cbbd90ed4559089f2970be8fc52599d.cad714a49573fd585a8ab14c80a23536b(num);
			Buffer.BlockCopy(c112201421a408a8f2963cee12a5d2e69.c271a832e629a79991d9eda7a270cb125, ca0c61e7592f10963057a6d5e207fa679, array, 0, num);
			int num2 = 4;
			int num3 = (num - 4) / 24;
			for (int i = 0; i < num3; i++)
			{
				ExceptionHandlingClauseOptions exceptionHandlingClauseOptions = (ExceptionHandlingClauseOptions)BitConverter.ToInt32(array, num2);
				num2 += 20;
				switch (exceptionHandlingClauseOptions)
				{
				case ExceptionHandlingClauseOptions.Clause:
				{
					RuntimeTypeHandle type = c112201421a408a8f2963cee12a5d2e69.c5b2cbb035f512aa824f5593dd0096224.ResolveTypeHandle(BitConverter.ToInt32(array, num2));
					int tokenFor = c3c57c9acc0a08dbaa5fcc9490f2a3eac.GetTokenFor(type);
					c112201421a408a8f2963cee12a5d2e69.c080978af586a672599ee810498652c16(tokenFor, num2, array);
					break;
				}
				case ExceptionHandlingClauseOptions.Fault:
					throw new NotSupportedException("dynamic method does not support fault clause");
				}
				num2 += 4;
			}
			for (;;)
			{
				switch (2)
				{
				case 0:
					continue;
				}
				break;
			}
			c3c57c9acc0a08dbaa5fcc9490f2a3eac.SetExceptions(array);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000ABE8 File Offset: 0x00008DE8
		public static void c080978af586a672599ee810498652c16(int c9d67569497391dd55a54875dcfb8fb1c, int c48e42be55fb577e9d92a658479c49ba7, byte[] c4ee778b2524fd854bcf7eb55f3cbf730)
		{
			c4ee778b2524fd854bcf7eb55f3cbf730[c48e42be55fb577e9d92a658479c49ba7++] = (byte)c9d67569497391dd55a54875dcfb8fb1c;
			c4ee778b2524fd854bcf7eb55f3cbf730[c48e42be55fb577e9d92a658479c49ba7++] = (byte)(c9d67569497391dd55a54875dcfb8fb1c >> 8);
			c4ee778b2524fd854bcf7eb55f3cbf730[c48e42be55fb577e9d92a658479c49ba7++] = (byte)(c9d67569497391dd55a54875dcfb8fb1c >> 16);
			c4ee778b2524fd854bcf7eb55f3cbf730[c48e42be55fb577e9d92a658479c49ba7++] = (byte)(c9d67569497391dd55a54875dcfb8fb1c >> 24);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000AC30 File Offset: 0x00008E30
		private static Type[] c66499b087455255e2b006f8a7688f7b1(MethodBase ce520ef6a814d984965abb9d7575f2cff)
		{
			ParameterInfo[] parameters = ce520ef6a814d984965abb9d7575f2cff.GetParameters();
			int num = (int)c19228ab060746b3868ef052f7a8e84a7.cfeb04651f165d0166e7c10ab1acf8b28(parameters);
			if (!ce520ef6a814d984965abb9d7575f2cff.IsStatic)
			{
				for (;;)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c112201421a408a8f2963cee12a5d2e69.c66499b087455255e2b006f8a7688f7b1(MethodBase)).MethodHandle;
				}
				num++;
			}
			Type[] array = c048e26d187cafd51fa9f2a3e3b31e673.cad714a49573fd585a8ab14c80a23536b(num);
			int num2 = 0;
			if (!ce520ef6a814d984965abb9d7575f2cff.IsStatic)
			{
				for (;;)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				if (ce520ef6a814d984965abb9d7575f2cff.DeclaringType.IsValueType)
				{
					for (;;)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					array[0] = ce520ef6a814d984965abb9d7575f2cff.DeclaringType.MakeByRefType();
				}
				else
				{
					array[0] = ce520ef6a814d984965abb9d7575f2cff.DeclaringType;
				}
				num2++;
			}
			int i = 0;
			while (i < (int)c19228ab060746b3868ef052f7a8e84a7.cfeb04651f165d0166e7c10ab1acf8b28(parameters))
			{
				array[num2] = parameters[i].ParameterType;
				i++;
				num2++;
			}
			for (;;)
			{
				switch (7)
				{
				case 0:
					continue;
				}
				break;
			}
			return array;
		}

		// Token: 0x040000A1 RID: 161
		internal static readonly byte[] c271a832e629a79991d9eda7a270cb125;

		// Token: 0x040000A2 RID: 162
		internal static readonly Dictionary<int, int> c38c4c8069b226b1e8dc3975f03305f77;

		// Token: 0x040000A3 RID: 163
		private static readonly ModuleHandle c5b2cbb035f512aa824f5593dd0096224;

		// Token: 0x02000031 RID: 49
		public sealed class ccc46268e89df4ba9fc0a02a649177e87
		{
			// Token: 0x06000101 RID: 257 RVA: 0x0000AD04 File Offset: 0x00008F04
			static ccc46268e89df4ba9fc0a02a649177e87()
			{
				FieldInfo[] fields = Type.GetTypeFromHandle(c2c27adf1a236ae5f3d15182fc9fcab67.cde4d1aeffe0e705b07e1b3d74e931465()).GetFields(BindingFlags.Static | BindingFlags.Public);
				for (int i = 0; i < (int)ca6d7950a54c7ffb24dd0caad95a2614f.cfeb04651f165d0166e7c10ab1acf8b28(fields); i++)
				{
					FieldInfo fieldInfo = fields[i];
					OpCode opCode = cb8aa2d508dfc18a08cb8f469873bac67.cb93115e3b63933899699d0ee8696f152(fieldInfo.GetValue(c297b6130075fc34fa606ad0c12ed51a8.cab55a050df275722227783d6686266c9));
					ushort num = (ushort)opCode.Value;
					if (num < 256)
					{
						for (;;)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle runtimeMethodHandle = methodof(c112201421a408a8f2963cee12a5d2e69.ccc46268e89df4ba9fc0a02a649177e87..cctor()).MethodHandle;
						}
						c112201421a408a8f2963cee12a5d2e69.ccc46268e89df4ba9fc0a02a649177e87.c1156ad0ad53d94fd9a5423582312bca4[(int)num] = opCode;
					}
					else if ((num & 65280) == 65024)
					{
						for (;;)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						c112201421a408a8f2963cee12a5d2e69.ccc46268e89df4ba9fc0a02a649177e87.c56a6afd10e840b4cf3f66d8406a05770[(int)(num & 255)] = opCode;
					}
				}
				for (;;)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
			}

			// Token: 0x06000102 RID: 258 RVA: 0x0000ADF8 File Offset: 0x00008FF8
			public ccc46268e89df4ba9fc0a02a649177e87(MethodBase c349afe24756c2022fc84606a1e6d3419, byte[] c7630e96bb46f8bf251c0b9f522479477, DynamicILInfo c3c57c9acc0a08dbaa5fcc9490f2a3eac)
			{
				this.c3c57c9acc0a08dbaa5fcc9490f2a3eac = c3c57c9acc0a08dbaa5fcc9490f2a3eac;
				this.c981d20a0451c7fc09a2b83097db9f41e = c7630e96bb46f8bf251c0b9f522479477;
				this.c83709c495da9d0add5900c85577f9a11 = 0;
				this.c47c0cf3d9e28f005ead72a27e19518f7 = c349afe24756c2022fc84606a1e6d3419.Module;
				Type[] array;
				if (c0d90fcf706c7ee22fef7d88368977990.c0b398ab350e72b0d64d512bae8520b85(c349afe24756c2022fc84606a1e6d3419) == null)
				{
					for (;;)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(c112201421a408a8f2963cee12a5d2e69.ccc46268e89df4ba9fc0a02a649177e87..ctor(MethodBase, byte[], DynamicILInfo)).MethodHandle;
					}
					array = c349afe24756c2022fc84606a1e6d3419.GetGenericArguments();
				}
				else
				{
					array = ca74cd7cb1a0b3bdf9559dfe9a59de6fb.cab55a050df275722227783d6686266c9;
				}
				this.c53f61e19e49c4a703421d74a190079b9 = array;
				Type[] array2;
				if (c349afe24756c2022fc84606a1e6d3419.DeclaringType != null)
				{
					for (;;)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					array2 = c349afe24756c2022fc84606a1e6d3419.DeclaringType.GetGenericArguments();
				}
				else
				{
					array2 = ca74cd7cb1a0b3bdf9559dfe9a59de6fb.cab55a050df275722227783d6686266c9;
				}
				this.c8d5115e0a351ed1eaf0204f95d0fd152 = array2;
			}

			// Token: 0x06000103 RID: 259 RVA: 0x0000AE90 File Offset: 0x00009090
			internal void ce88c13cebaf30d6cda3a6382e8991b8d()
			{
				while (this.c83709c495da9d0add5900c85577f9a11 < (int)c7e3f6af67bf34eefc1a4cca086e17069.cfeb04651f165d0166e7c10ab1acf8b28(this.c981d20a0451c7fc09a2b83097db9f41e))
				{
					this.c70dd6ee36c6a01f437a3f43d04b76056();
				}
				for (;;)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle runtimeMethodHandle = methodof(c112201421a408a8f2963cee12a5d2e69.ccc46268e89df4ba9fc0a02a649177e87.ce88c13cebaf30d6cda3a6382e8991b8d()).MethodHandle;
				}
			}

			// Token: 0x06000104 RID: 260 RVA: 0x0000AED4 File Offset: 0x000090D4
			private object c70dd6ee36c6a01f437a3f43d04b76056()
			{
				int num = this.c83709c495da9d0add5900c85577f9a11;
				OpCode opCode = OpCodes.Nop;
				byte b = this.c13e97c0b34844947b7d20cb9bfa249b1();
				if (b != 254)
				{
					for (;;)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(c112201421a408a8f2963cee12a5d2e69.ccc46268e89df4ba9fc0a02a649177e87.c70dd6ee36c6a01f437a3f43d04b76056()).MethodHandle;
					}
					opCode = c112201421a408a8f2963cee12a5d2e69.ccc46268e89df4ba9fc0a02a649177e87.c1156ad0ad53d94fd9a5423582312bca4[(int)b];
				}
				else
				{
					b = this.c13e97c0b34844947b7d20cb9bfa249b1();
					opCode = c112201421a408a8f2963cee12a5d2e69.ccc46268e89df4ba9fc0a02a649177e87.c56a6afd10e840b4cf3f66d8406a05770[(int)b];
				}
				switch (opCode.OperandType)
				{
				case OperandType.InlineBrTarget:
					this.c9ee86184616a3d6a28e0889dd42b7bd5(4);
					return null;
				case OperandType.InlineField:
				{
					int num2 = this.c956c7ccad84dc4f1929d574f84da192e();
					FieldInfo fieldInfo = this.c47c0cf3d9e28f005ead72a27e19518f7.ResolveField(num2, this.c8d5115e0a351ed1eaf0204f95d0fd152, this.c53f61e19e49c4a703421d74a190079b9);
					this.c080978af586a672599ee810498652c16(this.c3c57c9acc0a08dbaa5fcc9490f2a3eac.GetTokenFor(fieldInfo.FieldHandle), num + opCode.Size);
					return null;
				}
				case OperandType.InlineI:
					this.c9ee86184616a3d6a28e0889dd42b7bd5(4);
					return null;
				case OperandType.InlineI8:
					this.c9ee86184616a3d6a28e0889dd42b7bd5(8);
					return null;
				case OperandType.InlineMethod:
				{
					int num2 = this.c956c7ccad84dc4f1929d574f84da192e();
					MethodBase methodBase = this.c47c0cf3d9e28f005ead72a27e19518f7.ResolveMethod(num2, this.c8d5115e0a351ed1eaf0204f95d0fd152, this.c53f61e19e49c4a703421d74a190079b9);
					this.c080978af586a672599ee810498652c16(this.c3c57c9acc0a08dbaa5fcc9490f2a3eac.GetTokenFor(methodBase.MethodHandle, methodBase.DeclaringType.TypeHandle), num + opCode.Size);
					return null;
				}
				case OperandType.InlineNone:
					return null;
				case OperandType.InlineR:
					this.c9ee86184616a3d6a28e0889dd42b7bd5(8);
					return null;
				case OperandType.InlineSig:
				{
					int num2 = this.c956c7ccad84dc4f1929d574f84da192e();
					this.c080978af586a672599ee810498652c16(this.c3c57c9acc0a08dbaa5fcc9490f2a3eac.GetTokenFor(this.c47c0cf3d9e28f005ead72a27e19518f7.ResolveSignature(num2)), num + opCode.Size);
					return null;
				}
				case OperandType.InlineString:
				{
					int num2 = this.c956c7ccad84dc4f1929d574f84da192e();
					this.c080978af586a672599ee810498652c16(this.c3c57c9acc0a08dbaa5fcc9490f2a3eac.GetTokenFor(this.c47c0cf3d9e28f005ead72a27e19518f7.ResolveString(num2)), num + opCode.Size);
					return null;
				}
				case OperandType.InlineSwitch:
				{
					int num3 = this.c956c7ccad84dc4f1929d574f84da192e();
					this.c9ee86184616a3d6a28e0889dd42b7bd5(num3 * 4);
					return null;
				}
				case OperandType.InlineTok:
				{
					int num2 = this.c956c7ccad84dc4f1929d574f84da192e();
					MemberInfo memberInfo = this.c47c0cf3d9e28f005ead72a27e19518f7.ResolveMember(num2, this.c8d5115e0a351ed1eaf0204f95d0fd152, this.c53f61e19e49c4a703421d74a190079b9);
					if (memberInfo.MemberType != MemberTypes.TypeInfo)
					{
						for (;;)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						if (memberInfo.MemberType != MemberTypes.NestedType)
						{
							if (memberInfo.MemberType != MemberTypes.Method)
							{
								for (;;)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
								if (memberInfo.MemberType == MemberTypes.Constructor)
								{
									for (;;)
									{
										switch (3)
										{
										case 0:
											continue;
										}
										break;
									}
								}
								else
								{
									if (memberInfo.MemberType == MemberTypes.Field)
									{
										for (;;)
										{
											switch (7)
											{
											case 0:
												continue;
											}
											break;
										}
										FieldInfo fieldInfo2 = c898b645c13a7704cf22316769e713b40.c0b398ab350e72b0d64d512bae8520b85(memberInfo);
										num2 = this.c3c57c9acc0a08dbaa5fcc9490f2a3eac.GetTokenFor(fieldInfo2.FieldHandle);
										goto IL_393;
									}
									goto IL_393;
								}
							}
							MethodBase methodBase2 = c797a2fddc24f0a13db0ba4fa652528ec.c0b398ab350e72b0d64d512bae8520b85(memberInfo);
							num2 = this.c3c57c9acc0a08dbaa5fcc9490f2a3eac.GetTokenFor(methodBase2.MethodHandle, methodBase2.DeclaringType.TypeHandle);
							goto IL_393;
						}
						for (;;)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					Type type = c29fbdc123047b0296e5cc333563f7fe5.c0b398ab350e72b0d64d512bae8520b85(memberInfo);
					num2 = this.c3c57c9acc0a08dbaa5fcc9490f2a3eac.GetTokenFor(type.TypeHandle);
					IL_393:
					this.c080978af586a672599ee810498652c16(num2, num + opCode.Size);
					return null;
				}
				case OperandType.InlineType:
				{
					int num2 = this.c956c7ccad84dc4f1929d574f84da192e();
					Type type2 = this.c47c0cf3d9e28f005ead72a27e19518f7.ResolveType(num2, this.c8d5115e0a351ed1eaf0204f95d0fd152, this.c53f61e19e49c4a703421d74a190079b9);
					this.c080978af586a672599ee810498652c16(this.c3c57c9acc0a08dbaa5fcc9490f2a3eac.GetTokenFor(type2.TypeHandle), num + opCode.Size);
					return null;
				}
				case OperandType.InlineVar:
					this.c9ee86184616a3d6a28e0889dd42b7bd5(2);
					return null;
				case OperandType.ShortInlineBrTarget:
					this.c9ee86184616a3d6a28e0889dd42b7bd5(1);
					return null;
				case OperandType.ShortInlineI:
					this.c9ee86184616a3d6a28e0889dd42b7bd5(1);
					return null;
				case OperandType.ShortInlineR:
					this.c9ee86184616a3d6a28e0889dd42b7bd5(4);
					return null;
				case OperandType.ShortInlineVar:
					this.c9ee86184616a3d6a28e0889dd42b7bd5(1);
					return null;
				}
				throw new BadImageFormatException(c9746d6a2eba77fcf6de7825aa9f6a7e4.c8d9bd1b5f903cbc3ebfaf48b8b440c7a("unexpected OperandType ", opCode.OperandType));
			}

			// Token: 0x06000105 RID: 261 RVA: 0x0000B2C0 File Offset: 0x000094C0
			private void c9ee86184616a3d6a28e0889dd42b7bd5(int cc076fd568f4bb05b6e433b9eb4ab0a25)
			{
				this.c83709c495da9d0add5900c85577f9a11 += cc076fd568f4bb05b6e433b9eb4ab0a25;
			}

			// Token: 0x06000106 RID: 262 RVA: 0x0000B2DC File Offset: 0x000094DC
			private byte c13e97c0b34844947b7d20cb9bfa249b1()
			{
				return this.c981d20a0451c7fc09a2b83097db9f41e[this.c83709c495da9d0add5900c85577f9a11++];
			}

			// Token: 0x06000107 RID: 263 RVA: 0x0000B304 File Offset: 0x00009504
			private int c956c7ccad84dc4f1929d574f84da192e()
			{
				int startIndex = this.c83709c495da9d0add5900c85577f9a11;
				this.c83709c495da9d0add5900c85577f9a11 += 4;
				return BitConverter.ToInt32(this.c981d20a0451c7fc09a2b83097db9f41e, startIndex);
			}

			// Token: 0x06000108 RID: 264 RVA: 0x0000B334 File Offset: 0x00009534
			private void c080978af586a672599ee810498652c16(int c9d67569497391dd55a54875dcfb8fb1c, int c48e42be55fb577e9d92a658479c49ba7)
			{
				this.c981d20a0451c7fc09a2b83097db9f41e[c48e42be55fb577e9d92a658479c49ba7++] = (byte)c9d67569497391dd55a54875dcfb8fb1c;
				this.c981d20a0451c7fc09a2b83097db9f41e[c48e42be55fb577e9d92a658479c49ba7++] = (byte)(c9d67569497391dd55a54875dcfb8fb1c >> 8);
				this.c981d20a0451c7fc09a2b83097db9f41e[c48e42be55fb577e9d92a658479c49ba7++] = (byte)(c9d67569497391dd55a54875dcfb8fb1c >> 16);
				this.c981d20a0451c7fc09a2b83097db9f41e[c48e42be55fb577e9d92a658479c49ba7++] = (byte)(c9d67569497391dd55a54875dcfb8fb1c >> 24);
			}

			// Token: 0x040000A4 RID: 164
			private static OpCode[] c1156ad0ad53d94fd9a5423582312bca4 = cc1dc2bd33d10dede6b214da71b7628f0.cad714a49573fd585a8ab14c80a23536b(256);

			// Token: 0x040000A5 RID: 165
			private static OpCode[] c56a6afd10e840b4cf3f66d8406a05770 = cc1dc2bd33d10dede6b214da71b7628f0.cad714a49573fd585a8ab14c80a23536b(256);

			// Token: 0x040000A6 RID: 166
			private int c83709c495da9d0add5900c85577f9a11;

			// Token: 0x040000A7 RID: 167
			private byte[] c981d20a0451c7fc09a2b83097db9f41e;

			// Token: 0x040000A8 RID: 168
			private DynamicILInfo c3c57c9acc0a08dbaa5fcc9490f2a3eac;

			// Token: 0x040000A9 RID: 169
			private Module c47c0cf3d9e28f005ead72a27e19518f7;

			// Token: 0x040000AA RID: 170
			private Type[] c53f61e19e49c4a703421d74a190079b9;

			// Token: 0x040000AB RID: 171
			private Type[] c8d5115e0a351ed1eaf0204f95d0fd152;
		}
	}
}
