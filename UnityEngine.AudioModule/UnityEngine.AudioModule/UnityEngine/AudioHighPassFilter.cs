using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001B RID: 27
	public sealed class AudioHighPassFilter : Behaviour
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00002A9C File Offset: 0x00000C9C
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002AAE File Offset: 0x00000CAE
		public float cutoffFrequency
		{
			get
			{
				return AudioHighPassFilter.get_cutoffFrequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioHighPassFilter.set_cutoffFrequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00002AC1 File Offset: 0x00000CC1
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002AD3 File Offset: 0x00000CD3
		public float highpassResonanceQ
		{
			get
			{
				return AudioHighPassFilter.get_highpassResonanceQDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioHighPassFilter.set_highpassResonanceQDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000159 RID: 345
		private static readonly AudioHighPassFilter.get_cutoffFrequencyDelegate get_cutoffFrequencyDelegateField = IL2CPP.ResolveICall<AudioHighPassFilter.get_cutoffFrequencyDelegate>("UnityEngine.AudioHighPassFilter::get_cutoffFrequency");

		// Token: 0x0400015A RID: 346
		private static readonly AudioHighPassFilter.set_cutoffFrequencyDelegate set_cutoffFrequencyDelegateField = IL2CPP.ResolveICall<AudioHighPassFilter.set_cutoffFrequencyDelegate>("UnityEngine.AudioHighPassFilter::set_cutoffFrequency");

		// Token: 0x0400015B RID: 347
		private static readonly AudioHighPassFilter.get_highpassResonanceQDelegate get_highpassResonanceQDelegateField = IL2CPP.ResolveICall<AudioHighPassFilter.get_highpassResonanceQDelegate>("UnityEngine.AudioHighPassFilter::get_highpassResonanceQ");

		// Token: 0x0400015C RID: 348
		private static readonly AudioHighPassFilter.set_highpassResonanceQDelegate set_highpassResonanceQDelegateField = IL2CPP.ResolveICall<AudioHighPassFilter.set_highpassResonanceQDelegate>("UnityEngine.AudioHighPassFilter::set_highpassResonanceQ");

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x06000303 RID: 771
		private delegate float get_cutoffFrequencyDelegate(IntPtr @this);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x06000305 RID: 773
		private delegate void set_cutoffFrequencyDelegate(IntPtr @this, float value);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x06000307 RID: 775
		private delegate float get_highpassResonanceQDelegate(IntPtr @this);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x06000309 RID: 777
		private delegate void set_highpassResonanceQDelegate(IntPtr @this, float value);
	}
}
