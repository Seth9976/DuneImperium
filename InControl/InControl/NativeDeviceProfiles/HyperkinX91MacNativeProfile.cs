using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000A2 RID: 162
	public class HyperkinX91MacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000B99 RID: 2969 RVA: 0x0003177C File Offset: 0x0002F97C
		// Note: this type is marked as 'beforefieldinit'.
		static HyperkinX91MacNativeProfile()
		{
			Il2CppClassPointerStore<HyperkinX91MacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "HyperkinX91MacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HyperkinX91MacNativeProfile>.NativeClassPtr);
			HyperkinX91MacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HyperkinX91MacNativeProfile>.NativeClassPtr, 100664881);
			HyperkinX91MacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HyperkinX91MacNativeProfile>.NativeClassPtr, 100664882);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x000317D4 File Offset: 0x0002F9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792840, XrefRangeEnd = 792854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HyperkinX91MacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00031810 File Offset: 0x0002FA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HyperkinX91MacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HyperkinX91MacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HyperkinX91MacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x000062D8 File Offset: 0x000044D8
		public HyperkinX91MacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
