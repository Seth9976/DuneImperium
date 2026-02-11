using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000C3 RID: 195
	public class MadCatzSaitekAV8R02MacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000C1D RID: 3101 RVA: 0x0003324C File Offset: 0x0003144C
		// Note: this type is marked as 'beforefieldinit'.
		static MadCatzSaitekAV8R02MacNativeProfile()
		{
			Il2CppClassPointerStore<MadCatzSaitekAV8R02MacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "MadCatzSaitekAV8R02MacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MadCatzSaitekAV8R02MacNativeProfile>.NativeClassPtr);
			MadCatzSaitekAV8R02MacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MadCatzSaitekAV8R02MacNativeProfile>.NativeClassPtr, 100664947);
			MadCatzSaitekAV8R02MacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MadCatzSaitekAV8R02MacNativeProfile>.NativeClassPtr, 100664948);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x000332A4 File Offset: 0x000314A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793307, XrefRangeEnd = 793321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MadCatzSaitekAV8R02MacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000332E0 File Offset: 0x000314E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MadCatzSaitekAV8R02MacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MadCatzSaitekAV8R02MacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MadCatzSaitekAV8R02MacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00006401 File Offset: 0x00004601
		public MadCatzSaitekAV8R02MacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
