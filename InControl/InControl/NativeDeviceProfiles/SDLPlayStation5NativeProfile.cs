using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200012C RID: 300
	public class SDLPlayStation5NativeProfile : SDLControllerNativeProfile
	{
		// Token: 0x06000DE6 RID: 3558 RVA: 0x00039304 File Offset: 0x00037504
		// Note: this type is marked as 'beforefieldinit'.
		static SDLPlayStation5NativeProfile()
		{
			Il2CppClassPointerStore<SDLPlayStation5NativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "SDLPlayStation5NativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SDLPlayStation5NativeProfile>.NativeClassPtr);
			SDLPlayStation5NativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLPlayStation5NativeProfile>.NativeClassPtr, 100665194);
			SDLPlayStation5NativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLPlayStation5NativeProfile>.NativeClassPtr, 100665195);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0003935C File Offset: 0x0003755C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804721, XrefRangeEnd = 804931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SDLPlayStation5NativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00039398 File Offset: 0x00037598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SDLPlayStation5NativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SDLPlayStation5NativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLPlayStation5NativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x000067B2 File Offset: 0x000049B2
		public SDLPlayStation5NativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000227 RID: 551
		public enum ProductId : ushort
		{
			// Token: 0x04000E24 RID: 3620
			SONY_DS5 = 3302
		}
	}
}
