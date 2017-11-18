using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace A
{
	// Token: 0x020000AC RID: 172
	[ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
	public class ceb03484676e95b814d4e588e434e560b : ToolStripControlHost
	{
		// Token: 0x060005BB RID: 1467 RVA: 0x0002684C File Offset: 0x00024A4C
		public ceb03484676e95b814d4e588e434e560b() : base(new cd5c09c7b57f3aa6b224c611a72ca3b10())
		{
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x00026864 File Offset: 0x00024A64
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[RefreshProperties(RefreshProperties.All)]
		public cd5c09c7b57f3aa6b224c611a72ca3b10 cb1983fd4dc1cc77ff205ecb1cecae17f
		{
			get
			{
				return cffca5f589bf749535c1a95087bcafa44.c0b398ab350e72b0d64d512bae8520b85(base.Control);
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00026880 File Offset: 0x00024A80
		public override Size GetPreferredSize(Size constrainingSize)
		{
			return this.cb1983fd4dc1cc77ff205ecb1cecae17f.GetPreferredSize(constrainingSize);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000268A0 File Offset: 0x00024AA0
		protected override void OnSubscribeControlEvents(Control control)
		{
			base.OnSubscribeControlEvents(control);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000268B4 File Offset: 0x00024AB4
		protected override void OnUnsubscribeControlEvents(Control control)
		{
			base.OnUnsubscribeControlEvents(control);
		}
	}
}
