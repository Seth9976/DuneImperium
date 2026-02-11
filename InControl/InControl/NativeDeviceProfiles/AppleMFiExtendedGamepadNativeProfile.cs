using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200011D RID: 285
	public class AppleMFiExtendedGamepadNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D85 RID: 3461 RVA: 0x00037B6C File Offset: 0x00035D6C
		// Note: this type is marked as 'beforefieldinit'.
		static AppleMFiExtendedGamepadNativeProfile()
		{
			Il2CppClassPointerStore<AppleMFiExtendedGamepadNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "AppleMFiExtendedGamepadNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppleMFiExtendedGamepadNativeProfile>.NativeClassPtr);
			AppleMFiExtendedGamepadNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleMFiExtendedGamepadNativeProfile>.NativeClassPtr, 100665127);
			AppleMFiExtendedGamepadNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleMFiExtendedGamepadNativeProfile>.NativeClassPtr, 100665128);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00037BC4 File Offset: 0x00035DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800787, XrefRangeEnd = 801065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppleMFiExtendedGamepadNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00037C00 File Offset: 0x00035E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801065, XrefRangeEnd = 801069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppleMFiExtendedGamepadNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppleMFiExtendedGamepadNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleMFiExtendedGamepadNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0000672B File Offset: 0x0000492B
		public AppleMFiExtendedGamepadNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
