using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000FE RID: 254
	public class ThrustmasterTMXMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000D09 RID: 3337 RVA: 0x0003623C File Offset: 0x0003443C
		// Note: this type is marked as 'beforefieldinit'.
		static ThrustmasterTMXMacNativeProfile()
		{
			Il2CppClassPointerStore<ThrustmasterTMXMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "ThrustmasterTMXMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrustmasterTMXMacNativeProfile>.NativeClassPtr);
			ThrustmasterTMXMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrustmasterTMXMacNativeProfile>.NativeClassPtr, 100665065);
			ThrustmasterTMXMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrustmasterTMXMacNativeProfile>.NativeClassPtr, 100665066);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00036294 File Offset: 0x00034494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794524, XrefRangeEnd = 794541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThrustmasterTMXMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x000362D0 File Offset: 0x000344D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThrustmasterTMXMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThrustmasterTMXMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrustmasterTMXMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00006614 File Offset: 0x00004814
		public ThrustmasterTMXMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
