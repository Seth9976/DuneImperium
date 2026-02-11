using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Localization.Events;

namespace UnityEngine.Localization.Components
{
	// Token: 0x020000C5 RID: 197
	public class LocalizeAudioClipEvent : LocalizedAssetEvent<AudioClip, LocalizedAudioClip, UnityEventAudioClip>
	{
		// Token: 0x06000A73 RID: 2675 RVA: 0x000065D4 File Offset: 0x000047D4
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizeAudioClipEvent()
		{
			Il2CppClassPointerStore<LocalizeAudioClipEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Components", "LocalizeAudioClipEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizeAudioClipEvent>.NativeClassPtr);
			LocalizeAudioClipEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeAudioClipEvent>.NativeClassPtr, 100665049);
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x000309B4 File Offset: 0x0002EBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078759, XrefRangeEnd = 1078762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizeAudioClipEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeAudioClipEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeAudioClipEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0000660D File Offset: 0x0000480D
		public LocalizeAudioClipEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
