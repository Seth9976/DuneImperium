using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000090 RID: 144
	public class HoriFightingEdgeArcadeStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000B51 RID: 2897 RVA: 0x000308DC File Offset: 0x0002EADC
		// Note: this type is marked as 'beforefieldinit'.
		static HoriFightingEdgeArcadeStickMacNativeProfile()
		{
			Il2CppClassPointerStore<HoriFightingEdgeArcadeStickMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "HoriFightingEdgeArcadeStickMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoriFightingEdgeArcadeStickMacNativeProfile>.NativeClassPtr);
			HoriFightingEdgeArcadeStickMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoriFightingEdgeArcadeStickMacNativeProfile>.NativeClassPtr, 100664845);
			HoriFightingEdgeArcadeStickMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoriFightingEdgeArcadeStickMacNativeProfile>.NativeClassPtr, 100664846);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00030934 File Offset: 0x0002EB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792583, XrefRangeEnd = 792597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoriFightingEdgeArcadeStickMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00030970 File Offset: 0x0002EB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HoriFightingEdgeArcadeStickMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoriFightingEdgeArcadeStickMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoriFightingEdgeArcadeStickMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00006236 File Offset: 0x00004436
		public HoriFightingEdgeArcadeStickMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
