using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000118 RID: 280
	public class XboxOneSMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D71 RID: 3441 RVA: 0x0003775C File Offset: 0x0003595C
		// Note: this type is marked as 'beforefieldinit'.
		static XboxOneSMacNativeProfile()
		{
			Il2CppClassPointerStore<XboxOneSMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "XboxOneSMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxOneSMacNativeProfile>.NativeClassPtr);
			XboxOneSMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneSMacNativeProfile>.NativeClassPtr, 100665117);
			XboxOneSMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneSMacNativeProfile>.NativeClassPtr, 100665118);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x000377B4 File Offset: 0x000359B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800034, XrefRangeEnd = 800288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XboxOneSMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x000377F0 File Offset: 0x000359F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800288, XrefRangeEnd = 800292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxOneSMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxOneSMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneSMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x000066FE File Offset: 0x000048FE
		public XboxOneSMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
