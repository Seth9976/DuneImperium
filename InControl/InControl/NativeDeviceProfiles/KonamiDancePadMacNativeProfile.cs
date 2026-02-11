using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000A6 RID: 166
	public class KonamiDancePadMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000BA9 RID: 2985 RVA: 0x00031ABC File Offset: 0x0002FCBC
		// Note: this type is marked as 'beforefieldinit'.
		static KonamiDancePadMacNativeProfile()
		{
			Il2CppClassPointerStore<KonamiDancePadMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "KonamiDancePadMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KonamiDancePadMacNativeProfile>.NativeClassPtr);
			KonamiDancePadMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KonamiDancePadMacNativeProfile>.NativeClassPtr, 100664889);
			KonamiDancePadMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KonamiDancePadMacNativeProfile>.NativeClassPtr, 100664890);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00031B14 File Offset: 0x0002FD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792896, XrefRangeEnd = 792910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KonamiDancePadMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00031B50 File Offset: 0x0002FD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KonamiDancePadMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KonamiDancePadMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KonamiDancePadMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x000062FC File Offset: 0x000044FC
		public KonamiDancePadMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
