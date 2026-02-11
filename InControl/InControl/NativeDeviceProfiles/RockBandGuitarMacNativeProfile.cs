using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000F4 RID: 244
	public class RockBandGuitarMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000CE1 RID: 3297 RVA: 0x00035A1C File Offset: 0x00033C1C
		// Note: this type is marked as 'beforefieldinit'.
		static RockBandGuitarMacNativeProfile()
		{
			Il2CppClassPointerStore<RockBandGuitarMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "RockBandGuitarMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RockBandGuitarMacNativeProfile>.NativeClassPtr);
			RockBandGuitarMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockBandGuitarMacNativeProfile>.NativeClassPtr, 100665045);
			RockBandGuitarMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockBandGuitarMacNativeProfile>.NativeClassPtr, 100665046);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00035A74 File Offset: 0x00033C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794326, XrefRangeEnd = 794343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RockBandGuitarMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00035AB0 File Offset: 0x00033CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RockBandGuitarMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RockBandGuitarMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockBandGuitarMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x000065BA File Offset: 0x000047BA
		public RockBandGuitarMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
