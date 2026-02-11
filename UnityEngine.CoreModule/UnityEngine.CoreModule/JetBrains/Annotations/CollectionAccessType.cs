using System;

namespace JetBrains.Annotations
{
	// Token: 0x02000061 RID: 97
	[Flags]
	public enum CollectionAccessType
	{
		// Token: 0x0400024B RID: 587
		None = 0,
		// Token: 0x0400024C RID: 588
		Read = 1,
		// Token: 0x0400024D RID: 589
		ModifyExistingContent = 2,
		// Token: 0x0400024E RID: 590
		UpdatedContent = 6
	}
}
