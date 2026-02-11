using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Audio
{
	// Token: 0x02000029 RID: 41
	public sealed class AudioManagerTestProxy
	{
		// Token: 0x0600020F RID: 527 RVA: 0x00003237 File Offset: 0x00001437
		public static bool ComputeAudibilityConsistency()
		{
			return AudioManagerTestProxy.ComputeAudibilityConsistencyDelegateField();
		}

		// Token: 0x040001C2 RID: 450
		private static readonly AudioManagerTestProxy.ComputeAudibilityConsistencyDelegate ComputeAudibilityConsistencyDelegateField = IL2CPP.ResolveICall<AudioManagerTestProxy.ComputeAudibilityConsistencyDelegate>("UnityEngine.Audio.AudioManagerTestProxy::ComputeAudibilityConsistency");

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x060003C5 RID: 965
		private delegate bool ComputeAudibilityConsistencyDelegate();
	}
}
