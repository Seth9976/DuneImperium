using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000E6 RID: 230
	public class PowerASpectraIlluminatedControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000CA9 RID: 3241 RVA: 0x00034EBC File Offset: 0x000330BC
		// Note: this type is marked as 'beforefieldinit'.
		static PowerASpectraIlluminatedControllerMacNativeProfile()
		{
			Il2CppClassPointerStore<PowerASpectraIlluminatedControllerMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "PowerASpectraIlluminatedControllerMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerASpectraIlluminatedControllerMacNativeProfile>.NativeClassPtr);
			PowerASpectraIlluminatedControllerMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerASpectraIlluminatedControllerMacNativeProfile>.NativeClassPtr, 100665017);
			PowerASpectraIlluminatedControllerMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerASpectraIlluminatedControllerMacNativeProfile>.NativeClassPtr, 100665018);
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00034F14 File Offset: 0x00033114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794068, XrefRangeEnd = 794085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerASpectraIlluminatedControllerMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00034F50 File Offset: 0x00033150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerASpectraIlluminatedControllerMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerASpectraIlluminatedControllerMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerASpectraIlluminatedControllerMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x0000653C File Offset: 0x0000473C
		public PowerASpectraIlluminatedControllerMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
