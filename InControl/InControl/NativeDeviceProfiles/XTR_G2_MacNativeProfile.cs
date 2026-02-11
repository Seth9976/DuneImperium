using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200011C RID: 284
	public class XTR_G2_MacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D81 RID: 3457 RVA: 0x00037A9C File Offset: 0x00035C9C
		// Note: this type is marked as 'beforefieldinit'.
		static XTR_G2_MacNativeProfile()
		{
			Il2CppClassPointerStore<XTR_G2_MacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "XTR_G2_MacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XTR_G2_MacNativeProfile>.NativeClassPtr);
			XTR_G2_MacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTR_G2_MacNativeProfile>.NativeClassPtr, 100665125);
			XTR_G2_MacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTR_G2_MacNativeProfile>.NativeClassPtr, 100665126);
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00037AF4 File Offset: 0x00035CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800758, XrefRangeEnd = 800783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XTR_G2_MacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00037B30 File Offset: 0x00035D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800783, XrefRangeEnd = 800787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XTR_G2_MacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XTR_G2_MacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTR_G2_MacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00006722 File Offset: 0x00004922
		public XTR_G2_MacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
