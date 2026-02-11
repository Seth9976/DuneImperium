using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000C2 RID: 194
	public class MadCatzProControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000C19 RID: 3097 RVA: 0x0003317C File Offset: 0x0003137C
		// Note: this type is marked as 'beforefieldinit'.
		static MadCatzProControllerMacNativeProfile()
		{
			Il2CppClassPointerStore<MadCatzProControllerMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "MadCatzProControllerMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MadCatzProControllerMacNativeProfile>.NativeClassPtr);
			MadCatzProControllerMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MadCatzProControllerMacNativeProfile>.NativeClassPtr, 100664945);
			MadCatzProControllerMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MadCatzProControllerMacNativeProfile>.NativeClassPtr, 100664946);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x000331D4 File Offset: 0x000313D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793293, XrefRangeEnd = 793307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MadCatzProControllerMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00033210 File Offset: 0x00031410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MadCatzProControllerMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MadCatzProControllerMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MadCatzProControllerMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x000063F8 File Offset: 0x000045F8
		public MadCatzProControllerMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
