using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001DA RID: 474
	public class NintendoSwitchProWindowsChromeUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600109E RID: 4254 RVA: 0x00042064 File Offset: 0x00040264
		// Note: this type is marked as 'beforefieldinit'.
		static NintendoSwitchProWindowsChromeUnityProfile()
		{
			Il2CppClassPointerStore<NintendoSwitchProWindowsChromeUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NintendoSwitchProWindowsChromeUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchProWindowsChromeUnityProfile>.NativeClassPtr);
			NintendoSwitchProWindowsChromeUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchProWindowsChromeUnityProfile>.NativeClassPtr, 100665542);
			NintendoSwitchProWindowsChromeUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchProWindowsChromeUnityProfile>.NativeClassPtr, 100665543);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x000420BC File Offset: 0x000402BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 840422, XrefRangeEnd = 840714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NintendoSwitchProWindowsChromeUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x000420F8 File Offset: 0x000402F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 840714, XrefRangeEnd = 840718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NintendoSwitchProWindowsChromeUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchProWindowsChromeUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchProWindowsChromeUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00006DD0 File Offset: 0x00004FD0
		public NintendoSwitchProWindowsChromeUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
