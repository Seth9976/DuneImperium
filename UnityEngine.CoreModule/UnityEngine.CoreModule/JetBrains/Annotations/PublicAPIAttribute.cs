using System;

namespace JetBrains.Annotations
{
	// Token: 0x020002B0 RID: 688
	public sealed class PublicAPIAttribute : Attribute
	{
		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06002CCA RID: 11466 RVA: 0x00011756 File Offset: 0x0000F956
		public string Comment
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
