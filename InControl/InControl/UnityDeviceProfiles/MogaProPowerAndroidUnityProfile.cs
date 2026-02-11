using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000188 RID: 392
	public class MogaProPowerAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F56 RID: 3926 RVA: 0x0003DDC4 File Offset: 0x0003BFC4
		// Note: this type is marked as 'beforefieldinit'.
		static MogaProPowerAndroidUnityProfile()
		{
			Il2CppClassPointerStore<MogaProPowerAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "MogaProPowerAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MogaProPowerAndroidUnityProfile>.NativeClassPtr);
			MogaProPowerAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MogaProPowerAndroidUnityProfile>.NativeClassPtr, 100665378);
			MogaProPowerAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MogaProPowerAndroidUnityProfile>.NativeClassPtr, 100665379);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0003DE1C File Offset: 0x0003C01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 824709, XrefRangeEnd = 824869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MogaProPowerAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0003DE58 File Offset: 0x0003C058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 824869, XrefRangeEnd = 824873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MogaProPowerAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MogaProPowerAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MogaProPowerAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00006AEE File Offset: 0x00004CEE
		public MogaProPowerAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
