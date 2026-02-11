using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public class AudioBehaviour : Behaviour
	{
		// Token: 0x06000049 RID: 73 RVA: 0x000022EA File Offset: 0x000004EA
		// Note: this type is marked as 'beforefieldinit'.
		static AudioBehaviour()
		{
			Il2CppClassPointerStore<AudioBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioBehaviour>.NativeClassPtr);
			AudioBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBehaviour>.NativeClassPtr, 100663312);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003CE0 File Offset: 0x00001EE0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002323 File Offset: 0x00000523
		public AudioBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
