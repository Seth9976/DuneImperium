using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000143 RID: 323
	public class NVidiaShieldWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000E42 RID: 3650 RVA: 0x0003A5B4 File Offset: 0x000387B4
		// Note: this type is marked as 'beforefieldinit'.
		static NVidiaShieldWindowsNativeProfile()
		{
			Il2CppClassPointerStore<NVidiaShieldWindowsNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "NVidiaShieldWindowsNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NVidiaShieldWindowsNativeProfile>.NativeClassPtr);
			NVidiaShieldWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NVidiaShieldWindowsNativeProfile>.NativeClassPtr, 100665240);
			NVidiaShieldWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NVidiaShieldWindowsNativeProfile>.NativeClassPtr, 100665241);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0003A60C File Offset: 0x0003880C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 810750, XrefRangeEnd = 811049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NVidiaShieldWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0003A648 File Offset: 0x00038848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811049, XrefRangeEnd = 811053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NVidiaShieldWindowsNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NVidiaShieldWindowsNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NVidiaShieldWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00006881 File Offset: 0x00004A81
		public NVidiaShieldWindowsNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
