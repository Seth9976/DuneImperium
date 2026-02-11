using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Audio
{
	// Token: 0x02000028 RID: 40
	public static class AudioSourceExtensionsInternal
	{
		// Token: 0x0600020A RID: 522 RVA: 0x000031E0 File Offset: 0x000013E0
		public static void RegisterSampleProvider(AudioSource source, AudioSampleProvider provider)
		{
			AudioSourceExtensionsInternal.Internal_RegisterSampleProviderWithAudioSource(source, provider.id);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000031F0 File Offset: 0x000013F0
		public static void UnregisterSampleProvider(AudioSource source, AudioSampleProvider provider)
		{
			AudioSourceExtensionsInternal.Internal_UnregisterSampleProviderFromAudioSource(source, provider.id);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00003200 File Offset: 0x00001400
		public static void Internal_RegisterSampleProviderWithAudioSource(AudioSource source, uint providerId)
		{
			AudioSourceExtensionsInternal.Internal_RegisterSampleProviderWithAudioSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), providerId);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00003213 File Offset: 0x00001413
		public static void Internal_UnregisterSampleProviderFromAudioSource(AudioSource source, uint providerId)
		{
			AudioSourceExtensionsInternal.Internal_UnregisterSampleProviderFromAudioSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), providerId);
		}

		// Token: 0x040001C0 RID: 448
		private static readonly AudioSourceExtensionsInternal.Internal_RegisterSampleProviderWithAudioSourceDelegate Internal_RegisterSampleProviderWithAudioSourceDelegateField = IL2CPP.ResolveICall<AudioSourceExtensionsInternal.Internal_RegisterSampleProviderWithAudioSourceDelegate>("UnityEngine.Experimental.Audio.AudioSourceExtensionsInternal::Internal_RegisterSampleProviderWithAudioSource");

		// Token: 0x040001C1 RID: 449
		private static readonly AudioSourceExtensionsInternal.Internal_UnregisterSampleProviderFromAudioSourceDelegate Internal_UnregisterSampleProviderFromAudioSourceDelegateField = IL2CPP.ResolveICall<AudioSourceExtensionsInternal.Internal_UnregisterSampleProviderFromAudioSourceDelegate>("UnityEngine.Experimental.Audio.AudioSourceExtensionsInternal::Internal_UnregisterSampleProviderFromAudioSource");

		// Token: 0x020000FA RID: 250
		// (Invoke) Token: 0x060003C1 RID: 961
		private delegate void Internal_RegisterSampleProviderWithAudioSourceDelegate(IntPtr source, uint providerId);

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x060003C3 RID: 963
		private delegate void Internal_UnregisterSampleProviderFromAudioSourceDelegate(IntPtr source, uint providerId);
	}
}
