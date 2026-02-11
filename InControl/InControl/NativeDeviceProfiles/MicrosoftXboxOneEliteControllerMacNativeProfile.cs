using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000D1 RID: 209
	public class MicrosoftXboxOneEliteControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x06000C55 RID: 3157 RVA: 0x00033DAC File Offset: 0x00031FAC
		// Note: this type is marked as 'beforefieldinit'.
		static MicrosoftXboxOneEliteControllerMacNativeProfile()
		{
			Il2CppClassPointerStore<MicrosoftXboxOneEliteControllerMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "MicrosoftXboxOneEliteControllerMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MicrosoftXboxOneEliteControllerMacNativeProfile>.NativeClassPtr);
			MicrosoftXboxOneEliteControllerMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MicrosoftXboxOneEliteControllerMacNativeProfile>.NativeClassPtr, 100664975);
			MicrosoftXboxOneEliteControllerMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MicrosoftXboxOneEliteControllerMacNativeProfile>.NativeClassPtr, 100664976);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00033E04 File Offset: 0x00032004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793579, XrefRangeEnd = 793596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MicrosoftXboxOneEliteControllerMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00033E40 File Offset: 0x00032040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MicrosoftXboxOneEliteControllerMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MicrosoftXboxOneEliteControllerMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MicrosoftXboxOneEliteControllerMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0000647F File Offset: 0x0000467F
		public MicrosoftXboxOneEliteControllerMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
