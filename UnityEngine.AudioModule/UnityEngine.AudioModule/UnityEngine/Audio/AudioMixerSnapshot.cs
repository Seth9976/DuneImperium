using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Audio
{
	// Token: 0x02000011 RID: 17
	public class AudioMixerSnapshot : Object
	{
		// Token: 0x06000140 RID: 320 RVA: 0x000074C4 File Offset: 0x000056C4
		// Note: this type is marked as 'beforefieldinit'.
		static AudioMixerSnapshot()
		{
			Il2CppClassPointerStore<AudioMixerSnapshot>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioMixerSnapshot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioMixerSnapshot>.NativeClassPtr);
			AudioMixerSnapshot.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerSnapshot>.NativeClassPtr, 100663444);
			AudioMixerSnapshot.NativeMethodInfoPtr_get_audioMixer_Public_get_AudioMixer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerSnapshot>.NativeClassPtr, 100663445);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000751C File Offset: 0x0000571C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259484, XrefRangeEnd = 1259488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioMixerSnapshot()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioMixerSnapshot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixerSnapshot.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00007558 File Offset: 0x00005758
		public unsafe AudioMixer audioMixer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259488, XrefRangeEnd = 1259490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixerSnapshot.NativeMethodInfoPtr_get_audioMixer_Public_get_AudioMixer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr3) : null;
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002719 File Offset: 0x00000919
		public AudioMixerSnapshot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002722 File Offset: 0x00000922
		public void TransitionTo(float timeToReach)
		{
			this.audioMixer.TransitionToSnapshot(this, timeToReach);
		}

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_get_audioMixer_Public_get_AudioMixer_0;
	}
}
