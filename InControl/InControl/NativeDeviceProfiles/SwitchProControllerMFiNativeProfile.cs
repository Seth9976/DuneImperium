using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000121 RID: 289
	public class SwitchProControllerMFiNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D95 RID: 3477 RVA: 0x00037EAC File Offset: 0x000360AC
		// Note: this type is marked as 'beforefieldinit'.
		static SwitchProControllerMFiNativeProfile()
		{
			Il2CppClassPointerStore<SwitchProControllerMFiNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "SwitchProControllerMFiNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchProControllerMFiNativeProfile>.NativeClassPtr);
			SwitchProControllerMFiNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerMFiNativeProfile>.NativeClassPtr, 100665135);
			SwitchProControllerMFiNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerMFiNativeProfile>.NativeClassPtr, 100665136);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00037F04 File Offset: 0x00036104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801762, XrefRangeEnd = 802040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SwitchProControllerMFiNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00037F40 File Offset: 0x00036140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802040, XrefRangeEnd = 802044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SwitchProControllerMFiNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwitchProControllerMFiNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwitchProControllerMFiNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0000674F File Offset: 0x0000494F
		public SwitchProControllerMFiNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
