using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Audio
{
	// Token: 0x0200000F RID: 15
	public class AudioMixerGroup : Object
	{
		// Token: 0x06000133 RID: 307 RVA: 0x00007264 File Offset: 0x00005464
		// Note: this type is marked as 'beforefieldinit'.
		static AudioMixerGroup()
		{
			Il2CppClassPointerStore<AudioMixerGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioMixerGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioMixerGroup>.NativeClassPtr);
			AudioMixerGroup.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerGroup>.NativeClassPtr, 100663440);
			AudioMixerGroup.NativeMethodInfoPtr_get_audioMixer_Public_get_AudioMixer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerGroup>.NativeClassPtr, 100663441);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000072BC File Offset: 0x000054BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259474, XrefRangeEnd = 1259478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioMixerGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioMixerGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixerGroup.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000135 RID: 309 RVA: 0x000072F8 File Offset: 0x000054F8
		public unsafe AudioMixer audioMixer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259478, XrefRangeEnd = 1259480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixerGroup.NativeMethodInfoPtr_get_audioMixer_Public_get_AudioMixer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr3) : null;
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000026EF File Offset: 0x000008EF
		public AudioMixerGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_get_audioMixer_Public_get_AudioMixer_0;
	}
}
