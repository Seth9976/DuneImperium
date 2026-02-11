using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001DD RID: 477
	public class XInputWindowsChromeUnityProfile : InputDeviceProfile
	{
		// Token: 0x060010AA RID: 4266 RVA: 0x000422D4 File Offset: 0x000404D4
		// Note: this type is marked as 'beforefieldinit'.
		static XInputWindowsChromeUnityProfile()
		{
			Il2CppClassPointerStore<XInputWindowsChromeUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "XInputWindowsChromeUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XInputWindowsChromeUnityProfile>.NativeClassPtr);
			XInputWindowsChromeUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputWindowsChromeUnityProfile>.NativeClassPtr, 100665548);
			XInputWindowsChromeUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputWindowsChromeUnityProfile>.NativeClassPtr, 100665549);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0004232C File Offset: 0x0004052C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 841310, XrefRangeEnd = 841598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XInputWindowsChromeUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00042368 File Offset: 0x00040568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 841598, XrefRangeEnd = 841602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XInputWindowsChromeUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XInputWindowsChromeUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XInputWindowsChromeUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00006DEB File Offset: 0x00004FEB
		public XInputWindowsChromeUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
