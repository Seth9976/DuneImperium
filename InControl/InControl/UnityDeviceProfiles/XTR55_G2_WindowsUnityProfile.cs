using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000209 RID: 521
	public class XTR55_G2_WindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600115A RID: 4442 RVA: 0x00044694 File Offset: 0x00042894
		// Note: this type is marked as 'beforefieldinit'.
		static XTR55_G2_WindowsUnityProfile()
		{
			Il2CppClassPointerStore<XTR55_G2_WindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "XTR55_G2_WindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XTR55_G2_WindowsUnityProfile>.NativeClassPtr);
			XTR55_G2_WindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTR55_G2_WindowsUnityProfile>.NativeClassPtr, 100665636);
			XTR55_G2_WindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTR55_G2_WindowsUnityProfile>.NativeClassPtr, 100665637);
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x000446EC File Offset: 0x000428EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850231, XrefRangeEnd = 850253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XTR55_G2_WindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00044728 File Offset: 0x00042928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850253, XrefRangeEnd = 850257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XTR55_G2_WindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XTR55_G2_WindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTR55_G2_WindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00006F77 File Offset: 0x00005177
		public XTR55_G2_WindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
