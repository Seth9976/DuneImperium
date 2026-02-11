using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001C6 RID: 454
	public class XTR_G2_MacUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600104E RID: 4174 RVA: 0x00041024 File Offset: 0x0003F224
		// Note: this type is marked as 'beforefieldinit'.
		static XTR_G2_MacUnityProfile()
		{
			Il2CppClassPointerStore<XTR_G2_MacUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "XTR_G2_MacUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XTR_G2_MacUnityProfile>.NativeClassPtr);
			XTR_G2_MacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTR_G2_MacUnityProfile>.NativeClassPtr, 100665502);
			XTR_G2_MacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTR_G2_MacUnityProfile>.NativeClassPtr, 100665503);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0004107C File Offset: 0x0003F27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 835874, XrefRangeEnd = 835896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XTR_G2_MacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x000410B8 File Offset: 0x0003F2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 835896, XrefRangeEnd = 835900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XTR_G2_MacUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XTR_G2_MacUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTR_G2_MacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00006D1C File Offset: 0x00004F1C
		public XTR_G2_MacUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
