using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000396 RID: 918
	[OriginalName("mscorlib.dll", "System.Runtime.InteropServices", "CallingConvention")]
	[Serializable]
	public enum CallingConvention
	{
		// Token: 0x04002DB5 RID: 11701
		Winapi = 1,
		// Token: 0x04002DB6 RID: 11702
		Cdecl,
		// Token: 0x04002DB7 RID: 11703
		StdCall,
		// Token: 0x04002DB8 RID: 11704
		ThisCall,
		// Token: 0x04002DB9 RID: 11705
		FastCall
	}
}
