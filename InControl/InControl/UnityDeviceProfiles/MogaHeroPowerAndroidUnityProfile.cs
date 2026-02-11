using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000186 RID: 390
	public class MogaHeroPowerAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F4E RID: 3918 RVA: 0x0003DC24 File Offset: 0x0003BE24
		// Note: this type is marked as 'beforefieldinit'.
		static MogaHeroPowerAndroidUnityProfile()
		{
			Il2CppClassPointerStore<MogaHeroPowerAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "MogaHeroPowerAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MogaHeroPowerAndroidUnityProfile>.NativeClassPtr);
			MogaHeroPowerAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MogaHeroPowerAndroidUnityProfile>.NativeClassPtr, 100665374);
			MogaHeroPowerAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MogaHeroPowerAndroidUnityProfile>.NativeClassPtr, 100665375);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0003DC7C File Offset: 0x0003BE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 824360, XrefRangeEnd = 824520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MogaHeroPowerAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0003DCB8 File Offset: 0x0003BEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 824520, XrefRangeEnd = 824524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MogaHeroPowerAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MogaHeroPowerAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MogaHeroPowerAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00006ADC File Offset: 0x00004CDC
		public MogaHeroPowerAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
