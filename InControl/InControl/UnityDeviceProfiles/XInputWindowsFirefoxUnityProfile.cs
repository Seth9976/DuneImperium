using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001DE RID: 478
	public class XInputWindowsFirefoxUnityProfile : InputDeviceProfile
	{
		// Token: 0x060010AE RID: 4270 RVA: 0x000423A4 File Offset: 0x000405A4
		// Note: this type is marked as 'beforefieldinit'.
		static XInputWindowsFirefoxUnityProfile()
		{
			Il2CppClassPointerStore<XInputWindowsFirefoxUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "XInputWindowsFirefoxUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XInputWindowsFirefoxUnityProfile>.NativeClassPtr);
			XInputWindowsFirefoxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputWindowsFirefoxUnityProfile>.NativeClassPtr, 100665550);
			XInputWindowsFirefoxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputWindowsFirefoxUnityProfile>.NativeClassPtr, 100665551);
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x000423FC File Offset: 0x000405FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 841602, XrefRangeEnd = 841889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XInputWindowsFirefoxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00042438 File Offset: 0x00040638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 841889, XrefRangeEnd = 841893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XInputWindowsFirefoxUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XInputWindowsFirefoxUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XInputWindowsFirefoxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00006DF4 File Offset: 0x00004FF4
		public XInputWindowsFirefoxUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
