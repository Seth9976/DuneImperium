using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Localization.Events;

namespace UnityEngine.Localization.Components
{
	// Token: 0x020000CA RID: 202
	public class LocalizeSpriteEvent : LocalizedAssetEvent<Sprite, LocalizedSprite, UnityEventSprite>
	{
		// Token: 0x06000A97 RID: 2711 RVA: 0x000066B1 File Offset: 0x000048B1
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizeSpriteEvent()
		{
			Il2CppClassPointerStore<LocalizeSpriteEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Components", "LocalizeSpriteEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizeSpriteEvent>.NativeClassPtr);
			LocalizeSpriteEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeSpriteEvent>.NativeClassPtr, 100665067);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x000313C8 File Offset: 0x0002F5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078817, XrefRangeEnd = 1078820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizeSpriteEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeSpriteEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeSpriteEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x000066EA File Offset: 0x000048EA
		public LocalizeSpriteEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
