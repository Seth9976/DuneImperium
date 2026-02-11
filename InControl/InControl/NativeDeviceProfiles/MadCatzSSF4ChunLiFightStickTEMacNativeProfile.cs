using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000C8 RID: 200
	public class MadCatzSSF4ChunLiFightStickTEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000C31 RID: 3121 RVA: 0x0003365C File Offset: 0x0003185C
		// Note: this type is marked as 'beforefieldinit'.
		static MadCatzSSF4ChunLiFightStickTEMacNativeProfile()
		{
			Il2CppClassPointerStore<MadCatzSSF4ChunLiFightStickTEMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "MadCatzSSF4ChunLiFightStickTEMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MadCatzSSF4ChunLiFightStickTEMacNativeProfile>.NativeClassPtr);
			MadCatzSSF4ChunLiFightStickTEMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MadCatzSSF4ChunLiFightStickTEMacNativeProfile>.NativeClassPtr, 100664957);
			MadCatzSSF4ChunLiFightStickTEMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MadCatzSSF4ChunLiFightStickTEMacNativeProfile>.NativeClassPtr, 100664958);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x000336B4 File Offset: 0x000318B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793377, XrefRangeEnd = 793391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MadCatzSSF4ChunLiFightStickTEMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x000336F0 File Offset: 0x000318F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MadCatzSSF4ChunLiFightStickTEMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MadCatzSSF4ChunLiFightStickTEMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MadCatzSSF4ChunLiFightStickTEMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0000642E File Offset: 0x0000462E
		public MadCatzSSF4ChunLiFightStickTEMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
