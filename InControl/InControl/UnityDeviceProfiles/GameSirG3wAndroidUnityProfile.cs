using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200017A RID: 378
	public class GameSirG3wAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F1E RID: 3870 RVA: 0x0003D264 File Offset: 0x0003B464
		// Note: this type is marked as 'beforefieldinit'.
		static GameSirG3wAndroidUnityProfile()
		{
			Il2CppClassPointerStore<GameSirG3wAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "GameSirG3wAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSirG3wAndroidUnityProfile>.NativeClassPtr);
			GameSirG3wAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSirG3wAndroidUnityProfile>.NativeClassPtr, 100665350);
			GameSirG3wAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSirG3wAndroidUnityProfile>.NativeClassPtr, 100665351);
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0003D2BC File Offset: 0x0003B4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822217, XrefRangeEnd = 822394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameSirG3wAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0003D2F8 File Offset: 0x0003B4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 822394, XrefRangeEnd = 822398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSirG3wAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSirG3wAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSirG3wAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00006A70 File Offset: 0x00004C70
		public GameSirG3wAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
