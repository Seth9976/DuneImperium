using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001F6 RID: 502
	public class NintendoSwitchProWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600110E RID: 4366 RVA: 0x00043724 File Offset: 0x00041924
		// Note: this type is marked as 'beforefieldinit'.
		static NintendoSwitchProWindowsUnityProfile()
		{
			Il2CppClassPointerStore<NintendoSwitchProWindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NintendoSwitchProWindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchProWindowsUnityProfile>.NativeClassPtr);
			NintendoSwitchProWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchProWindowsUnityProfile>.NativeClassPtr, 100665598);
			NintendoSwitchProWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchProWindowsUnityProfile>.NativeClassPtr, 100665599);
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x0004377C File Offset: 0x0004197C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846184, XrefRangeEnd = 846433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NintendoSwitchProWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x000437B8 File Offset: 0x000419B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846433, XrefRangeEnd = 846437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NintendoSwitchProWindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchProWindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchProWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00006ECC File Offset: 0x000050CC
		public NintendoSwitchProWindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
