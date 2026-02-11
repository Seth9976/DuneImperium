using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000171 RID: 369
	public class EightBitdoNES30ProAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000EFA RID: 3834 RVA: 0x0003CB14 File Offset: 0x0003AD14
		// Note: this type is marked as 'beforefieldinit'.
		static EightBitdoNES30ProAndroidUnityProfile()
		{
			Il2CppClassPointerStore<EightBitdoNES30ProAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "EightBitdoNES30ProAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EightBitdoNES30ProAndroidUnityProfile>.NativeClassPtr);
			EightBitdoNES30ProAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightBitdoNES30ProAndroidUnityProfile>.NativeClassPtr, 100665332);
			EightBitdoNES30ProAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightBitdoNES30ProAndroidUnityProfile>.NativeClassPtr, 100665333);
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0003CB6C File Offset: 0x0003AD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820695, XrefRangeEnd = 820872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EightBitdoNES30ProAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0003CBA8 File Offset: 0x0003ADA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820872, XrefRangeEnd = 820876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EightBitdoNES30ProAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EightBitdoNES30ProAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EightBitdoNES30ProAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00006A1F File Offset: 0x00004C1F
		public EightBitdoNES30ProAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
