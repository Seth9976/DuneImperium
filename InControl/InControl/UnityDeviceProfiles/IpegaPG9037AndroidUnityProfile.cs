using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000181 RID: 385
	public class IpegaPG9037AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F3A RID: 3898 RVA: 0x0003D814 File Offset: 0x0003BA14
		// Note: this type is marked as 'beforefieldinit'.
		static IpegaPG9037AndroidUnityProfile()
		{
			Il2CppClassPointerStore<IpegaPG9037AndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "IpegaPG9037AndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IpegaPG9037AndroidUnityProfile>.NativeClassPtr);
			IpegaPG9037AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IpegaPG9037AndroidUnityProfile>.NativeClassPtr, 100665364);
			IpegaPG9037AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IpegaPG9037AndroidUnityProfile>.NativeClassPtr, 100665365);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x0003D86C File Offset: 0x0003BA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 823457, XrefRangeEnd = 823634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IpegaPG9037AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0003D8A8 File Offset: 0x0003BAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 823634, XrefRangeEnd = 823638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IpegaPG9037AndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IpegaPG9037AndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IpegaPG9037AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00006AAF File Offset: 0x00004CAF
		public IpegaPG9037AndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
