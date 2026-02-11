using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Audio
{
	// Token: 0x02000026 RID: 38
	public static class AudioClipExtensionsInternal
	{
		// Token: 0x06000205 RID: 517 RVA: 0x00003189 File Offset: 0x00001389
		public static uint Internal_CreateAudioClipSampleProvider(AudioClip audioClip, ulong start, long end, bool loop, bool allowDrop, [Optional] bool loopPointIsStart)
		{
			return AudioClipExtensionsInternal.Internal_CreateAudioClipSampleProviderDelegateField(IL2CPP.Il2CppObjectBaseToPtr(audioClip), start, end, loop, allowDrop, loopPointIsStart);
		}

		// Token: 0x040001BE RID: 446
		private static readonly AudioClipExtensionsInternal.Internal_CreateAudioClipSampleProviderDelegate Internal_CreateAudioClipSampleProviderDelegateField = IL2CPP.ResolveICall<AudioClipExtensionsInternal.Internal_CreateAudioClipSampleProviderDelegate>("UnityEngine.Experimental.Audio.AudioClipExtensionsInternal::Internal_CreateAudioClipSampleProvider");

		// Token: 0x020000F8 RID: 248
		// (Invoke) Token: 0x060003BD RID: 957
		private delegate uint Internal_CreateAudioClipSampleProviderDelegate(IntPtr audioClip, ulong start, long end, bool loop, bool allowDrop, bool loopPointIsStart);
	}
}
