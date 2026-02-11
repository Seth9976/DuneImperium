using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001C3 RID: 451
	public class XboxWirelessMacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06001042 RID: 4162 RVA: 0x00040DB4 File Offset: 0x0003EFB4
		// Note: this type is marked as 'beforefieldinit'.
		static XboxWirelessMacUnityProfile()
		{
			Il2CppClassPointerStore<XboxWirelessMacUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "XboxWirelessMacUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxWirelessMacUnityProfile>.NativeClassPtr);
			XboxWirelessMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxWirelessMacUnityProfile>.NativeClassPtr, 100665496);
			XboxWirelessMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxWirelessMacUnityProfile>.NativeClassPtr, 100665497);
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00040E0C File Offset: 0x0003F00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 835507, XrefRangeEnd = 835663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XboxWirelessMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00040E48 File Offset: 0x0003F048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 835663, XrefRangeEnd = 835667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxWirelessMacUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxWirelessMacUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxWirelessMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00006D01 File Offset: 0x00004F01
		public XboxWirelessMacUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
