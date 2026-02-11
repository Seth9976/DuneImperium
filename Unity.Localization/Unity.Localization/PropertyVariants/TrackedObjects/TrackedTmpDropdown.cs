using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	// Token: 0x020000FD RID: 253
	[Serializable]
	public class TrackedTmpDropdown : JsonSerializerTrackedObject
	{
		// Token: 0x06000C44 RID: 3140 RVA: 0x00037834 File Offset: 0x00035A34
		// Note: this type is marked as 'beforefieldinit'.
		static TrackedTmpDropdown()
		{
			Il2CppClassPointerStore<TrackedTmpDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedObjects", "TrackedTmpDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedTmpDropdown>.NativeClassPtr);
			TrackedTmpDropdown.NativeMethodInfoPtr_PostApplyTrackedProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedTmpDropdown>.NativeClassPtr, 100665328);
			TrackedTmpDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedTmpDropdown>.NativeClassPtr, 100665329);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0003788C File Offset: 0x00035A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080809, XrefRangeEnd = 1080814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostApplyTrackedProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedTmpDropdown.NativeMethodInfoPtr_PostApplyTrackedProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x000378C8 File Offset: 0x00035AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedTmpDropdown()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedTmpDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedTmpDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x000072D9 File Offset: 0x000054D9
		public TrackedTmpDropdown(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_PostApplyTrackedProperties_Protected_Virtual_Void_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
