using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Audio
{
	// Token: 0x02000027 RID: 39
	public static class AudioSampleProviderExtensionsInternal
	{
		// Token: 0x06000207 RID: 519 RVA: 0x000083C8 File Offset: 0x000065C8
		public static float GetSpeed(AudioSampleProvider provider)
		{
			return AudioSampleProviderExtensionsInternal.InternalGetAudioSampleProviderSpeed(provider.id);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000031B3 File Offset: 0x000013B3
		public static float InternalGetAudioSampleProviderSpeed(uint providerId)
		{
			return AudioSampleProviderExtensionsInternal.InternalGetAudioSampleProviderSpeedDelegateField(providerId);
		}

		// Token: 0x040001BF RID: 447
		private static readonly AudioSampleProviderExtensionsInternal.InternalGetAudioSampleProviderSpeedDelegate InternalGetAudioSampleProviderSpeedDelegateField = IL2CPP.ResolveICall<AudioSampleProviderExtensionsInternal.InternalGetAudioSampleProviderSpeedDelegate>("UnityEngine.Experimental.Audio.AudioSampleProviderExtensionsInternal::InternalGetAudioSampleProviderSpeed");

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x060003BF RID: 959
		private delegate float InternalGetAudioSampleProviderSpeedDelegate(uint providerId);
	}
}
