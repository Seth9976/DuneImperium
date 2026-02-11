using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001C5 RID: 453
	public class XTR55_G2_MacUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600104A RID: 4170 RVA: 0x00040F54 File Offset: 0x0003F154
		// Note: this type is marked as 'beforefieldinit'.
		static XTR55_G2_MacUnityProfile()
		{
			Il2CppClassPointerStore<XTR55_G2_MacUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "XTR55_G2_MacUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XTR55_G2_MacUnityProfile>.NativeClassPtr);
			XTR55_G2_MacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTR55_G2_MacUnityProfile>.NativeClassPtr, 100665500);
			XTR55_G2_MacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTR55_G2_MacUnityProfile>.NativeClassPtr, 100665501);
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00040FAC File Offset: 0x0003F1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 835848, XrefRangeEnd = 835870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XTR55_G2_MacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00040FE8 File Offset: 0x0003F1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 835870, XrefRangeEnd = 835874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XTR55_G2_MacUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XTR55_G2_MacUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTR55_G2_MacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00006D13 File Offset: 0x00004F13
		public XTR55_G2_MacUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
