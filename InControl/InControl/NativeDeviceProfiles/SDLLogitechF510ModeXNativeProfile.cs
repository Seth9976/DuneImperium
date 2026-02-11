using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000127 RID: 295
	public class SDLLogitechF510ModeXNativeProfile : SDLControllerNativeProfile
	{
		// Token: 0x06000DD2 RID: 3538 RVA: 0x00038EF4 File Offset: 0x000370F4
		// Note: this type is marked as 'beforefieldinit'.
		static SDLLogitechF510ModeXNativeProfile()
		{
			Il2CppClassPointerStore<SDLLogitechF510ModeXNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "SDLLogitechF510ModeXNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SDLLogitechF510ModeXNativeProfile>.NativeClassPtr);
			SDLLogitechF510ModeXNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLLogitechF510ModeXNativeProfile>.NativeClassPtr, 100665184);
			SDLLogitechF510ModeXNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLLogitechF510ModeXNativeProfile>.NativeClassPtr, 100665185);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00038F4C File Offset: 0x0003714C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803734, XrefRangeEnd = 803895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SDLLogitechF510ModeXNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00038F88 File Offset: 0x00037188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SDLLogitechF510ModeXNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SDLLogitechF510ModeXNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLLogitechF510ModeXNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00006785 File Offset: 0x00004985
		public SDLLogitechF510ModeXNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
