using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000081 RID: 129
	public class ElecomControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000B15 RID: 2837 RVA: 0x0002FCAC File Offset: 0x0002DEAC
		// Note: this type is marked as 'beforefieldinit'.
		static ElecomControllerMacNativeProfile()
		{
			Il2CppClassPointerStore<ElecomControllerMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "ElecomControllerMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ElecomControllerMacNativeProfile>.NativeClassPtr);
			ElecomControllerMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElecomControllerMacNativeProfile>.NativeClassPtr, 100664815);
			ElecomControllerMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElecomControllerMacNativeProfile>.NativeClassPtr, 100664816);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0002FD04 File Offset: 0x0002DF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792361, XrefRangeEnd = 792375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ElecomControllerMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0002FD40 File Offset: 0x0002DF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ElecomControllerMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ElecomControllerMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElecomControllerMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x000061AF File Offset: 0x000043AF
		public ElecomControllerMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
