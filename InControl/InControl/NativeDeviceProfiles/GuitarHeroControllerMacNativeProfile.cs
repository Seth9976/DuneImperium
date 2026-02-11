using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000084 RID: 132
	public class GuitarHeroControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000B21 RID: 2849 RVA: 0x0002FF1C File Offset: 0x0002E11C
		// Note: this type is marked as 'beforefieldinit'.
		static GuitarHeroControllerMacNativeProfile()
		{
			Il2CppClassPointerStore<GuitarHeroControllerMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "GuitarHeroControllerMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuitarHeroControllerMacNativeProfile>.NativeClassPtr);
			GuitarHeroControllerMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuitarHeroControllerMacNativeProfile>.NativeClassPtr, 100664821);
			GuitarHeroControllerMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuitarHeroControllerMacNativeProfile>.NativeClassPtr, 100664822);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0002FF74 File Offset: 0x0002E174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792408, XrefRangeEnd = 792422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuitarHeroControllerMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0002FFB0 File Offset: 0x0002E1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuitarHeroControllerMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuitarHeroControllerMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuitarHeroControllerMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x000061CA File Offset: 0x000043CA
		public GuitarHeroControllerMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
