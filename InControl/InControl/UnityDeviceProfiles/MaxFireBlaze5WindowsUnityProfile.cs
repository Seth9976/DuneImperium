using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001F2 RID: 498
	public class MaxFireBlaze5WindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x060010FE RID: 4350 RVA: 0x000433E4 File Offset: 0x000415E4
		// Note: this type is marked as 'beforefieldinit'.
		static MaxFireBlaze5WindowsUnityProfile()
		{
			Il2CppClassPointerStore<MaxFireBlaze5WindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "MaxFireBlaze5WindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaxFireBlaze5WindowsUnityProfile>.NativeClassPtr);
			MaxFireBlaze5WindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxFireBlaze5WindowsUnityProfile>.NativeClassPtr, 100665590);
			MaxFireBlaze5WindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxFireBlaze5WindowsUnityProfile>.NativeClassPtr, 100665591);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x0004343C File Offset: 0x0004163C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 845460, XrefRangeEnd = 845637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaxFireBlaze5WindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00043478 File Offset: 0x00041678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 845637, XrefRangeEnd = 845641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaxFireBlaze5WindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaxFireBlaze5WindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxFireBlaze5WindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00006EA8 File Offset: 0x000050A8
		public MaxFireBlaze5WindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
