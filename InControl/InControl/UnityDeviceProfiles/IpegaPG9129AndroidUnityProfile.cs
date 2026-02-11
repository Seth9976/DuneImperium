using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000184 RID: 388
	public class IpegaPG9129AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F46 RID: 3910 RVA: 0x0003DA84 File Offset: 0x0003BC84
		// Note: this type is marked as 'beforefieldinit'.
		static IpegaPG9129AndroidUnityProfile()
		{
			Il2CppClassPointerStore<IpegaPG9129AndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "IpegaPG9129AndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IpegaPG9129AndroidUnityProfile>.NativeClassPtr);
			IpegaPG9129AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IpegaPG9129AndroidUnityProfile>.NativeClassPtr, 100665370);
			IpegaPG9129AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IpegaPG9129AndroidUnityProfile>.NativeClassPtr, 100665371);
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0003DADC File Offset: 0x0003BCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 824000, XrefRangeEnd = 824184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IpegaPG9129AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0003DB18 File Offset: 0x0003BD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 824184, XrefRangeEnd = 824188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IpegaPG9129AndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IpegaPG9129AndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IpegaPG9129AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00006ACA File Offset: 0x00004CCA
		public IpegaPG9129AndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
