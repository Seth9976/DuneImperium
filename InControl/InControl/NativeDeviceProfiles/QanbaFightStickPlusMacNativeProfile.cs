using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000E9 RID: 233
	public class QanbaFightStickPlusMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000CB5 RID: 3253 RVA: 0x0003512C File Offset: 0x0003332C
		// Note: this type is marked as 'beforefieldinit'.
		static QanbaFightStickPlusMacNativeProfile()
		{
			Il2CppClassPointerStore<QanbaFightStickPlusMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "QanbaFightStickPlusMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QanbaFightStickPlusMacNativeProfile>.NativeClassPtr);
			QanbaFightStickPlusMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QanbaFightStickPlusMacNativeProfile>.NativeClassPtr, 100665023);
			QanbaFightStickPlusMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QanbaFightStickPlusMacNativeProfile>.NativeClassPtr, 100665024);
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00035184 File Offset: 0x00033384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794119, XrefRangeEnd = 794136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QanbaFightStickPlusMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x000351C0 File Offset: 0x000333C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QanbaFightStickPlusMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QanbaFightStickPlusMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QanbaFightStickPlusMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00006557 File Offset: 0x00004757
		public QanbaFightStickPlusMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
