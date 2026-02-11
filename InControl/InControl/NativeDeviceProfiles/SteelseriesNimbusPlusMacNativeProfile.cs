using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000114 RID: 276
	public class SteelseriesNimbusPlusMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D61 RID: 3425 RVA: 0x0003741C File Offset: 0x0003561C
		// Note: this type is marked as 'beforefieldinit'.
		static SteelseriesNimbusPlusMacNativeProfile()
		{
			Il2CppClassPointerStore<SteelseriesNimbusPlusMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "SteelseriesNimbusPlusMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteelseriesNimbusPlusMacNativeProfile>.NativeClassPtr);
			SteelseriesNimbusPlusMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteelseriesNimbusPlusMacNativeProfile>.NativeClassPtr, 100665109);
			SteelseriesNimbusPlusMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteelseriesNimbusPlusMacNativeProfile>.NativeClassPtr, 100665110);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00037474 File Offset: 0x00035674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798839, XrefRangeEnd = 799035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteelseriesNimbusPlusMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x000374B0 File Offset: 0x000356B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 799035, XrefRangeEnd = 799039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteelseriesNimbusPlusMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteelseriesNimbusPlusMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteelseriesNimbusPlusMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x000066DA File Offset: 0x000048DA
		public SteelseriesNimbusPlusMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
