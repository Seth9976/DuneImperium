using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200012B RID: 299
	public class SDLPlayStation4NativeProfile : SDLControllerNativeProfile
	{
		// Token: 0x06000DE2 RID: 3554 RVA: 0x00039234 File Offset: 0x00037434
		// Note: this type is marked as 'beforefieldinit'.
		static SDLPlayStation4NativeProfile()
		{
			Il2CppClassPointerStore<SDLPlayStation4NativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "SDLPlayStation4NativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SDLPlayStation4NativeProfile>.NativeClassPtr);
			SDLPlayStation4NativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLPlayStation4NativeProfile>.NativeClassPtr, 100665192);
			SDLPlayStation4NativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLPlayStation4NativeProfile>.NativeClassPtr, 100665193);
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0003928C File Offset: 0x0003748C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804510, XrefRangeEnd = 804721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SDLPlayStation4NativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x000392C8 File Offset: 0x000374C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SDLPlayStation4NativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SDLPlayStation4NativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLPlayStation4NativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x000067A9 File Offset: 0x000049A9
		public SDLPlayStation4NativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000226 RID: 550
		public enum ProductId : ushort
		{
			// Token: 0x04000E20 RID: 3616
			SONY_DS4 = 1476,
			// Token: 0x04000E21 RID: 3617
			SONY_DS4_DONGLE = 2976,
			// Token: 0x04000E22 RID: 3618
			SONY_DS4_SLIM = 2508
		}
	}
}
