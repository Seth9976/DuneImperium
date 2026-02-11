using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200020A RID: 522
	public class XTR_G2_WindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600115E RID: 4446 RVA: 0x00044764 File Offset: 0x00042964
		// Note: this type is marked as 'beforefieldinit'.
		static XTR_G2_WindowsUnityProfile()
		{
			Il2CppClassPointerStore<XTR_G2_WindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "XTR_G2_WindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XTR_G2_WindowsUnityProfile>.NativeClassPtr);
			XTR_G2_WindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTR_G2_WindowsUnityProfile>.NativeClassPtr, 100665638);
			XTR_G2_WindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTR_G2_WindowsUnityProfile>.NativeClassPtr, 100665639);
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x000447BC File Offset: 0x000429BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850257, XrefRangeEnd = 850279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XTR_G2_WindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x000447F8 File Offset: 0x000429F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850279, XrefRangeEnd = 850283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XTR_G2_WindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XTR_G2_WindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTR_G2_WindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00006F80 File Offset: 0x00005180
		public XTR_G2_WindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
