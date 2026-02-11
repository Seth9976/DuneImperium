using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200018F RID: 399
	public class NVidiaShield2017NVidiaShieldUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F72 RID: 3954 RVA: 0x0003E374 File Offset: 0x0003C574
		// Note: this type is marked as 'beforefieldinit'.
		static NVidiaShield2017NVidiaShieldUnityProfile()
		{
			Il2CppClassPointerStore<NVidiaShield2017NVidiaShieldUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NVidiaShield2017NVidiaShieldUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NVidiaShield2017NVidiaShieldUnityProfile>.NativeClassPtr);
			NVidiaShield2017NVidiaShieldUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NVidiaShield2017NVidiaShieldUnityProfile>.NativeClassPtr, 100665392);
			NVidiaShield2017NVidiaShieldUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NVidiaShield2017NVidiaShieldUnityProfile>.NativeClassPtr, 100665393);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x0003E3CC File Offset: 0x0003C5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 825840, XrefRangeEnd = 826008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NVidiaShield2017NVidiaShieldUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0003E408 File Offset: 0x0003C608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 826008, XrefRangeEnd = 826012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NVidiaShield2017NVidiaShieldUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NVidiaShield2017NVidiaShieldUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NVidiaShield2017NVidiaShieldUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00006B2D File Offset: 0x00004D2D
		public NVidiaShield2017NVidiaShieldUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
