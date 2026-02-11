using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001C RID: 28
	public sealed class AudioDistortionFilter : Behaviour
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00002B06 File Offset: 0x00000D06
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00002B18 File Offset: 0x00000D18
		public float distortionLevel
		{
			get
			{
				return AudioDistortionFilter.get_distortionLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioDistortionFilter.set_distortionLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0400015D RID: 349
		private static readonly AudioDistortionFilter.get_distortionLevelDelegate get_distortionLevelDelegateField = IL2CPP.ResolveICall<AudioDistortionFilter.get_distortionLevelDelegate>("UnityEngine.AudioDistortionFilter::get_distortionLevel");

		// Token: 0x0400015E RID: 350
		private static readonly AudioDistortionFilter.set_distortionLevelDelegate set_distortionLevelDelegateField = IL2CPP.ResolveICall<AudioDistortionFilter.set_distortionLevelDelegate>("UnityEngine.AudioDistortionFilter::set_distortionLevel");

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x0600030B RID: 779
		private delegate float get_distortionLevelDelegate(IntPtr @this);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x0600030D RID: 781
		private delegate void set_distortionLevelDelegate(IntPtr @this, float value);
	}
}
