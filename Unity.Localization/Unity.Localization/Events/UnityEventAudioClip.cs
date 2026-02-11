using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace UnityEngine.Localization.Events
{
	// Token: 0x020000C0 RID: 192
	[Serializable]
	public class UnityEventAudioClip : UnityEvent<AudioClip>
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x0000648A File Offset: 0x0000468A
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventAudioClip()
		{
			Il2CppClassPointerStore<UnityEventAudioClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Events", "UnityEventAudioClip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventAudioClip>.NativeClassPtr);
			UnityEventAudioClip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventAudioClip>.NativeClassPtr, 100665044);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00030888 File Offset: 0x0002EA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078744, XrefRangeEnd = 1078747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventAudioClip()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventAudioClip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventAudioClip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x000064C3 File Offset: 0x000046C3
		public UnityEventAudioClip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
