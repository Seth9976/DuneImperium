using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200009D RID: 157
	public class HoriRealArcadeProVHayabusaMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000B85 RID: 2949 RVA: 0x0003136C File Offset: 0x0002F56C
		// Note: this type is marked as 'beforefieldinit'.
		static HoriRealArcadeProVHayabusaMacNativeProfile()
		{
			Il2CppClassPointerStore<HoriRealArcadeProVHayabusaMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "HoriRealArcadeProVHayabusaMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoriRealArcadeProVHayabusaMacNativeProfile>.NativeClassPtr);
			HoriRealArcadeProVHayabusaMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoriRealArcadeProVHayabusaMacNativeProfile>.NativeClassPtr, 100664871);
			HoriRealArcadeProVHayabusaMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoriRealArcadeProVHayabusaMacNativeProfile>.NativeClassPtr, 100664872);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x000313C4 File Offset: 0x0002F5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792768, XrefRangeEnd = 792782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HoriRealArcadeProVHayabusaMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00031400 File Offset: 0x0002F600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HoriRealArcadeProVHayabusaMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoriRealArcadeProVHayabusaMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoriRealArcadeProVHayabusaMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x000062AB File Offset: 0x000044AB
		public HoriRealArcadeProVHayabusaMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
