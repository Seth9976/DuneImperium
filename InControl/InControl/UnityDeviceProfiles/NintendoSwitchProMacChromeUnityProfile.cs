using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001D1 RID: 465
	public class NintendoSwitchProMacChromeUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600107A RID: 4218 RVA: 0x00041914 File Offset: 0x0003FB14
		// Note: this type is marked as 'beforefieldinit'.
		static NintendoSwitchProMacChromeUnityProfile()
		{
			Il2CppClassPointerStore<NintendoSwitchProMacChromeUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NintendoSwitchProMacChromeUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchProMacChromeUnityProfile>.NativeClassPtr);
			NintendoSwitchProMacChromeUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchProMacChromeUnityProfile>.NativeClassPtr, 100665524);
			NintendoSwitchProMacChromeUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchProMacChromeUnityProfile>.NativeClassPtr, 100665525);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0004196C File Offset: 0x0003FB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 837879, XrefRangeEnd = 838167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NintendoSwitchProMacChromeUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x000419A8 File Offset: 0x0003FBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838167, XrefRangeEnd = 838171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NintendoSwitchProMacChromeUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchProMacChromeUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchProMacChromeUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00006D7F File Offset: 0x00004F7F
		public NintendoSwitchProMacChromeUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
