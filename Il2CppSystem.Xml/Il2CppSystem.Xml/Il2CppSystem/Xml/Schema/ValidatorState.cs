using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001E6 RID: 486
	[OriginalName("System.Xml.dll", "System.Xml.Schema", "ValidatorState")]
	public enum ValidatorState
	{
		// Token: 0x04001E7C RID: 7804
		None,
		// Token: 0x04001E7D RID: 7805
		Start,
		// Token: 0x04001E7E RID: 7806
		TopLevelAttribute,
		// Token: 0x04001E7F RID: 7807
		TopLevelTextOrWS,
		// Token: 0x04001E80 RID: 7808
		Element,
		// Token: 0x04001E81 RID: 7809
		Attribute,
		// Token: 0x04001E82 RID: 7810
		EndOfAttributes,
		// Token: 0x04001E83 RID: 7811
		Text,
		// Token: 0x04001E84 RID: 7812
		Whitespace,
		// Token: 0x04001E85 RID: 7813
		EndElement,
		// Token: 0x04001E86 RID: 7814
		SkipToEndElement,
		// Token: 0x04001E87 RID: 7815
		Finish
	}
}
