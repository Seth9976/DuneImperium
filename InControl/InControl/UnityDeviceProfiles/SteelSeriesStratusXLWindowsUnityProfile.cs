using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000202 RID: 514
	public class SteelSeriesStratusXLWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600113E RID: 4414 RVA: 0x000440E4 File Offset: 0x000422E4
		// Note: this type is marked as 'beforefieldinit'.
		static SteelSeriesStratusXLWindowsUnityProfile()
		{
			Il2CppClassPointerStore<SteelSeriesStratusXLWindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "SteelSeriesStratusXLWindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteelSeriesStratusXLWindowsUnityProfile>.NativeClassPtr);
			SteelSeriesStratusXLWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteelSeriesStratusXLWindowsUnityProfile>.NativeClassPtr, 100665622);
			SteelSeriesStratusXLWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteelSeriesStratusXLWindowsUnityProfile>.NativeClassPtr, 100665623);
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0004413C File Offset: 0x0004233C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848630, XrefRangeEnd = 848823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteelSeriesStratusXLWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x00044178 File Offset: 0x00042378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848823, XrefRangeEnd = 848827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteelSeriesStratusXLWindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteelSeriesStratusXLWindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteelSeriesStratusXLWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00006F38 File Offset: 0x00005138
		public SteelSeriesStratusXLWindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
