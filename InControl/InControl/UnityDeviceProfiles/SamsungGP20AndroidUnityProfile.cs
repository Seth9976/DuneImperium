using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000197 RID: 407
	public class SamsungGP20AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F92 RID: 3986 RVA: 0x0003E9F4 File Offset: 0x0003CBF4
		// Note: this type is marked as 'beforefieldinit'.
		static SamsungGP20AndroidUnityProfile()
		{
			Il2CppClassPointerStore<SamsungGP20AndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "SamsungGP20AndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SamsungGP20AndroidUnityProfile>.NativeClassPtr);
			SamsungGP20AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SamsungGP20AndroidUnityProfile>.NativeClassPtr, 100665408);
			SamsungGP20AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SamsungGP20AndroidUnityProfile>.NativeClassPtr, 100665409);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0003EA4C File Offset: 0x0003CC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 827207, XrefRangeEnd = 827348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SamsungGP20AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0003EA88 File Offset: 0x0003CC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 827348, XrefRangeEnd = 827352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SamsungGP20AndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SamsungGP20AndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SamsungGP20AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00006B75 File Offset: 0x00004D75
		public SamsungGP20AndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
