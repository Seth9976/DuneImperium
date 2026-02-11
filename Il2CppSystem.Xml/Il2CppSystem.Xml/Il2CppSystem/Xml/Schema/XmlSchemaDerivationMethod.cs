using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001AE RID: 430
	[OriginalName("System.Xml.dll", "System.Xml.Schema", "XmlSchemaDerivationMethod")]
	[Flags]
	public enum XmlSchemaDerivationMethod
	{
		// Token: 0x04001C27 RID: 7207
		Empty = 0,
		// Token: 0x04001C28 RID: 7208
		Substitution = 1,
		// Token: 0x04001C29 RID: 7209
		Extension = 2,
		// Token: 0x04001C2A RID: 7210
		Restriction = 4,
		// Token: 0x04001C2B RID: 7211
		List = 8,
		// Token: 0x04001C2C RID: 7212
		Union = 16,
		// Token: 0x04001C2D RID: 7213
		All = 255,
		// Token: 0x04001C2E RID: 7214
		None = 256
	}
}
