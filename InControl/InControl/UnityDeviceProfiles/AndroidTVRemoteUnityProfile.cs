using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000165 RID: 357
	public class AndroidTVRemoteUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000ECA RID: 3786 RVA: 0x0003C154 File Offset: 0x0003A354
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidTVRemoteUnityProfile()
		{
			Il2CppClassPointerStore<AndroidTVRemoteUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "AndroidTVRemoteUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidTVRemoteUnityProfile>.NativeClassPtr);
			AndroidTVRemoteUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTVRemoteUnityProfile>.NativeClassPtr, 100665308);
			AndroidTVRemoteUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTVRemoteUnityProfile>.NativeClassPtr, 100665309);
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x0003C1AC File Offset: 0x0003A3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818654, XrefRangeEnd = 818725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidTVRemoteUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x0003C1E8 File Offset: 0x0003A3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818725, XrefRangeEnd = 818729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidTVRemoteUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidTVRemoteUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTVRemoteUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x000069B3 File Offset: 0x00004BB3
		public AndroidTVRemoteUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
