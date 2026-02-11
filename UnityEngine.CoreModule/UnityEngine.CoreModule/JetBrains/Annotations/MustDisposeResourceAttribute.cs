using System;

namespace JetBrains.Annotations
{
	// Token: 0x020002B2 RID: 690
	public sealed class MustDisposeResourceAttribute : Attribute
	{
		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x00011763 File Offset: 0x0000F963
		public bool Value
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
