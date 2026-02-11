using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000188 RID: 392
	[OriginalName("System.Xml.dll", "System.Xml.Schema", "AttributeMatchState")]
	public enum AttributeMatchState
	{
		// Token: 0x04001889 RID: 6281
		AttributeFound,
		// Token: 0x0400188A RID: 6282
		AnyIdAttributeFound,
		// Token: 0x0400188B RID: 6283
		UndeclaredElementAndAttribute,
		// Token: 0x0400188C RID: 6284
		UndeclaredAttribute,
		// Token: 0x0400188D RID: 6285
		AnyAttributeLax,
		// Token: 0x0400188E RID: 6286
		AnyAttributeSkip,
		// Token: 0x0400188F RID: 6287
		ProhibitedAnyAttribute,
		// Token: 0x04001890 RID: 6288
		ProhibitedAttribute,
		// Token: 0x04001891 RID: 6289
		AttributeNameMismatch,
		// Token: 0x04001892 RID: 6290
		ValidateAttributeInvalidCall
	}
}
