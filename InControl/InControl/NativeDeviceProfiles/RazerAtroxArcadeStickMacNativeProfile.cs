using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000EA RID: 234
	public class RazerAtroxArcadeStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000CB9 RID: 3257 RVA: 0x000351FC File Offset: 0x000333FC
		// Note: this type is marked as 'beforefieldinit'.
		static RazerAtroxArcadeStickMacNativeProfile()
		{
			Il2CppClassPointerStore<RazerAtroxArcadeStickMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "RazerAtroxArcadeStickMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RazerAtroxArcadeStickMacNativeProfile>.NativeClassPtr);
			RazerAtroxArcadeStickMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RazerAtroxArcadeStickMacNativeProfile>.NativeClassPtr, 100665025);
			RazerAtroxArcadeStickMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RazerAtroxArcadeStickMacNativeProfile>.NativeClassPtr, 100665026);
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00035254 File Offset: 0x00033454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794136, XrefRangeEnd = 794157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RazerAtroxArcadeStickMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00035290 File Offset: 0x00033490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RazerAtroxArcadeStickMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RazerAtroxArcadeStickMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RazerAtroxArcadeStickMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00006560 File Offset: 0x00004760
		public RazerAtroxArcadeStickMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
