using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000099 RID: 153
	public class HoriRealArcadeProEXPremiumVLXMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000B75 RID: 2933 RVA: 0x0003102C File Offset: 0x0002F22C
		// Note: this type is marked as 'beforefieldinit'.
		static HoriRealArcadeProEXPremiumVLXMacNativeProfile()
		{
			Il2CppClassPointerStore<HoriRealArcadeProEXPremiumVLXMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "HoriRealArcadeProEXPremiumVLXMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoriRealArcadeProEXPremiumVLXMacNativeProfile>.NativeClassPtr);
			HoriRealArcadeProEXPremiumVLXMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoriRealArcadeProEXPremiumVLXMacNativeProfile>.NativeClassPtr, 100664863);
			HoriRealArcadeProEXPremiumVLXMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoriRealArcadeProEXPremiumVLXMacNativeProfile>.NativeClassPtr, 100664864);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00031084 File Offset: 0x0002F284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792712, XrefRangeEnd = 792726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoriRealArcadeProEXPremiumVLXMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x000310C0 File Offset: 0x0002F2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HoriRealArcadeProEXPremiumVLXMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoriRealArcadeProEXPremiumVLXMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoriRealArcadeProEXPremiumVLXMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00006287 File Offset: 0x00004487
		public HoriRealArcadeProEXPremiumVLXMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
