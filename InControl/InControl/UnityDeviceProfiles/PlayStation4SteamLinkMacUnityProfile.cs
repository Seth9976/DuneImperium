using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001BC RID: 444
	public class PlayStation4SteamLinkMacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06001026 RID: 4134 RVA: 0x00040804 File Offset: 0x0003EA04
		// Note: this type is marked as 'beforefieldinit'.
		static PlayStation4SteamLinkMacUnityProfile()
		{
			Il2CppClassPointerStore<PlayStation4SteamLinkMacUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "PlayStation4SteamLinkMacUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayStation4SteamLinkMacUnityProfile>.NativeClassPtr);
			PlayStation4SteamLinkMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation4SteamLinkMacUnityProfile>.NativeClassPtr, 100665482);
			PlayStation4SteamLinkMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation4SteamLinkMacUnityProfile>.NativeClassPtr, 100665483);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0004085C File Offset: 0x0003EA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 834097, XrefRangeEnd = 834299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayStation4SteamLinkMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00040898 File Offset: 0x0003EA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 834299, XrefRangeEnd = 834303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayStation4SteamLinkMacUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayStation4SteamLinkMacUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayStation4SteamLinkMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00006CC2 File Offset: 0x00004EC2
		public PlayStation4SteamLinkMacUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
