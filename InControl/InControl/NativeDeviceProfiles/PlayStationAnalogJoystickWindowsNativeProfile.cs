using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000148 RID: 328
	public class PlayStationAnalogJoystickWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000E56 RID: 3670 RVA: 0x0003A9C4 File Offset: 0x00038BC4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayStationAnalogJoystickWindowsNativeProfile()
		{
			Il2CppClassPointerStore<PlayStationAnalogJoystickWindowsNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "PlayStationAnalogJoystickWindowsNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayStationAnalogJoystickWindowsNativeProfile>.NativeClassPtr);
			PlayStationAnalogJoystickWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStationAnalogJoystickWindowsNativeProfile>.NativeClassPtr, 100665250);
			PlayStationAnalogJoystickWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStationAnalogJoystickWindowsNativeProfile>.NativeClassPtr, 100665251);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0003AA1C File Offset: 0x00038C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 812357, XrefRangeEnd = 812634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayStationAnalogJoystickWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0003AA58 File Offset: 0x00038C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 812634, XrefRangeEnd = 812638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayStationAnalogJoystickWindowsNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayStationAnalogJoystickWindowsNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayStationAnalogJoystickWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x000068AE File Offset: 0x00004AAE
		public PlayStationAnalogJoystickWindowsNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
