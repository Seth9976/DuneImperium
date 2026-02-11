using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200043B RID: 1083
	[OriginalName("mscorlib.dll", "System.Reflection", "PInvokeAttributes")]
	[Flags]
	[Serializable]
	public enum PInvokeAttributes
	{
		// Token: 0x04003332 RID: 13106
		NoMangle = 1,
		// Token: 0x04003333 RID: 13107
		CharSetMask = 6,
		// Token: 0x04003334 RID: 13108
		CharSetNotSpec = 0,
		// Token: 0x04003335 RID: 13109
		CharSetAnsi = 2,
		// Token: 0x04003336 RID: 13110
		CharSetUnicode = 4,
		// Token: 0x04003337 RID: 13111
		CharSetAuto = 6,
		// Token: 0x04003338 RID: 13112
		BestFitUseAssem = 0,
		// Token: 0x04003339 RID: 13113
		BestFitEnabled = 16,
		// Token: 0x0400333A RID: 13114
		BestFitDisabled = 32,
		// Token: 0x0400333B RID: 13115
		BestFitMask = 48,
		// Token: 0x0400333C RID: 13116
		ThrowOnUnmappableCharUseAssem = 0,
		// Token: 0x0400333D RID: 13117
		ThrowOnUnmappableCharEnabled = 4096,
		// Token: 0x0400333E RID: 13118
		ThrowOnUnmappableCharDisabled = 8192,
		// Token: 0x0400333F RID: 13119
		ThrowOnUnmappableCharMask = 12288,
		// Token: 0x04003340 RID: 13120
		SupportsLastError = 64,
		// Token: 0x04003341 RID: 13121
		CallConvMask = 1792,
		// Token: 0x04003342 RID: 13122
		CallConvWinapi = 256,
		// Token: 0x04003343 RID: 13123
		CallConvCdecl = 512,
		// Token: 0x04003344 RID: 13124
		CallConvStdcall = 768,
		// Token: 0x04003345 RID: 13125
		CallConvThiscall = 1024,
		// Token: 0x04003346 RID: 13126
		CallConvFastcall = 1280,
		// Token: 0x04003347 RID: 13127
		MaxValue = 65535
	}
}
