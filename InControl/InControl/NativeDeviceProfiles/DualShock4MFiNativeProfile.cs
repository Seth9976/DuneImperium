using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000120 RID: 288
	public class DualShock4MFiNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D91 RID: 3473 RVA: 0x00037DDC File Offset: 0x00035FDC
		// Note: this type is marked as 'beforefieldinit'.
		static DualShock4MFiNativeProfile()
		{
			Il2CppClassPointerStore<DualShock4MFiNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "DualShock4MFiNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualShock4MFiNativeProfile>.NativeClassPtr);
			DualShock4MFiNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4MFiNativeProfile>.NativeClassPtr, 100665133);
			DualShock4MFiNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4MFiNativeProfile>.NativeClassPtr, 100665134);
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00037E34 File Offset: 0x00036034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801480, XrefRangeEnd = 801758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DualShock4MFiNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00037E70 File Offset: 0x00036070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801758, XrefRangeEnd = 801762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DualShock4MFiNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualShock4MFiNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualShock4MFiNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00006746 File Offset: 0x00004946
		public DualShock4MFiNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
