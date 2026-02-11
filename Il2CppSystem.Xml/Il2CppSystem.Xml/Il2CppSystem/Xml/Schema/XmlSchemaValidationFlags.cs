using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001E5 RID: 485
	[OriginalName("System.Xml.dll", "System.Xml.Schema", "XmlSchemaValidationFlags")]
	[Flags]
	public enum XmlSchemaValidationFlags
	{
		// Token: 0x04001E75 RID: 7797
		None = 0,
		// Token: 0x04001E76 RID: 7798
		ProcessInlineSchema = 1,
		// Token: 0x04001E77 RID: 7799
		ProcessSchemaLocation = 2,
		// Token: 0x04001E78 RID: 7800
		ReportValidationWarnings = 4,
		// Token: 0x04001E79 RID: 7801
		ProcessIdentityConstraints = 8,
		// Token: 0x04001E7A RID: 7802
		AllowXmlAttributes = 16
	}
}
