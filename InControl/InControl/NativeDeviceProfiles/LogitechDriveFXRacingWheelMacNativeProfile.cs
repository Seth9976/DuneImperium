using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000A9 RID: 169
	public class LogitechDriveFXRacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000BB5 RID: 2997 RVA: 0x00031D2C File Offset: 0x0002FF2C
		// Note: this type is marked as 'beforefieldinit'.
		static LogitechDriveFXRacingWheelMacNativeProfile()
		{
			Il2CppClassPointerStore<LogitechDriveFXRacingWheelMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "LogitechDriveFXRacingWheelMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogitechDriveFXRacingWheelMacNativeProfile>.NativeClassPtr);
			LogitechDriveFXRacingWheelMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogitechDriveFXRacingWheelMacNativeProfile>.NativeClassPtr, 100664895);
			LogitechDriveFXRacingWheelMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogitechDriveFXRacingWheelMacNativeProfile>.NativeClassPtr, 100664896);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00031D84 File Offset: 0x0002FF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792938, XrefRangeEnd = 792952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LogitechDriveFXRacingWheelMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00031DC0 File Offset: 0x0002FFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogitechDriveFXRacingWheelMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogitechDriveFXRacingWheelMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogitechDriveFXRacingWheelMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00006317 File Offset: 0x00004517
		public LogitechDriveFXRacingWheelMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
