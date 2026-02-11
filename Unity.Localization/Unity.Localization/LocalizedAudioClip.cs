using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization
{
	// Token: 0x02000007 RID: 7
	[Serializable]
	public class LocalizedAudioClip : LocalizedAsset<AudioClip>
	{
		// Token: 0x0600006F RID: 111 RVA: 0x000021FD File Offset: 0x000003FD
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedAudioClip()
		{
			Il2CppClassPointerStore<LocalizedAudioClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizedAudioClip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedAudioClip>.NativeClassPtr);
			LocalizedAudioClip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAudioClip>.NativeClassPtr, 100663381);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000AC94 File Offset: 0x00008E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065399, XrefRangeEnd = 1065402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedAudioClip()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedAudioClip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAudioClip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002236 File Offset: 0x00000436
		public LocalizedAudioClip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
