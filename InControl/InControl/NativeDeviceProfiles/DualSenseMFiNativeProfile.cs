using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200011F RID: 287
	public class DualSenseMFiNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D8D RID: 3469 RVA: 0x00037D0C File Offset: 0x00035F0C
		// Note: this type is marked as 'beforefieldinit'.
		static DualSenseMFiNativeProfile()
		{
			Il2CppClassPointerStore<DualSenseMFiNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "DualSenseMFiNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualSenseMFiNativeProfile>.NativeClassPtr);
			DualSenseMFiNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseMFiNativeProfile>.NativeClassPtr, 100665131);
			DualSenseMFiNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseMFiNativeProfile>.NativeClassPtr, 100665132);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00037D64 File Offset: 0x00035F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801198, XrefRangeEnd = 801476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DualSenseMFiNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00037DA0 File Offset: 0x00035FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 801476, XrefRangeEnd = 801480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DualSenseMFiNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualSenseMFiNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseMFiNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0000673D File Offset: 0x0000493D
		public DualSenseMFiNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
