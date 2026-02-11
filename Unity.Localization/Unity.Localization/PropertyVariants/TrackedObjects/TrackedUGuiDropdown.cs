using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	// Token: 0x02000100 RID: 256
	[Serializable]
	public class TrackedUGuiDropdown : JsonSerializerTrackedObject
	{
		// Token: 0x06000C64 RID: 3172 RVA: 0x00037FE0 File Offset: 0x000361E0
		// Note: this type is marked as 'beforefieldinit'.
		static TrackedUGuiDropdown()
		{
			Il2CppClassPointerStore<TrackedUGuiDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedObjects", "TrackedUGuiDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedUGuiDropdown>.NativeClassPtr);
			TrackedUGuiDropdown.NativeMethodInfoPtr_PostApplyTrackedProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedUGuiDropdown>.NativeClassPtr, 100665346);
			TrackedUGuiDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedUGuiDropdown>.NativeClassPtr, 100665347);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00038038 File Offset: 0x00036238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080968, XrefRangeEnd = 1080973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostApplyTrackedProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedUGuiDropdown.NativeMethodInfoPtr_PostApplyTrackedProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00038074 File Offset: 0x00036274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedUGuiDropdown()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedUGuiDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedUGuiDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00007364 File Offset: 0x00005564
		public TrackedUGuiDropdown(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_PostApplyTrackedProperties_Protected_Virtual_Void_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
