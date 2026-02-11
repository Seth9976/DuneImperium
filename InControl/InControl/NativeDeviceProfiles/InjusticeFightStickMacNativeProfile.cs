using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020000A3 RID: 163
	public class InjusticeFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000B9D RID: 2973 RVA: 0x0003184C File Offset: 0x0002FA4C
		// Note: this type is marked as 'beforefieldinit'.
		static InjusticeFightStickMacNativeProfile()
		{
			Il2CppClassPointerStore<InjusticeFightStickMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "InjusticeFightStickMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InjusticeFightStickMacNativeProfile>.NativeClassPtr);
			InjusticeFightStickMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjusticeFightStickMacNativeProfile>.NativeClassPtr, 100664883);
			InjusticeFightStickMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjusticeFightStickMacNativeProfile>.NativeClassPtr, 100664884);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x000318A4 File Offset: 0x0002FAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792854, XrefRangeEnd = 792868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InjusticeFightStickMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x000318E0 File Offset: 0x0002FAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InjusticeFightStickMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InjusticeFightStickMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InjusticeFightStickMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x000062E1 File Offset: 0x000044E1
		public InjusticeFightStickMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
