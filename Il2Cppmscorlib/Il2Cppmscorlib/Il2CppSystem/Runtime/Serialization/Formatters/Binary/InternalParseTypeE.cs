using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000344 RID: 836
	[OriginalName("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "InternalParseTypeE")]
	public enum InternalParseTypeE
	{
		// Token: 0x040029BC RID: 10684
		Empty,
		// Token: 0x040029BD RID: 10685
		SerializedStreamHeader,
		// Token: 0x040029BE RID: 10686
		Object,
		// Token: 0x040029BF RID: 10687
		Member,
		// Token: 0x040029C0 RID: 10688
		ObjectEnd,
		// Token: 0x040029C1 RID: 10689
		MemberEnd,
		// Token: 0x040029C2 RID: 10690
		Headers,
		// Token: 0x040029C3 RID: 10691
		HeadersEnd,
		// Token: 0x040029C4 RID: 10692
		SerializedStreamHeaderEnd,
		// Token: 0x040029C5 RID: 10693
		Envelope,
		// Token: 0x040029C6 RID: 10694
		EnvelopeEnd,
		// Token: 0x040029C7 RID: 10695
		Body,
		// Token: 0x040029C8 RID: 10696
		BodyEnd
	}
}
