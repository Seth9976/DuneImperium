using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.IO
{
	// Token: 0x02000188 RID: 392
	[OriginalName("System.dll", "System.IO", "WatcherChangeTypes")]
	[Flags]
	public enum WatcherChangeTypes
	{
		// Token: 0x0400127F RID: 4735
		All = 15,
		// Token: 0x04001280 RID: 4736
		Changed = 4,
		// Token: 0x04001281 RID: 4737
		Created = 1,
		// Token: 0x04001282 RID: 4738
		Deleted = 2,
		// Token: 0x04001283 RID: 4739
		Renamed = 8
	}
}
