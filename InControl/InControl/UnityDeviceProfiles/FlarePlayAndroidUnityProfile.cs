using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000178 RID: 376
	public class FlarePlayAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F16 RID: 3862 RVA: 0x0003D0C4 File Offset: 0x0003B2C4
		// Note: this type is marked as 'beforefieldinit'.
		static FlarePlayAndroidUnityProfile()
		{
			Il2CppClassPointerStore<FlarePlayAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "FlarePlayAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlarePlayAndroidUnityProfile>.NativeClassPtr);
			FlarePlayAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlarePlayAndroidUnityProfile>.NativeClassPtr, 100665346);
			FlarePlayAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlarePlayAndroidUnityProfile>.NativeClassPtr, 100665347);
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0003D11C File Offset: 0x0003B31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 821874, XrefRangeEnd = 822032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlarePlayAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0003D158 File Offset: 0x0003B358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822032, XrefRangeEnd = 822036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlarePlayAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlarePlayAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlarePlayAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00006A5E File Offset: 0x00004C5E
		public FlarePlayAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
