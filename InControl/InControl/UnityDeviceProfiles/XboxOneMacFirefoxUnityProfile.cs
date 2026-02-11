using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001D8 RID: 472
	public class XboxOneMacFirefoxUnityProfile : InputDeviceProfile
	{
		// Token: 0x06001096 RID: 4246 RVA: 0x00041EC4 File Offset: 0x000400C4
		// Note: this type is marked as 'beforefieldinit'.
		static XboxOneMacFirefoxUnityProfile()
		{
			Il2CppClassPointerStore<XboxOneMacFirefoxUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "XboxOneMacFirefoxUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxOneMacFirefoxUnityProfile>.NativeClassPtr);
			XboxOneMacFirefoxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneMacFirefoxUnityProfile>.NativeClassPtr, 100665538);
			XboxOneMacFirefoxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneMacFirefoxUnityProfile>.NativeClassPtr, 100665539);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00041F1C File Offset: 0x0004011C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 839870, XrefRangeEnd = 840158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XboxOneMacFirefoxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00041F58 File Offset: 0x00040158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 840158, XrefRangeEnd = 840162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxOneMacFirefoxUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxOneMacFirefoxUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneMacFirefoxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00006DBE File Offset: 0x00004FBE
		public XboxOneMacFirefoxUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
