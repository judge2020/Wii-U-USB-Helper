using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Updater.Properties
{
	// Token: 0x0200000A RID: 10
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000042C9 File Offset: 0x000024C9
		internal Resources()
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000042D1 File Offset: 0x000024D1
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("Updater.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000042FD File Offset: 0x000024FD
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00004304 File Offset: 0x00002504
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0000430C File Offset: 0x0000250C
		internal static Bitmap bg
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("bg", Resources.resourceCulture);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00004327 File Offset: 0x00002527
		internal static Bitmap logo
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("logo", Resources.resourceCulture);
			}
		}

		// Token: 0x04000032 RID: 50
		private static ResourceManager resourceMan;

		// Token: 0x04000033 RID: 51
		private static CultureInfo resourceCulture;
	}
}
