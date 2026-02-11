using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000199 RID: 409
	public class SteelSeriesStratusXLAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F9A RID: 3994 RVA: 0x0003EB94 File Offset: 0x0003CD94
		// Note: this type is marked as 'beforefieldinit'.
		static SteelSeriesStratusXLAndroidUnityProfile()
		{
			Il2CppClassPointerStore<SteelSeriesStratusXLAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "SteelSeriesStratusXLAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteelSeriesStratusXLAndroidUnityProfile>.NativeClassPtr);
			SteelSeriesStratusXLAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteelSeriesStratusXLAndroidUnityProfile>.NativeClassPtr, 100665412);
			SteelSeriesStratusXLAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteelSeriesStratusXLAndroidUnityProfile>.NativeClassPtr, 100665413);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x0003EBEC File Offset: 0x0003CDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 827537, XrefRangeEnd = 827704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteelSeriesStratusXLAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0003EC28 File Offset: 0x0003CE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 827704, XrefRangeEnd = 827708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteelSeriesStratusXLAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteelSeriesStratusXLAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteelSeriesStratusXLAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00006B87 File Offset: 0x00004D87
		public SteelSeriesStratusXLAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
