using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000C4 RID: 196
	public class MadCatzSF4FightStickRound2TEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000C21 RID: 3105 RVA: 0x0003331C File Offset: 0x0003151C
		// Note: this type is marked as 'beforefieldinit'.
		static MadCatzSF4FightStickRound2TEMacNativeProfile()
		{
			Il2CppClassPointerStore<MadCatzSF4FightStickRound2TEMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "MadCatzSF4FightStickRound2TEMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MadCatzSF4FightStickRound2TEMacNativeProfile>.NativeClassPtr);
			MadCatzSF4FightStickRound2TEMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MadCatzSF4FightStickRound2TEMacNativeProfile>.NativeClassPtr, 100664949);
			MadCatzSF4FightStickRound2TEMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MadCatzSF4FightStickRound2TEMacNativeProfile>.NativeClassPtr, 100664950);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00033374 File Offset: 0x00031574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793321, XrefRangeEnd = 793335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MadCatzSF4FightStickRound2TEMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x000333B0 File Offset: 0x000315B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MadCatzSF4FightStickRound2TEMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MadCatzSF4FightStickRound2TEMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MadCatzSF4FightStickRound2TEMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0000640A File Offset: 0x0000460A
		public MadCatzSF4FightStickRound2TEMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
