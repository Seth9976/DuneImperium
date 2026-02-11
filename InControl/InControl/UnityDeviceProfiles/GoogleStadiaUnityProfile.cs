using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001CB RID: 459
	public class GoogleStadiaUnityProfile : InputDeviceProfile
	{
		// Token: 0x06001062 RID: 4194 RVA: 0x00041434 File Offset: 0x0003F634
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleStadiaUnityProfile()
		{
			Il2CppClassPointerStore<GoogleStadiaUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "GoogleStadiaUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleStadiaUnityProfile>.NativeClassPtr);
			GoogleStadiaUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleStadiaUnityProfile>.NativeClassPtr, 100665512);
			GoogleStadiaUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleStadiaUnityProfile>.NativeClassPtr, 100665513);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0004148C File Offset: 0x0003F68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 836614, XrefRangeEnd = 836790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleStadiaUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x000414C8 File Offset: 0x0003F6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 836790, XrefRangeEnd = 836794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleStadiaUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleStadiaUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleStadiaUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00006D49 File Offset: 0x00004F49
		public GoogleStadiaUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
