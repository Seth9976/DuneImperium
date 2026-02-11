using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200015B RID: 347
	public class AndroidTVAmazonUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000EA2 RID: 3746 RVA: 0x0003B934 File Offset: 0x00039B34
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidTVAmazonUnityProfile()
		{
			Il2CppClassPointerStore<AndroidTVAmazonUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "AndroidTVAmazonUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidTVAmazonUnityProfile>.NativeClassPtr);
			AndroidTVAmazonUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTVAmazonUnityProfile>.NativeClassPtr, 100665288);
			AndroidTVAmazonUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTVAmazonUnityProfile>.NativeClassPtr, 100665289);
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0003B98C File Offset: 0x00039B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817052, XrefRangeEnd = 817220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidTVAmazonUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x0003B9C8 File Offset: 0x00039BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817220, XrefRangeEnd = 817224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidTVAmazonUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidTVAmazonUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTVAmazonUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00006959 File Offset: 0x00004B59
		public AndroidTVAmazonUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
