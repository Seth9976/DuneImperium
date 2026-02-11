using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200016F RID: 367
	public class EightBitdoGenericAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000EF2 RID: 3826 RVA: 0x0003C974 File Offset: 0x0003AB74
		// Note: this type is marked as 'beforefieldinit'.
		static EightBitdoGenericAndroidUnityProfile()
		{
			Il2CppClassPointerStore<EightBitdoGenericAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "EightBitdoGenericAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EightBitdoGenericAndroidUnityProfile>.NativeClassPtr);
			EightBitdoGenericAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightBitdoGenericAndroidUnityProfile>.NativeClassPtr, 100665328);
			EightBitdoGenericAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightBitdoGenericAndroidUnityProfile>.NativeClassPtr, 100665329);
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0003C9CC File Offset: 0x0003ABCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820351, XrefRangeEnd = 820528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EightBitdoGenericAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0003CA08 File Offset: 0x0003AC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820528, XrefRangeEnd = 820532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EightBitdoGenericAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EightBitdoGenericAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EightBitdoGenericAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00006A0D File Offset: 0x00004C0D
		public EightBitdoGenericAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
