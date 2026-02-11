using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000162 RID: 354
	public class PlayStation4AmazonUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000EBE RID: 3774 RVA: 0x0003BEE4 File Offset: 0x0003A0E4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayStation4AmazonUnityProfile()
		{
			Il2CppClassPointerStore<PlayStation4AmazonUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "PlayStation4AmazonUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayStation4AmazonUnityProfile>.NativeClassPtr);
			PlayStation4AmazonUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation4AmazonUnityProfile>.NativeClassPtr, 100665302);
			PlayStation4AmazonUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation4AmazonUnityProfile>.NativeClassPtr, 100665303);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x0003BF3C File Offset: 0x0003A13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818219, XrefRangeEnd = 818396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayStation4AmazonUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x0003BF78 File Offset: 0x0003A178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818396, XrefRangeEnd = 818400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayStation4AmazonUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayStation4AmazonUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayStation4AmazonUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00006998 File Offset: 0x00004B98
		public PlayStation4AmazonUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
