using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200017D RID: 381
	public class GreenThrottleAtlasAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F2A RID: 3882 RVA: 0x0003D4D4 File Offset: 0x0003B6D4
		// Note: this type is marked as 'beforefieldinit'.
		static GreenThrottleAtlasAndroidUnityProfile()
		{
			Il2CppClassPointerStore<GreenThrottleAtlasAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "GreenThrottleAtlasAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreenThrottleAtlasAndroidUnityProfile>.NativeClassPtr);
			GreenThrottleAtlasAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreenThrottleAtlasAndroidUnityProfile>.NativeClassPtr, 100665356);
			GreenThrottleAtlasAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreenThrottleAtlasAndroidUnityProfile>.NativeClassPtr, 100665357);
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0003D52C File Offset: 0x0003B72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822760, XrefRangeEnd = 822928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GreenThrottleAtlasAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0003D568 File Offset: 0x0003B768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822928, XrefRangeEnd = 822932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GreenThrottleAtlasAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreenThrottleAtlasAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreenThrottleAtlasAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00006A8B File Offset: 0x00004C8B
		public GreenThrottleAtlasAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
