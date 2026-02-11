using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000391 RID: 913
	[OriginalName("mscorlib.dll", "System.Runtime.InteropServices", "DllImportSearchPath")]
	[Flags]
	public enum DllImportSearchPath
	{
		// Token: 0x04002D96 RID: 11670
		UseDllDirectoryForDependencies = 256,
		// Token: 0x04002D97 RID: 11671
		ApplicationDirectory = 512,
		// Token: 0x04002D98 RID: 11672
		UserDirectories = 1024,
		// Token: 0x04002D99 RID: 11673
		System32 = 2048,
		// Token: 0x04002D9A RID: 11674
		SafeDirectories = 4096,
		// Token: 0x04002D9B RID: 11675
		AssemblyDirectory = 2,
		// Token: 0x04002D9C RID: 11676
		LegacyBehavior = 0
	}
}
