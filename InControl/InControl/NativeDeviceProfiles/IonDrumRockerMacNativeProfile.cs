using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000A4 RID: 164
	public class IonDrumRockerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000BA1 RID: 2977 RVA: 0x0003191C File Offset: 0x0002FB1C
		// Note: this type is marked as 'beforefieldinit'.
		static IonDrumRockerMacNativeProfile()
		{
			Il2CppClassPointerStore<IonDrumRockerMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "IonDrumRockerMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IonDrumRockerMacNativeProfile>.NativeClassPtr);
			IonDrumRockerMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IonDrumRockerMacNativeProfile>.NativeClassPtr, 100664885);
			IonDrumRockerMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IonDrumRockerMacNativeProfile>.NativeClassPtr, 100664886);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00031974 File Offset: 0x0002FB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792868, XrefRangeEnd = 792882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IonDrumRockerMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000319B0 File Offset: 0x0002FBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IonDrumRockerMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IonDrumRockerMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IonDrumRockerMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x000062EA File Offset: 0x000044EA
		public IonDrumRockerMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
