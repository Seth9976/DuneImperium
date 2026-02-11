using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000189 RID: 393
	public class MogaXP5XPlusAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F5A RID: 3930 RVA: 0x0003DE94 File Offset: 0x0003C094
		// Note: this type is marked as 'beforefieldinit'.
		static MogaXP5XPlusAndroidUnityProfile()
		{
			Il2CppClassPointerStore<MogaXP5XPlusAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "MogaXP5XPlusAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MogaXP5XPlusAndroidUnityProfile>.NativeClassPtr);
			MogaXP5XPlusAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MogaXP5XPlusAndroidUnityProfile>.NativeClassPtr, 100665380);
			MogaXP5XPlusAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MogaXP5XPlusAndroidUnityProfile>.NativeClassPtr, 100665381);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0003DEEC File Offset: 0x0003C0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 824873, XrefRangeEnd = 825058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MogaXP5XPlusAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x0003DF28 File Offset: 0x0003C128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 825058, XrefRangeEnd = 825062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MogaXP5XPlusAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MogaXP5XPlusAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MogaXP5XPlusAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00006AF7 File Offset: 0x00004CF7
		public MogaXP5XPlusAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
