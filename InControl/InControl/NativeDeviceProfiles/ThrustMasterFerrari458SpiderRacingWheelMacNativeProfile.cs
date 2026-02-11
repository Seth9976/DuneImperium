using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000FC RID: 252
	public class ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000D01 RID: 3329 RVA: 0x0003609C File Offset: 0x0003429C
		// Note: this type is marked as 'beforefieldinit'.
		static ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile()
		{
			Il2CppClassPointerStore<ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile>.NativeClassPtr);
			ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile>.NativeClassPtr, 100665061);
			ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile>.NativeClassPtr, 100665062);
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x000360F4 File Offset: 0x000342F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794486, XrefRangeEnd = 794503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00036130 File Offset: 0x00034330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00006602 File Offset: 0x00004802
		public ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
