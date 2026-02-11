using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000B8 RID: 184
	public class MadCatzFPSProMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000BF1 RID: 3057 RVA: 0x0003295C File Offset: 0x00030B5C
		// Note: this type is marked as 'beforefieldinit'.
		static MadCatzFPSProMacNativeProfile()
		{
			Il2CppClassPointerStore<MadCatzFPSProMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "MadCatzFPSProMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MadCatzFPSProMacNativeProfile>.NativeClassPtr);
			MadCatzFPSProMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MadCatzFPSProMacNativeProfile>.NativeClassPtr, 100664925);
			MadCatzFPSProMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MadCatzFPSProMacNativeProfile>.NativeClassPtr, 100664926);
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x000329B4 File Offset: 0x00030BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793153, XrefRangeEnd = 793167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MadCatzFPSProMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x000329F0 File Offset: 0x00030BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MadCatzFPSProMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MadCatzFPSProMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MadCatzFPSProMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0000639E File Offset: 0x0000459E
		public MadCatzFPSProMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
