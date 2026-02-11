using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000FB RID: 251
	public class ThrustmasterFerrari458RacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000CFD RID: 3325 RVA: 0x00035FCC File Offset: 0x000341CC
		// Note: this type is marked as 'beforefieldinit'.
		static ThrustmasterFerrari458RacingWheelMacNativeProfile()
		{
			Il2CppClassPointerStore<ThrustmasterFerrari458RacingWheelMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "ThrustmasterFerrari458RacingWheelMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrustmasterFerrari458RacingWheelMacNativeProfile>.NativeClassPtr);
			ThrustmasterFerrari458RacingWheelMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrustmasterFerrari458RacingWheelMacNativeProfile>.NativeClassPtr, 100665059);
			ThrustmasterFerrari458RacingWheelMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrustmasterFerrari458RacingWheelMacNativeProfile>.NativeClassPtr, 100665060);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00036024 File Offset: 0x00034224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794465, XrefRangeEnd = 794486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThrustmasterFerrari458RacingWheelMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00036060 File Offset: 0x00034260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThrustmasterFerrari458RacingWheelMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThrustmasterFerrari458RacingWheelMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrustmasterFerrari458RacingWheelMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x000065F9 File Offset: 0x000047F9
		public ThrustmasterFerrari458RacingWheelMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
