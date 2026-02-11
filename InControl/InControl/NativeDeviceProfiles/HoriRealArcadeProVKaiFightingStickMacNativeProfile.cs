using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200009E RID: 158
	public class HoriRealArcadeProVKaiFightingStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000B89 RID: 2953 RVA: 0x0003143C File Offset: 0x0002F63C
		// Note: this type is marked as 'beforefieldinit'.
		static HoriRealArcadeProVKaiFightingStickMacNativeProfile()
		{
			Il2CppClassPointerStore<HoriRealArcadeProVKaiFightingStickMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "HoriRealArcadeProVKaiFightingStickMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoriRealArcadeProVKaiFightingStickMacNativeProfile>.NativeClassPtr);
			HoriRealArcadeProVKaiFightingStickMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoriRealArcadeProVKaiFightingStickMacNativeProfile>.NativeClassPtr, 100664873);
			HoriRealArcadeProVKaiFightingStickMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoriRealArcadeProVKaiFightingStickMacNativeProfile>.NativeClassPtr, 100664874);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00031494 File Offset: 0x0002F694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792782, XrefRangeEnd = 792797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoriRealArcadeProVKaiFightingStickMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x000314D0 File Offset: 0x0002F6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HoriRealArcadeProVKaiFightingStickMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoriRealArcadeProVKaiFightingStickMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoriRealArcadeProVKaiFightingStickMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x000062B4 File Offset: 0x000044B4
		public HoriRealArcadeProVKaiFightingStickMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
