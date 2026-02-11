using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001F8 RID: 504
	public class NVidiaShieldWindows81UnityProfile : InputDeviceProfile
	{
		// Token: 0x06001116 RID: 4374 RVA: 0x000438C4 File Offset: 0x00041AC4
		// Note: this type is marked as 'beforefieldinit'.
		static NVidiaShieldWindows81UnityProfile()
		{
			Il2CppClassPointerStore<NVidiaShieldWindows81UnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NVidiaShieldWindows81UnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NVidiaShieldWindows81UnityProfile>.NativeClassPtr);
			NVidiaShieldWindows81UnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NVidiaShieldWindows81UnityProfile>.NativeClassPtr, 100665602);
			NVidiaShieldWindows81UnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NVidiaShieldWindows81UnityProfile>.NativeClassPtr, 100665603);
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0004391C File Offset: 0x00041B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846645, XrefRangeEnd = 846838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NVidiaShieldWindows81UnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x00043958 File Offset: 0x00041B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846838, XrefRangeEnd = 846842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NVidiaShieldWindows81UnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NVidiaShieldWindows81UnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NVidiaShieldWindows81UnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00006EDE File Offset: 0x000050DE
		public NVidiaShieldWindows81UnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
