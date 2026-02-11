using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001D5 RID: 469
	public class Xbox360MacFirefoxUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600108A RID: 4234 RVA: 0x00041C54 File Offset: 0x0003FE54
		// Note: this type is marked as 'beforefieldinit'.
		static Xbox360MacFirefoxUnityProfile()
		{
			Il2CppClassPointerStore<Xbox360MacFirefoxUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "Xbox360MacFirefoxUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Xbox360MacFirefoxUnityProfile>.NativeClassPtr);
			Xbox360MacFirefoxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Xbox360MacFirefoxUnityProfile>.NativeClassPtr, 100665532);
			Xbox360MacFirefoxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Xbox360MacFirefoxUnityProfile>.NativeClassPtr, 100665533);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00041CAC File Offset: 0x0003FEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 839041, XrefRangeEnd = 839306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Xbox360MacFirefoxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x00041CE8 File Offset: 0x0003FEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 839306, XrefRangeEnd = 839310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Xbox360MacFirefoxUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Xbox360MacFirefoxUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Xbox360MacFirefoxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x00006DA3 File Offset: 0x00004FA3
		public Xbox360MacFirefoxUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
