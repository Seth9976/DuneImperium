using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001A RID: 26
	public sealed class AudioLowPassFilter : Behaviour
	{
		// Token: 0x06000178 RID: 376 RVA: 0x000079B0 File Offset: 0x00005BB0
		public AnimationCurve GetCustomLowpassLevelCurveCopy()
		{
			IntPtr intPtr = AudioLowPassFilter.GetCustomLowpassLevelCurveCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000029F1 File Offset: 0x00000BF1
		public static void SetCustomLowpassLevelCurveHelper(AudioLowPassFilter source, AnimationCurve curve)
		{
			AudioLowPassFilter.SetCustomLowpassLevelCurveHelperDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000079DC File Offset: 0x00005BDC
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00002A09 File Offset: 0x00000C09
		public AnimationCurve customCutoffCurve
		{
			get
			{
				return this.GetCustomLowpassLevelCurveCopy();
			}
			set
			{
				AudioLowPassFilter.SetCustomLowpassLevelCurveHelper(this, value);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00002A14 File Offset: 0x00000C14
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00002A26 File Offset: 0x00000C26
		public float cutoffFrequency
		{
			get
			{
				return AudioLowPassFilter.get_cutoffFrequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioLowPassFilter.set_cutoffFrequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00002A39 File Offset: 0x00000C39
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00002A4B File Offset: 0x00000C4B
		public float lowpassResonanceQ
		{
			get
			{
				return AudioLowPassFilter.get_lowpassResonanceQDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioLowPassFilter.set_lowpassResonanceQDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000153 RID: 339
		private static readonly AudioLowPassFilter.GetCustomLowpassLevelCurveCopyDelegate GetCustomLowpassLevelCurveCopyDelegateField = IL2CPP.ResolveICall<AudioLowPassFilter.GetCustomLowpassLevelCurveCopyDelegate>("UnityEngine.AudioLowPassFilter::GetCustomLowpassLevelCurveCopy");

		// Token: 0x04000154 RID: 340
		private static readonly AudioLowPassFilter.SetCustomLowpassLevelCurveHelperDelegate SetCustomLowpassLevelCurveHelperDelegateField = IL2CPP.ResolveICall<AudioLowPassFilter.SetCustomLowpassLevelCurveHelperDelegate>("UnityEngine.AudioLowPassFilter::SetCustomLowpassLevelCurveHelper");

		// Token: 0x04000155 RID: 341
		private static readonly AudioLowPassFilter.get_cutoffFrequencyDelegate get_cutoffFrequencyDelegateField = IL2CPP.ResolveICall<AudioLowPassFilter.get_cutoffFrequencyDelegate>("UnityEngine.AudioLowPassFilter::get_cutoffFrequency");

		// Token: 0x04000156 RID: 342
		private static readonly AudioLowPassFilter.set_cutoffFrequencyDelegate set_cutoffFrequencyDelegateField = IL2CPP.ResolveICall<AudioLowPassFilter.set_cutoffFrequencyDelegate>("UnityEngine.AudioLowPassFilter::set_cutoffFrequency");

		// Token: 0x04000157 RID: 343
		private static readonly AudioLowPassFilter.get_lowpassResonanceQDelegate get_lowpassResonanceQDelegateField = IL2CPP.ResolveICall<AudioLowPassFilter.get_lowpassResonanceQDelegate>("UnityEngine.AudioLowPassFilter::get_lowpassResonanceQ");

		// Token: 0x04000158 RID: 344
		private static readonly AudioLowPassFilter.set_lowpassResonanceQDelegate set_lowpassResonanceQDelegateField = IL2CPP.ResolveICall<AudioLowPassFilter.set_lowpassResonanceQDelegate>("UnityEngine.AudioLowPassFilter::set_lowpassResonanceQ");

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x060002F7 RID: 759
		private delegate IntPtr GetCustomLowpassLevelCurveCopyDelegate(IntPtr @this);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x060002F9 RID: 761
		private delegate void SetCustomLowpassLevelCurveHelperDelegate(IntPtr source, IntPtr curve);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x060002FB RID: 763
		private delegate float get_cutoffFrequencyDelegate(IntPtr @this);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x060002FD RID: 765
		private delegate void set_cutoffFrequencyDelegate(IntPtr @this, float value);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x060002FF RID: 767
		private delegate float get_lowpassResonanceQDelegate(IntPtr @this);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x06000301 RID: 769
		private delegate void set_lowpassResonanceQDelegate(IntPtr @this, float value);
	}
}
