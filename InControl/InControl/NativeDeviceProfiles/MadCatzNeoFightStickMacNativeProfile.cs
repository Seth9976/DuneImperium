using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000C0 RID: 192
	public class MadCatzNeoFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000C11 RID: 3089 RVA: 0x00032FDC File Offset: 0x000311DC
		// Note: this type is marked as 'beforefieldinit'.
		static MadCatzNeoFightStickMacNativeProfile()
		{
			Il2CppClassPointerStore<MadCatzNeoFightStickMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "MadCatzNeoFightStickMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MadCatzNeoFightStickMacNativeProfile>.NativeClassPtr);
			MadCatzNeoFightStickMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MadCatzNeoFightStickMacNativeProfile>.NativeClassPtr, 100664941);
			MadCatzNeoFightStickMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MadCatzNeoFightStickMacNativeProfile>.NativeClassPtr, 100664942);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00033034 File Offset: 0x00031234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793265, XrefRangeEnd = 793279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MadCatzNeoFightStickMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00033070 File Offset: 0x00031270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MadCatzNeoFightStickMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MadCatzNeoFightStickMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MadCatzNeoFightStickMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x000063E6 File Offset: 0x000045E6
		public MadCatzNeoFightStickMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
