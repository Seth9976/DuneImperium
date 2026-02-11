using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000126 RID: 294
	public class SDLLogitechF310ModeXNativeProfile : SDLControllerNativeProfile
	{
		// Token: 0x06000DCE RID: 3534 RVA: 0x00038E24 File Offset: 0x00037024
		// Note: this type is marked as 'beforefieldinit'.
		static SDLLogitechF310ModeXNativeProfile()
		{
			Il2CppClassPointerStore<SDLLogitechF310ModeXNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "SDLLogitechF310ModeXNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SDLLogitechF310ModeXNativeProfile>.NativeClassPtr);
			SDLLogitechF310ModeXNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLLogitechF310ModeXNativeProfile>.NativeClassPtr, 100665182);
			SDLLogitechF310ModeXNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLLogitechF310ModeXNativeProfile>.NativeClassPtr, 100665183);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00038E7C File Offset: 0x0003707C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803573, XrefRangeEnd = 803734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SDLLogitechF310ModeXNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00038EB8 File Offset: 0x000370B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SDLLogitechF310ModeXNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SDLLogitechF310ModeXNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLLogitechF310ModeXNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0000677C File Offset: 0x0000497C
		public SDLLogitechF310ModeXNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
