using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000128 RID: 296
	public class SDLLogitechF710ModeXNativeProfile : SDLControllerNativeProfile
	{
		// Token: 0x06000DD6 RID: 3542 RVA: 0x00038FC4 File Offset: 0x000371C4
		// Note: this type is marked as 'beforefieldinit'.
		static SDLLogitechF710ModeXNativeProfile()
		{
			Il2CppClassPointerStore<SDLLogitechF710ModeXNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "SDLLogitechF710ModeXNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SDLLogitechF710ModeXNativeProfile>.NativeClassPtr);
			SDLLogitechF710ModeXNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLLogitechF710ModeXNativeProfile>.NativeClassPtr, 100665186);
			SDLLogitechF710ModeXNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLLogitechF710ModeXNativeProfile>.NativeClassPtr, 100665187);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0003901C File Offset: 0x0003721C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803895, XrefRangeEnd = 804056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SDLLogitechF710ModeXNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00039058 File Offset: 0x00037258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SDLLogitechF710ModeXNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SDLLogitechF710ModeXNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLLogitechF710ModeXNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0000678E File Offset: 0x0000498E
		public SDLLogitechF710ModeXNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
