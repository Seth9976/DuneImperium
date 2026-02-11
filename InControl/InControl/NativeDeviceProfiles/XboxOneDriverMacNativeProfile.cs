using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000116 RID: 278
	public class XboxOneDriverMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D69 RID: 3433 RVA: 0x000375BC File Offset: 0x000357BC
		// Note: this type is marked as 'beforefieldinit'.
		static XboxOneDriverMacNativeProfile()
		{
			Il2CppClassPointerStore<XboxOneDriverMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "XboxOneDriverMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxOneDriverMacNativeProfile>.NativeClassPtr);
			XboxOneDriverMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneDriverMacNativeProfile>.NativeClassPtr, 100665113);
			XboxOneDriverMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneDriverMacNativeProfile>.NativeClassPtr, 100665114);
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00037614 File Offset: 0x00035814
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 799788, RefRangeEnd = 799798, XrefRangeStart = 799547, XrefRangeEnd = 799788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XboxOneDriverMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00037650 File Offset: 0x00035850
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 799802, RefRangeEnd = 799812, XrefRangeStart = 799798, XrefRangeEnd = 799802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxOneDriverMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxOneDriverMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneDriverMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x000066EC File Offset: 0x000048EC
		public XboxOneDriverMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
