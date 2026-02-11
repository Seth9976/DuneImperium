using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000153 RID: 339
	public class XboxSeriesXWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000E82 RID: 3714 RVA: 0x0003B2B4 File Offset: 0x000394B4
		// Note: this type is marked as 'beforefieldinit'.
		static XboxSeriesXWindowsNativeProfile()
		{
			Il2CppClassPointerStore<XboxSeriesXWindowsNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "XboxSeriesXWindowsNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxSeriesXWindowsNativeProfile>.NativeClassPtr);
			XboxSeriesXWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxSeriesXWindowsNativeProfile>.NativeClassPtr, 100665272);
			XboxSeriesXWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxSeriesXWindowsNativeProfile>.NativeClassPtr, 100665273);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0003B30C File Offset: 0x0003950C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 815765, XrefRangeEnd = 816064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XboxSeriesXWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0003B348 File Offset: 0x00039548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816064, XrefRangeEnd = 816068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxSeriesXWindowsNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxSeriesXWindowsNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxSeriesXWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00006911 File Offset: 0x00004B11
		public XboxSeriesXWindowsNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
