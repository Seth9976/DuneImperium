using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000182 RID: 386
	public class IpegaPG9055AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F3E RID: 3902 RVA: 0x0003D8E4 File Offset: 0x0003BAE4
		// Note: this type is marked as 'beforefieldinit'.
		static IpegaPG9055AndroidUnityProfile()
		{
			Il2CppClassPointerStore<IpegaPG9055AndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "IpegaPG9055AndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IpegaPG9055AndroidUnityProfile>.NativeClassPtr);
			IpegaPG9055AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IpegaPG9055AndroidUnityProfile>.NativeClassPtr, 100665366);
			IpegaPG9055AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IpegaPG9055AndroidUnityProfile>.NativeClassPtr, 100665367);
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x0003D93C File Offset: 0x0003BB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 823638, XrefRangeEnd = 823815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IpegaPG9055AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x0003D978 File Offset: 0x0003BB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 823815, XrefRangeEnd = 823819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IpegaPG9055AndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IpegaPG9055AndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IpegaPG9055AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00006AB8 File Offset: 0x00004CB8
		public IpegaPG9055AndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
