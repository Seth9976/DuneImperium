using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000123 RID: 291
	public class XboxSeriesXMFiNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D9D RID: 3485 RVA: 0x0003804C File Offset: 0x0003624C
		// Note: this type is marked as 'beforefieldinit'.
		static XboxSeriesXMFiNativeProfile()
		{
			Il2CppClassPointerStore<XboxSeriesXMFiNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "XboxSeriesXMFiNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxSeriesXMFiNativeProfile>.NativeClassPtr);
			XboxSeriesXMFiNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxSeriesXMFiNativeProfile>.NativeClassPtr, 100665139);
			XboxSeriesXMFiNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxSeriesXMFiNativeProfile>.NativeClassPtr, 100665140);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x000380A4 File Offset: 0x000362A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802326, XrefRangeEnd = 802604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XboxSeriesXMFiNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x000380E0 File Offset: 0x000362E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802604, XrefRangeEnd = 802608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxSeriesXMFiNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxSeriesXMFiNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxSeriesXMFiNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00006761 File Offset: 0x00004961
		public XboxSeriesXMFiNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
