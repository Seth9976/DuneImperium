using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200012E RID: 302
	public class SDLXboxOneNativeProfile : SDLControllerNativeProfile
	{
		// Token: 0x06000DEE RID: 3566 RVA: 0x000394A4 File Offset: 0x000376A4
		// Note: this type is marked as 'beforefieldinit'.
		static SDLXboxOneNativeProfile()
		{
			Il2CppClassPointerStore<SDLXboxOneNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "SDLXboxOneNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SDLXboxOneNativeProfile>.NativeClassPtr);
			SDLXboxOneNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLXboxOneNativeProfile>.NativeClassPtr, 100665198);
			SDLXboxOneNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLXboxOneNativeProfile>.NativeClassPtr, 100665199);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x000394FC File Offset: 0x000376FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805103, XrefRangeEnd = 805287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SDLXboxOneNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00039538 File Offset: 0x00037738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SDLXboxOneNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SDLXboxOneNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLXboxOneNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x000067C4 File Offset: 0x000049C4
		public SDLXboxOneNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000228 RID: 552
		public enum ProductId : ushort
		{
			// Token: 0x04000E26 RID: 3622
			XBOX_ONE_S = 746,
			// Token: 0x04000E27 RID: 3623
			XBOX_ONE_S_REV1_BLUETOOTH = 736,
			// Token: 0x04000E28 RID: 3624
			XBOX_ONE_S_REV2_BLUETOOTH = 765,
			// Token: 0x04000E29 RID: 3625
			XBOX_ONE_RAW_INPUT_CONTROLLER = 767,
			// Token: 0x04000E2A RID: 3626
			XBOX_ONE_XINPUT_CONTROLLER = 766
		}
	}
}
