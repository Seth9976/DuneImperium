using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	// Token: 0x020000FF RID: 255
	[Serializable]
	public class TrackedUGuiGraphic : JsonSerializerTrackedObject
	{
		// Token: 0x06000C60 RID: 3168 RVA: 0x00037F10 File Offset: 0x00036110
		// Note: this type is marked as 'beforefieldinit'.
		static TrackedUGuiGraphic()
		{
			Il2CppClassPointerStore<TrackedUGuiGraphic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedObjects", "TrackedUGuiGraphic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedUGuiGraphic>.NativeClassPtr);
			TrackedUGuiGraphic.NativeMethodInfoPtr_PostApplyTrackedProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedUGuiGraphic>.NativeClassPtr, 100665344);
			TrackedUGuiGraphic.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedUGuiGraphic>.NativeClassPtr, 100665345);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00037F68 File Offset: 0x00036168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080964, XrefRangeEnd = 1080968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostApplyTrackedProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedUGuiGraphic.NativeMethodInfoPtr_PostApplyTrackedProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00037FA4 File Offset: 0x000361A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedUGuiGraphic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedUGuiGraphic>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedUGuiGraphic.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0000735B File Offset: 0x0000555B
		public TrackedUGuiGraphic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_PostApplyTrackedProperties_Protected_Virtual_Void_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
