using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000085 RID: 133
	public class HarmonixDrumKitMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000B25 RID: 2853 RVA: 0x0002FFEC File Offset: 0x0002E1EC
		// Note: this type is marked as 'beforefieldinit'.
		static HarmonixDrumKitMacNativeProfile()
		{
			Il2CppClassPointerStore<HarmonixDrumKitMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "HarmonixDrumKitMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HarmonixDrumKitMacNativeProfile>.NativeClassPtr);
			HarmonixDrumKitMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarmonixDrumKitMacNativeProfile>.NativeClassPtr, 100664823);
			HarmonixDrumKitMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarmonixDrumKitMacNativeProfile>.NativeClassPtr, 100664824);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00030044 File Offset: 0x0002E244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792422, XrefRangeEnd = 792436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarmonixDrumKitMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00030080 File Offset: 0x0002E280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HarmonixDrumKitMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HarmonixDrumKitMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarmonixDrumKitMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x000061D3 File Offset: 0x000043D3
		public HarmonixDrumKitMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
