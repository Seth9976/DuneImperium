using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000FA RID: 250
	public class ThrustMasterFerrari430RacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000CF9 RID: 3321 RVA: 0x00035EFC File Offset: 0x000340FC
		// Note: this type is marked as 'beforefieldinit'.
		static ThrustMasterFerrari430RacingWheelMacNativeProfile()
		{
			Il2CppClassPointerStore<ThrustMasterFerrari430RacingWheelMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "ThrustMasterFerrari430RacingWheelMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrustMasterFerrari430RacingWheelMacNativeProfile>.NativeClassPtr);
			ThrustMasterFerrari430RacingWheelMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrustMasterFerrari430RacingWheelMacNativeProfile>.NativeClassPtr, 100665057);
			ThrustMasterFerrari430RacingWheelMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrustMasterFerrari430RacingWheelMacNativeProfile>.NativeClassPtr, 100665058);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00035F54 File Offset: 0x00034154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794448, XrefRangeEnd = 794465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThrustMasterFerrari430RacingWheelMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00035F90 File Offset: 0x00034190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThrustMasterFerrari430RacingWheelMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThrustMasterFerrari430RacingWheelMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrustMasterFerrari430RacingWheelMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x000065F0 File Offset: 0x000047F0
		public ThrustMasterFerrari430RacingWheelMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
