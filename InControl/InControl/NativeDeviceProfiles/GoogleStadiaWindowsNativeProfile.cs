using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200013A RID: 314
	public class GoogleStadiaWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000E1E RID: 3614 RVA: 0x00039E64 File Offset: 0x00038064
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleStadiaWindowsNativeProfile()
		{
			Il2CppClassPointerStore<GoogleStadiaWindowsNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "GoogleStadiaWindowsNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleStadiaWindowsNativeProfile>.NativeClassPtr);
			GoogleStadiaWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleStadiaWindowsNativeProfile>.NativeClassPtr, 100665222);
			GoogleStadiaWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleStadiaWindowsNativeProfile>.NativeClassPtr, 100665223);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00039EBC File Offset: 0x000380BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 808097, XrefRangeEnd = 808433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleStadiaWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00039EF8 File Offset: 0x000380F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 808433, XrefRangeEnd = 808437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleStadiaWindowsNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleStadiaWindowsNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleStadiaWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00006830 File Offset: 0x00004A30
		public GoogleStadiaWindowsNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
