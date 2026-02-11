using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000167 RID: 359
	public class BeboncoolDA015CAAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000ED2 RID: 3794 RVA: 0x0003C2F4 File Offset: 0x0003A4F4
		// Note: this type is marked as 'beforefieldinit'.
		static BeboncoolDA015CAAndroidUnityProfile()
		{
			Il2CppClassPointerStore<BeboncoolDA015CAAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "BeboncoolDA015CAAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeboncoolDA015CAAndroidUnityProfile>.NativeClassPtr);
			BeboncoolDA015CAAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeboncoolDA015CAAndroidUnityProfile>.NativeClassPtr, 100665312);
			BeboncoolDA015CAAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeboncoolDA015CAAndroidUnityProfile>.NativeClassPtr, 100665313);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0003C34C File Offset: 0x0003A54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 818916, XrefRangeEnd = 819093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BeboncoolDA015CAAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0003C388 File Offset: 0x0003A588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819093, XrefRangeEnd = 819097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeboncoolDA015CAAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeboncoolDA015CAAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeboncoolDA015CAAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x000069C5 File Offset: 0x00004BC5
		public BeboncoolDA015CAAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
