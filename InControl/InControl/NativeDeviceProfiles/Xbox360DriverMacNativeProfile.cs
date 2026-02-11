using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000115 RID: 277
	public class Xbox360DriverMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D65 RID: 3429 RVA: 0x000374EC File Offset: 0x000356EC
		// Note: this type is marked as 'beforefieldinit'.
		static Xbox360DriverMacNativeProfile()
		{
			Il2CppClassPointerStore<Xbox360DriverMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "Xbox360DriverMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Xbox360DriverMacNativeProfile>.NativeClassPtr);
			Xbox360DriverMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Xbox360DriverMacNativeProfile>.NativeClassPtr, 100665111);
			Xbox360DriverMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Xbox360DriverMacNativeProfile>.NativeClassPtr, 100665112);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00037544 File Offset: 0x00035744
		[CallerCount(131)]
		[CachedScanResults(RefRangeStart = 799281, RefRangeEnd = 799412, XrefRangeStart = 799039, XrefRangeEnd = 799281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Xbox360DriverMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00037580 File Offset: 0x00035780
		[CallerCount(131)]
		[CachedScanResults(RefRangeStart = 799416, RefRangeEnd = 799547, XrefRangeStart = 799412, XrefRangeEnd = 799416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Xbox360DriverMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Xbox360DriverMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Xbox360DriverMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x000066E3 File Offset: 0x000048E3
		public Xbox360DriverMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
