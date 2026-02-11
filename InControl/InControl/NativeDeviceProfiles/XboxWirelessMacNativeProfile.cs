using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200011A RID: 282
	public class XboxWirelessMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D79 RID: 3449 RVA: 0x000378FC File Offset: 0x00035AFC
		// Note: this type is marked as 'beforefieldinit'.
		static XboxWirelessMacNativeProfile()
		{
			Il2CppClassPointerStore<XboxWirelessMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "XboxWirelessMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxWirelessMacNativeProfile>.NativeClassPtr);
			XboxWirelessMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxWirelessMacNativeProfile>.NativeClassPtr, 100665121);
			XboxWirelessMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxWirelessMacNativeProfile>.NativeClassPtr, 100665122);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00037954 File Offset: 0x00035B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800514, XrefRangeEnd = 800725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XboxWirelessMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00037990 File Offset: 0x00035B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800725, XrefRangeEnd = 800729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxWirelessMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxWirelessMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxWirelessMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00006710 File Offset: 0x00004910
		public XboxWirelessMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
