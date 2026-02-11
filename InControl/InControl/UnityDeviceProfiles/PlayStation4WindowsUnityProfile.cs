using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001FE RID: 510
	public class PlayStation4WindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600112E RID: 4398 RVA: 0x00043DA4 File Offset: 0x00041FA4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayStation4WindowsUnityProfile()
		{
			Il2CppClassPointerStore<PlayStation4WindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "PlayStation4WindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayStation4WindowsUnityProfile>.NativeClassPtr);
			PlayStation4WindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation4WindowsUnityProfile>.NativeClassPtr, 100665614);
			PlayStation4WindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation4WindowsUnityProfile>.NativeClassPtr, 100665615);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00043DFC File Offset: 0x00041FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 847841, XrefRangeEnd = 848047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayStation4WindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00043E38 File Offset: 0x00042038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848047, XrefRangeEnd = 848051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayStation4WindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayStation4WindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayStation4WindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x00006F14 File Offset: 0x00005114
		public PlayStation4WindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
