using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000112 RID: 274
	public class PowerANintendoSwitchMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D59 RID: 3417 RVA: 0x0003727C File Offset: 0x0003547C
		// Note: this type is marked as 'beforefieldinit'.
		static PowerANintendoSwitchMacNativeProfile()
		{
			Il2CppClassPointerStore<PowerANintendoSwitchMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "PowerANintendoSwitchMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerANintendoSwitchMacNativeProfile>.NativeClassPtr);
			PowerANintendoSwitchMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerANintendoSwitchMacNativeProfile>.NativeClassPtr, 100665105);
			PowerANintendoSwitchMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerANintendoSwitchMacNativeProfile>.NativeClassPtr, 100665106);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x000372D4 File Offset: 0x000354D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798299, XrefRangeEnd = 798620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerANintendoSwitchMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00037310 File Offset: 0x00035510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798620, XrefRangeEnd = 798624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerANintendoSwitchMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerANintendoSwitchMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerANintendoSwitchMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x000066C8 File Offset: 0x000048C8
		public PowerANintendoSwitchMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
