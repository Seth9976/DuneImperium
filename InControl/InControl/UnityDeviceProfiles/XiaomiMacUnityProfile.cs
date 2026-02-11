using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001C4 RID: 452
	public class XiaomiMacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06001046 RID: 4166 RVA: 0x00040E84 File Offset: 0x0003F084
		// Note: this type is marked as 'beforefieldinit'.
		static XiaomiMacUnityProfile()
		{
			Il2CppClassPointerStore<XiaomiMacUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "XiaomiMacUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XiaomiMacUnityProfile>.NativeClassPtr);
			XiaomiMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XiaomiMacUnityProfile>.NativeClassPtr, 100665498);
			XiaomiMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XiaomiMacUnityProfile>.NativeClassPtr, 100665499);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00040EDC File Offset: 0x0003F0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 835667, XrefRangeEnd = 835844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XiaomiMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00040F18 File Offset: 0x0003F118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 835844, XrefRangeEnd = 835848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XiaomiMacUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XiaomiMacUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XiaomiMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00006D0A File Offset: 0x00004F0A
		public XiaomiMacUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
