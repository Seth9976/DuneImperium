using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200007D RID: 125
	public class BrookNeoGeoConverterMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000B05 RID: 2821 RVA: 0x0002F96C File Offset: 0x0002DB6C
		// Note: this type is marked as 'beforefieldinit'.
		static BrookNeoGeoConverterMacNativeProfile()
		{
			Il2CppClassPointerStore<BrookNeoGeoConverterMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "BrookNeoGeoConverterMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrookNeoGeoConverterMacNativeProfile>.NativeClassPtr);
			BrookNeoGeoConverterMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrookNeoGeoConverterMacNativeProfile>.NativeClassPtr, 100664807);
			BrookNeoGeoConverterMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrookNeoGeoConverterMacNativeProfile>.NativeClassPtr, 100664808);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0002F9C4 File Offset: 0x0002DBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792305, XrefRangeEnd = 792319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrookNeoGeoConverterMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0002FA00 File Offset: 0x0002DC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrookNeoGeoConverterMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrookNeoGeoConverterMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrookNeoGeoConverterMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0000618B File Offset: 0x0000438B
		public BrookNeoGeoConverterMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
