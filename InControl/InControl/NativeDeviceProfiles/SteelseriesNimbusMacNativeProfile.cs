using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000113 RID: 275
	public class SteelseriesNimbusMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D5D RID: 3421 RVA: 0x0003734C File Offset: 0x0003554C
		// Note: this type is marked as 'beforefieldinit'.
		static SteelseriesNimbusMacNativeProfile()
		{
			Il2CppClassPointerStore<SteelseriesNimbusMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "SteelseriesNimbusMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteelseriesNimbusMacNativeProfile>.NativeClassPtr);
			SteelseriesNimbusMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteelseriesNimbusMacNativeProfile>.NativeClassPtr, 100665107);
			SteelseriesNimbusMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteelseriesNimbusMacNativeProfile>.NativeClassPtr, 100665108);
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x000373A4 File Offset: 0x000355A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798624, XrefRangeEnd = 798835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteelseriesNimbusMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x000373E0 File Offset: 0x000355E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798835, XrefRangeEnd = 798839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteelseriesNimbusMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteelseriesNimbusMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteelseriesNimbusMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x000066D1 File Offset: 0x000048D1
		public SteelseriesNimbusMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
