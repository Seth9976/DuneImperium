using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000CC RID: 204
	public class McbazelAdapterMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000C41 RID: 3137 RVA: 0x0003399C File Offset: 0x00031B9C
		// Note: this type is marked as 'beforefieldinit'.
		static McbazelAdapterMacNativeProfile()
		{
			Il2CppClassPointerStore<McbazelAdapterMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "McbazelAdapterMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<McbazelAdapterMacNativeProfile>.NativeClassPtr);
			McbazelAdapterMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<McbazelAdapterMacNativeProfile>.NativeClassPtr, 100664965);
			McbazelAdapterMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<McbazelAdapterMacNativeProfile>.NativeClassPtr, 100664966);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x000339F4 File Offset: 0x00031BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793442, XrefRangeEnd = 793459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), McbazelAdapterMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00033A30 File Offset: 0x00031C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe McbazelAdapterMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<McbazelAdapterMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(McbazelAdapterMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00006452 File Offset: 0x00004652
		public McbazelAdapterMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
