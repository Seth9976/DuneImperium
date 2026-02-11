using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000091 RID: 145
	public class HoriFightingStickEX2MacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x000309AC File Offset: 0x0002EBAC
		// Note: this type is marked as 'beforefieldinit'.
		static HoriFightingStickEX2MacNativeProfile()
		{
			Il2CppClassPointerStore<HoriFightingStickEX2MacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "HoriFightingStickEX2MacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoriFightingStickEX2MacNativeProfile>.NativeClassPtr);
			HoriFightingStickEX2MacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoriFightingStickEX2MacNativeProfile>.NativeClassPtr, 100664847);
			HoriFightingStickEX2MacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoriFightingStickEX2MacNativeProfile>.NativeClassPtr, 100664848);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00030A04 File Offset: 0x0002EC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792597, XrefRangeEnd = 792613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoriFightingStickEX2MacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00030A40 File Offset: 0x0002EC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HoriFightingStickEX2MacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoriFightingStickEX2MacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoriFightingStickEX2MacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0000623F File Offset: 0x0000443F
		public HoriFightingStickEX2MacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
