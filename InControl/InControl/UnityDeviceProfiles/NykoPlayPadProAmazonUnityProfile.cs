using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000161 RID: 353
	public class NykoPlayPadProAmazonUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000EBA RID: 3770 RVA: 0x0003BE14 File Offset: 0x0003A014
		// Note: this type is marked as 'beforefieldinit'.
		static NykoPlayPadProAmazonUnityProfile()
		{
			Il2CppClassPointerStore<NykoPlayPadProAmazonUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NykoPlayPadProAmazonUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NykoPlayPadProAmazonUnityProfile>.NativeClassPtr);
			NykoPlayPadProAmazonUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NykoPlayPadProAmazonUnityProfile>.NativeClassPtr, 100665300);
			NykoPlayPadProAmazonUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NykoPlayPadProAmazonUnityProfile>.NativeClassPtr, 100665301);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0003BE6C File Offset: 0x0003A06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818050, XrefRangeEnd = 818215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NykoPlayPadProAmazonUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x0003BEA8 File Offset: 0x0003A0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818215, XrefRangeEnd = 818219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NykoPlayPadProAmazonUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NykoPlayPadProAmazonUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NykoPlayPadProAmazonUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x0000698F File Offset: 0x00004B8F
		public NykoPlayPadProAmazonUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
