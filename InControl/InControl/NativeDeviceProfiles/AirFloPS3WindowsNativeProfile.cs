using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000131 RID: 305
	public class AirFloPS3WindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000DFA RID: 3578 RVA: 0x00039714 File Offset: 0x00037914
		// Note: this type is marked as 'beforefieldinit'.
		static AirFloPS3WindowsNativeProfile()
		{
			Il2CppClassPointerStore<AirFloPS3WindowsNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "AirFloPS3WindowsNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AirFloPS3WindowsNativeProfile>.NativeClassPtr);
			AirFloPS3WindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirFloPS3WindowsNativeProfile>.NativeClassPtr, 100665204);
			AirFloPS3WindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirFloPS3WindowsNativeProfile>.NativeClassPtr, 100665205);
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x0003976C File Offset: 0x0003796C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805762, XrefRangeEnd = 806072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AirFloPS3WindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x000397A8 File Offset: 0x000379A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806072, XrefRangeEnd = 806076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AirFloPS3WindowsNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AirFloPS3WindowsNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirFloPS3WindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x000067DF File Offset: 0x000049DF
		public AirFloPS3WindowsNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
