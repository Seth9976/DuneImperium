using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001C7 RID: 455
	public class AppleMFiUnityProfile : InputDeviceProfile
	{
		// Token: 0x06001052 RID: 4178 RVA: 0x000410F4 File Offset: 0x0003F2F4
		// Note: this type is marked as 'beforefieldinit'.
		static AppleMFiUnityProfile()
		{
			Il2CppClassPointerStore<AppleMFiUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "AppleMFiUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppleMFiUnityProfile>.NativeClassPtr);
			AppleMFiUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleMFiUnityProfile>.NativeClassPtr, 100665504);
			AppleMFiUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleMFiUnityProfile>.NativeClassPtr, 100665505);
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0004114C File Offset: 0x0003F34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 835900, XrefRangeEnd = 836079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppleMFiUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00041188 File Offset: 0x0003F388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 836079, XrefRangeEnd = 836083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppleMFiUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppleMFiUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleMFiUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00006D25 File Offset: 0x00004F25
		public AppleMFiUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
