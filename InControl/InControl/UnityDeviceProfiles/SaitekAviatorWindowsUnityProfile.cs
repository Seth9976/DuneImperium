using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001FF RID: 511
	public class SaitekAviatorWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x06001132 RID: 4402 RVA: 0x00043E74 File Offset: 0x00042074
		// Note: this type is marked as 'beforefieldinit'.
		static SaitekAviatorWindowsUnityProfile()
		{
			Il2CppClassPointerStore<SaitekAviatorWindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "SaitekAviatorWindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaitekAviatorWindowsUnityProfile>.NativeClassPtr);
			SaitekAviatorWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaitekAviatorWindowsUnityProfile>.NativeClassPtr, 100665616);
			SaitekAviatorWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaitekAviatorWindowsUnityProfile>.NativeClassPtr, 100665617);
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00043ECC File Offset: 0x000420CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848051, XrefRangeEnd = 848264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaitekAviatorWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00043F08 File Offset: 0x00042108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848264, XrefRangeEnd = 848268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaitekAviatorWindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaitekAviatorWindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaitekAviatorWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00006F1D File Offset: 0x0000511D
		public SaitekAviatorWindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
