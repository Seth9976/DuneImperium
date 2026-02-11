using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Permissions
{
	// Token: 0x0200022C RID: 556
	[OriginalName("mscorlib.dll", "System.Security.Permissions", "SecurityAction")]
	[Serializable]
	public enum SecurityAction
	{
		// Token: 0x04002011 RID: 8209
		Demand = 2,
		// Token: 0x04002012 RID: 8210
		Assert,
		// Token: 0x04002013 RID: 8211
		Deny,
		// Token: 0x04002014 RID: 8212
		PermitOnly,
		// Token: 0x04002015 RID: 8213
		LinkDemand,
		// Token: 0x04002016 RID: 8214
		InheritanceDemand,
		// Token: 0x04002017 RID: 8215
		RequestMinimum,
		// Token: 0x04002018 RID: 8216
		RequestOptional,
		// Token: 0x04002019 RID: 8217
		RequestRefuse
	}
}
