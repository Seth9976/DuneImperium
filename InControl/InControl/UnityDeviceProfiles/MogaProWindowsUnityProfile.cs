using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001F3 RID: 499
	public class MogaProWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x06001102 RID: 4354 RVA: 0x000434B4 File Offset: 0x000416B4
		// Note: this type is marked as 'beforefieldinit'.
		static MogaProWindowsUnityProfile()
		{
			Il2CppClassPointerStore<MogaProWindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "MogaProWindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MogaProWindowsUnityProfile>.NativeClassPtr);
			MogaProWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MogaProWindowsUnityProfile>.NativeClassPtr, 100665592);
			MogaProWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MogaProWindowsUnityProfile>.NativeClassPtr, 100665593);
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x0004350C File Offset: 0x0004170C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 845641, XrefRangeEnd = 845818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MogaProWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00043548 File Offset: 0x00041748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 845818, XrefRangeEnd = 845822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MogaProWindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MogaProWindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MogaProWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x00006EB1 File Offset: 0x000050B1
		public MogaProWindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
