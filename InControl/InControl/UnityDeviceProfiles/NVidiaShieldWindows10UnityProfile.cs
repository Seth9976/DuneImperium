using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001F7 RID: 503
	public class NVidiaShieldWindows10UnityProfile : InputDeviceProfile
	{
		// Token: 0x06001112 RID: 4370 RVA: 0x000437F4 File Offset: 0x000419F4
		// Note: this type is marked as 'beforefieldinit'.
		static NVidiaShieldWindows10UnityProfile()
		{
			Il2CppClassPointerStore<NVidiaShieldWindows10UnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NVidiaShieldWindows10UnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NVidiaShieldWindows10UnityProfile>.NativeClassPtr);
			NVidiaShieldWindows10UnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NVidiaShieldWindows10UnityProfile>.NativeClassPtr, 100665600);
			NVidiaShieldWindows10UnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NVidiaShieldWindows10UnityProfile>.NativeClassPtr, 100665601);
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0004384C File Offset: 0x00041A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846437, XrefRangeEnd = 846641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NVidiaShieldWindows10UnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00043888 File Offset: 0x00041A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846641, XrefRangeEnd = 846645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NVidiaShieldWindows10UnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NVidiaShieldWindows10UnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NVidiaShieldWindows10UnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00006ED5 File Offset: 0x000050D5
		public NVidiaShieldWindows10UnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
