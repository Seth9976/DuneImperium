using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200018C RID: 396
	public class NintendoSwitchProAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F66 RID: 3942 RVA: 0x0003E104 File Offset: 0x0003C304
		// Note: this type is marked as 'beforefieldinit'.
		static NintendoSwitchProAndroidUnityProfile()
		{
			Il2CppClassPointerStore<NintendoSwitchProAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NintendoSwitchProAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchProAndroidUnityProfile>.NativeClassPtr);
			NintendoSwitchProAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchProAndroidUnityProfile>.NativeClassPtr, 100665386);
			NintendoSwitchProAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchProAndroidUnityProfile>.NativeClassPtr, 100665387);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x0003E15C File Offset: 0x0003C35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 825309, XrefRangeEnd = 825486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NintendoSwitchProAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x0003E198 File Offset: 0x0003C398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 825486, XrefRangeEnd = 825490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NintendoSwitchProAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchProAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchProAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00006B12 File Offset: 0x00004D12
		public NintendoSwitchProAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
