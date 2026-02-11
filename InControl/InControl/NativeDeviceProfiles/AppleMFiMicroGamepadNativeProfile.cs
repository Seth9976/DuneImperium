using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200011E RID: 286
	public class AppleMFiMicroGamepadNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D89 RID: 3465 RVA: 0x00037C3C File Offset: 0x00035E3C
		// Note: this type is marked as 'beforefieldinit'.
		static AppleMFiMicroGamepadNativeProfile()
		{
			Il2CppClassPointerStore<AppleMFiMicroGamepadNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "AppleMFiMicroGamepadNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppleMFiMicroGamepadNativeProfile>.NativeClassPtr);
			AppleMFiMicroGamepadNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleMFiMicroGamepadNativeProfile>.NativeClassPtr, 100665129);
			AppleMFiMicroGamepadNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleMFiMicroGamepadNativeProfile>.NativeClassPtr, 100665130);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00037C94 File Offset: 0x00035E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801069, XrefRangeEnd = 801194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppleMFiMicroGamepadNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00037CD0 File Offset: 0x00035ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801194, XrefRangeEnd = 801198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppleMFiMicroGamepadNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppleMFiMicroGamepadNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleMFiMicroGamepadNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00006734 File Offset: 0x00004934
		public AppleMFiMicroGamepadNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
