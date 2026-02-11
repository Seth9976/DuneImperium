using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001F9 RID: 505
	public class NVidiaShieldWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600111A RID: 4378 RVA: 0x00043994 File Offset: 0x00041B94
		// Note: this type is marked as 'beforefieldinit'.
		static NVidiaShieldWindowsUnityProfile()
		{
			Il2CppClassPointerStore<NVidiaShieldWindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NVidiaShieldWindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NVidiaShieldWindowsUnityProfile>.NativeClassPtr);
			NVidiaShieldWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NVidiaShieldWindowsUnityProfile>.NativeClassPtr, 100665604);
			NVidiaShieldWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NVidiaShieldWindowsUnityProfile>.NativeClassPtr, 100665605);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x000439EC File Offset: 0x00041BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846842, XrefRangeEnd = 847038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NVidiaShieldWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00043A28 File Offset: 0x00041C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 847038, XrefRangeEnd = 847042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NVidiaShieldWindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NVidiaShieldWindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NVidiaShieldWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00006EE7 File Offset: 0x000050E7
		public NVidiaShieldWindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
