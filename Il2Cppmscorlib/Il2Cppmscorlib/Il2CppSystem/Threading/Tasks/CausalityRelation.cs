using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001EC RID: 492
	[OriginalName("mscorlib.dll", "System.Threading.Tasks", "CausalityRelation")]
	public enum CausalityRelation
	{
		// Token: 0x04001C89 RID: 7305
		AssignDelegate,
		// Token: 0x04001C8A RID: 7306
		Join,
		// Token: 0x04001C8B RID: 7307
		Choice,
		// Token: 0x04001C8C RID: 7308
		Cancel,
		// Token: 0x04001C8D RID: 7309
		Error
	}
}
