using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Localization.Events;

namespace UnityEngine.Localization.Components
{
	// Token: 0x020000CC RID: 204
	public class LocalizeTextureEvent : LocalizedAssetEvent<Texture, LocalizedTexture, UnityEventTexture>
	{
		// Token: 0x06000AB3 RID: 2739 RVA: 0x00006778 File Offset: 0x00004978
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizeTextureEvent()
		{
			Il2CppClassPointerStore<LocalizeTextureEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Components", "LocalizeTextureEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizeTextureEvent>.NativeClassPtr);
			LocalizeTextureEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTextureEvent>.NativeClassPtr, 100665083);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00031A18 File Offset: 0x0002FC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078896, XrefRangeEnd = 1078899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizeTextureEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeTextureEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTextureEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x000067B1 File Offset: 0x000049B1
		public LocalizeTextureEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
