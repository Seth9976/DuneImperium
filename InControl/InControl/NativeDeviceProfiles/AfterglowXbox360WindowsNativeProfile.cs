using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000130 RID: 304
	public class AfterglowXbox360WindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000DF6 RID: 3574 RVA: 0x00039644 File Offset: 0x00037844
		// Note: this type is marked as 'beforefieldinit'.
		static AfterglowXbox360WindowsNativeProfile()
		{
			Il2CppClassPointerStore<AfterglowXbox360WindowsNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "AfterglowXbox360WindowsNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AfterglowXbox360WindowsNativeProfile>.NativeClassPtr);
			AfterglowXbox360WindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AfterglowXbox360WindowsNativeProfile>.NativeClassPtr, 100665202);
			AfterglowXbox360WindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AfterglowXbox360WindowsNativeProfile>.NativeClassPtr, 100665203);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0003969C File Offset: 0x0003789C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805470, XrefRangeEnd = 805758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AfterglowXbox360WindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x000396D8 File Offset: 0x000378D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805758, XrefRangeEnd = 805762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AfterglowXbox360WindowsNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AfterglowXbox360WindowsNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AfterglowXbox360WindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x000067D6 File Offset: 0x000049D6
		public AfterglowXbox360WindowsNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
