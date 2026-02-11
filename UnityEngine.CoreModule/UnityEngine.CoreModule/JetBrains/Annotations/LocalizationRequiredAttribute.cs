using System;

namespace JetBrains.Annotations
{
	// Token: 0x020002AD RID: 685
	public sealed class LocalizationRequiredAttribute : Attribute
	{
		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06002CC8 RID: 11464 RVA: 0x0001173C File Offset: 0x0000F93C
		public bool Required
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
