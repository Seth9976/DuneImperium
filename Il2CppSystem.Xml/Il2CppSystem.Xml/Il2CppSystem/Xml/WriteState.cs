using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000053 RID: 83
	[OriginalName("System.Xml.dll", "System.Xml", "WriteState")]
	public enum WriteState
	{
		// Token: 0x04000825 RID: 2085
		Start,
		// Token: 0x04000826 RID: 2086
		Prolog,
		// Token: 0x04000827 RID: 2087
		Element,
		// Token: 0x04000828 RID: 2088
		Attribute,
		// Token: 0x04000829 RID: 2089
		Content,
		// Token: 0x0400082A RID: 2090
		Closed,
		// Token: 0x0400082B RID: 2091
		Error
	}
}
