using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001D RID: 29
	public sealed class AudioEchoFilter : Behaviour
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00002B2B File Offset: 0x00000D2B
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002B3D File Offset: 0x00000D3D
		public float delay
		{
			get
			{
				return AudioEchoFilter.get_delayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioEchoFilter.set_delayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00002B50 File Offset: 0x00000D50
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002B62 File Offset: 0x00000D62
		public float decayRatio
		{
			get
			{
				return AudioEchoFilter.get_decayRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioEchoFilter.set_decayRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00002B75 File Offset: 0x00000D75
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00002B87 File Offset: 0x00000D87
		public float dryMix
		{
			get
			{
				return AudioEchoFilter.get_dryMixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioEchoFilter.set_dryMixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00002B9A File Offset: 0x00000D9A
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00002BAC File Offset: 0x00000DAC
		public float wetMix
		{
			get
			{
				return AudioEchoFilter.get_wetMixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioEchoFilter.set_wetMixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0400015F RID: 351
		private static readonly AudioEchoFilter.get_delayDelegate get_delayDelegateField = IL2CPP.ResolveICall<AudioEchoFilter.get_delayDelegate>("UnityEngine.AudioEchoFilter::get_delay");

		// Token: 0x04000160 RID: 352
		private static readonly AudioEchoFilter.set_delayDelegate set_delayDelegateField = IL2CPP.ResolveICall<AudioEchoFilter.set_delayDelegate>("UnityEngine.AudioEchoFilter::set_delay");

		// Token: 0x04000161 RID: 353
		private static readonly AudioEchoFilter.get_decayRatioDelegate get_decayRatioDelegateField = IL2CPP.ResolveICall<AudioEchoFilter.get_decayRatioDelegate>("UnityEngine.AudioEchoFilter::get_decayRatio");

		// Token: 0x04000162 RID: 354
		private static readonly AudioEchoFilter.set_decayRatioDelegate set_decayRatioDelegateField = IL2CPP.ResolveICall<AudioEchoFilter.set_decayRatioDelegate>("UnityEngine.AudioEchoFilter::set_decayRatio");

		// Token: 0x04000163 RID: 355
		private static readonly AudioEchoFilter.get_dryMixDelegate get_dryMixDelegateField = IL2CPP.ResolveICall<AudioEchoFilter.get_dryMixDelegate>("UnityEngine.AudioEchoFilter::get_dryMix");

		// Token: 0x04000164 RID: 356
		private static readonly AudioEchoFilter.set_dryMixDelegate set_dryMixDelegateField = IL2CPP.ResolveICall<AudioEchoFilter.set_dryMixDelegate>("UnityEngine.AudioEchoFilter::set_dryMix");

		// Token: 0x04000165 RID: 357
		private static readonly AudioEchoFilter.get_wetMixDelegate get_wetMixDelegateField = IL2CPP.ResolveICall<AudioEchoFilter.get_wetMixDelegate>("UnityEngine.AudioEchoFilter::get_wetMix");

		// Token: 0x04000166 RID: 358
		private static readonly AudioEchoFilter.set_wetMixDelegate set_wetMixDelegateField = IL2CPP.ResolveICall<AudioEchoFilter.set_wetMixDelegate>("UnityEngine.AudioEchoFilter::set_wetMix");

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x0600030F RID: 783
		private delegate float get_delayDelegate(IntPtr @this);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x06000311 RID: 785
		private delegate void set_delayDelegate(IntPtr @this, float value);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x06000313 RID: 787
		private delegate float get_decayRatioDelegate(IntPtr @this);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x06000315 RID: 789
		private delegate void set_decayRatioDelegate(IntPtr @this, float value);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x06000317 RID: 791
		private delegate float get_dryMixDelegate(IntPtr @this);

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x06000319 RID: 793
		private delegate void set_dryMixDelegate(IntPtr @this, float value);

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x0600031B RID: 795
		private delegate float get_wetMixDelegate(IntPtr @this);

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x0600031D RID: 797
		private delegate void set_wetMixDelegate(IntPtr @this, float value);
	}
}
