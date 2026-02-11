using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net
{
	// Token: 0x0200019F RID: 415
	[OriginalName("System.dll", "System.Net", "FtpMethodFlags")]
	[Flags]
	public enum FtpMethodFlags
	{
		// Token: 0x04001443 RID: 5187
		None = 0,
		// Token: 0x04001444 RID: 5188
		IsDownload = 1,
		// Token: 0x04001445 RID: 5189
		IsUpload = 2,
		// Token: 0x04001446 RID: 5190
		TakesParameter = 4,
		// Token: 0x04001447 RID: 5191
		MayTakeParameter = 8,
		// Token: 0x04001448 RID: 5192
		DoesNotTakeParameter = 16,
		// Token: 0x04001449 RID: 5193
		ParameterIsDirectory = 32,
		// Token: 0x0400144A RID: 5194
		ShouldParseForResponseUri = 64,
		// Token: 0x0400144B RID: 5195
		HasHttpCommand = 128,
		// Token: 0x0400144C RID: 5196
		MustChangeWorkingDirectoryToPath = 256
	}
}
