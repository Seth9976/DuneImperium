using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000201 RID: 513
	public class SteelSeriesFreeWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600113A RID: 4410 RVA: 0x00044014 File Offset: 0x00042214
		// Note: this type is marked as 'beforefieldinit'.
		static SteelSeriesFreeWindowsUnityProfile()
		{
			Il2CppClassPointerStore<SteelSeriesFreeWindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "SteelSeriesFreeWindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteelSeriesFreeWindowsUnityProfile>.NativeClassPtr);
			SteelSeriesFreeWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteelSeriesFreeWindowsUnityProfile>.NativeClassPtr, 100665620);
			SteelSeriesFreeWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteelSeriesFreeWindowsUnityProfile>.NativeClassPtr, 100665621);
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0004406C File Offset: 0x0004226C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848449, XrefRangeEnd = 848626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteelSeriesFreeWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x000440A8 File Offset: 0x000422A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848626, XrefRangeEnd = 848630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteelSeriesFreeWindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteelSeriesFreeWindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteelSeriesFreeWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00006F2F File Offset: 0x0000512F
		public SteelSeriesFreeWindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
