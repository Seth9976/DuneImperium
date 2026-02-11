using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001C2 RID: 450
	public class XboxOneMacUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600103E RID: 4158 RVA: 0x00040CE4 File Offset: 0x0003EEE4
		// Note: this type is marked as 'beforefieldinit'.
		static XboxOneMacUnityProfile()
		{
			Il2CppClassPointerStore<XboxOneMacUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "XboxOneMacUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxOneMacUnityProfile>.NativeClassPtr);
			XboxOneMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneMacUnityProfile>.NativeClassPtr, 100665494);
			XboxOneMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneMacUnityProfile>.NativeClassPtr, 100665495);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x00040D3C File Offset: 0x0003EF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 835301, XrefRangeEnd = 835503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XboxOneMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00040D78 File Offset: 0x0003EF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 835503, XrefRangeEnd = 835507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxOneMacUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxOneMacUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00006CF8 File Offset: 0x00004EF8
		public XboxOneMacUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
