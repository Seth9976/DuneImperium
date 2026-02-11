using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200012A RID: 298
	public class SDLPlayStation3NativeProfile : SDLControllerNativeProfile
	{
		// Token: 0x06000DDE RID: 3550 RVA: 0x00039164 File Offset: 0x00037364
		// Note: this type is marked as 'beforefieldinit'.
		static SDLPlayStation3NativeProfile()
		{
			Il2CppClassPointerStore<SDLPlayStation3NativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "SDLPlayStation3NativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SDLPlayStation3NativeProfile>.NativeClassPtr);
			SDLPlayStation3NativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLPlayStation3NativeProfile>.NativeClassPtr, 100665190);
			SDLPlayStation3NativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLPlayStation3NativeProfile>.NativeClassPtr, 100665191);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x000391BC File Offset: 0x000373BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804280, XrefRangeEnd = 804510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SDLPlayStation3NativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x000391F8 File Offset: 0x000373F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SDLPlayStation3NativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SDLPlayStation3NativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLPlayStation3NativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x000067A0 File Offset: 0x000049A0
		public SDLPlayStation3NativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
