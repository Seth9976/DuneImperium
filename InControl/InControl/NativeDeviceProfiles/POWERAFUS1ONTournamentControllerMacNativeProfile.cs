using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000E2 RID: 226
	public class POWERAFUS1ONTournamentControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000C99 RID: 3225 RVA: 0x00034B7C File Offset: 0x00032D7C
		// Note: this type is marked as 'beforefieldinit'.
		static POWERAFUS1ONTournamentControllerMacNativeProfile()
		{
			Il2CppClassPointerStore<POWERAFUS1ONTournamentControllerMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "POWERAFUS1ONTournamentControllerMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<POWERAFUS1ONTournamentControllerMacNativeProfile>.NativeClassPtr);
			POWERAFUS1ONTournamentControllerMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POWERAFUS1ONTournamentControllerMacNativeProfile>.NativeClassPtr, 100665009);
			POWERAFUS1ONTournamentControllerMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POWERAFUS1ONTournamentControllerMacNativeProfile>.NativeClassPtr, 100665010);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00034BD4 File Offset: 0x00032DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793992, XrefRangeEnd = 794009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POWERAFUS1ONTournamentControllerMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00034C10 File Offset: 0x00032E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe POWERAFUS1ONTournamentControllerMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<POWERAFUS1ONTournamentControllerMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POWERAFUS1ONTournamentControllerMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00006518 File Offset: 0x00004718
		public POWERAFUS1ONTournamentControllerMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
