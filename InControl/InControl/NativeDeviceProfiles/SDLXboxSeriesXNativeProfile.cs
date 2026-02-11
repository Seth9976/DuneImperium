using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200012F RID: 303
	public class SDLXboxSeriesXNativeProfile : SDLControllerNativeProfile
	{
		// Token: 0x06000DF2 RID: 3570 RVA: 0x00039574 File Offset: 0x00037774
		// Note: this type is marked as 'beforefieldinit'.
		static SDLXboxSeriesXNativeProfile()
		{
			Il2CppClassPointerStore<SDLXboxSeriesXNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "SDLXboxSeriesXNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SDLXboxSeriesXNativeProfile>.NativeClassPtr);
			SDLXboxSeriesXNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLXboxSeriesXNativeProfile>.NativeClassPtr, 100665200);
			SDLXboxSeriesXNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDLXboxSeriesXNativeProfile>.NativeClassPtr, 100665201);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x000395CC File Offset: 0x000377CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805287, XrefRangeEnd = 805470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SDLXboxSeriesXNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00039608 File Offset: 0x00037808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SDLXboxSeriesXNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SDLXboxSeriesXNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDLXboxSeriesXNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x000067CD File Offset: 0x000049CD
		public SDLXboxSeriesXNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000229 RID: 553
		public enum ProductId : ushort
		{
			// Token: 0x04000E2C RID: 3628
			XBOX_SERIES_X = 2834,
			// Token: 0x04000E2D RID: 3629
			XBOX_SERIES_X_BLUETOOTH,
			// Token: 0x04000E2E RID: 3630
			XBOX_SERIES_X_POWERA = 8193
		}
	}
}
