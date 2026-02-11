using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200011B RID: 283
	public class XTR55_G2_MacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D7D RID: 3453 RVA: 0x000379CC File Offset: 0x00035BCC
		// Note: this type is marked as 'beforefieldinit'.
		static XTR55_G2_MacNativeProfile()
		{
			Il2CppClassPointerStore<XTR55_G2_MacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "XTR55_G2_MacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XTR55_G2_MacNativeProfile>.NativeClassPtr);
			XTR55_G2_MacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTR55_G2_MacNativeProfile>.NativeClassPtr, 100665123);
			XTR55_G2_MacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTR55_G2_MacNativeProfile>.NativeClassPtr, 100665124);
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00037A24 File Offset: 0x00035C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800729, XrefRangeEnd = 800754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XTR55_G2_MacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00037A60 File Offset: 0x00035C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800754, XrefRangeEnd = 800758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XTR55_G2_MacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XTR55_G2_MacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTR55_G2_MacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00006719 File Offset: 0x00004919
		public XTR55_G2_MacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
